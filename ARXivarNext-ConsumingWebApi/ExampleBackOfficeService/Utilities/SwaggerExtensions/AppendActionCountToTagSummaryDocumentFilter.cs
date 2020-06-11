using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Xml.XPath;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    internal class AppendActionCountToTagSummaryDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
        {
            if (openApiDoc.Tags == null)
            {
                return;
            }

            var tagActionCount = new Dictionary<string, int>();
            foreach (var path in openApiDoc.Paths)
            {
                var possibleParameterizedOperations = path.Value.Operations.Select(o => o.Value);
                possibleParameterizedOperations.Where(o => o?.Tags != null).ToList().ForEach(o =>
                {
                    foreach (var tag in o.Tags)
                    {
                        if (!tagActionCount.ContainsKey(tag.Name))
                        {
                            tagActionCount.Add(tag.Name, 1);
                        }
                        else
                        {
                            tagActionCount[tag.Name]++;
                        }
                    }
                });
            }

            foreach (var tagActionCountKey in tagActionCount.Keys)
            {
                foreach (var tag in openApiDoc.Tags)
                {
                    if (tag.Name == tagActionCountKey)
                    {
                        tag.Description += $" (Action count: {tagActionCount[tagActionCountKey]})";
                    }
                }
            }
        }
    }

    internal static class EnumTypeExtensions
    {
        private static string GetDescriptionFromEnumOption(Type enumOptionType, object enumOption)
        {
            return enumOptionType.GetFieldAttributeDescription(enumOption, 0);
        }

        private static string GetFieldAttributeDescription(this Type enumType, object enumField, int attributeNumber)
        {
            if (!enumType.IsEnum)
            {
                return string.Empty;
            }

            var memInfo = enumType.GetMember(enumField.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return (attributes[attributeNumber] as DescriptionAttribute)?.Description ?? string.Empty;
            }
            return string.Empty;
        }

        internal static List<OpenApiString> GetEnumValuesDescription(Type enumType, DescriptionSources descriptionSource, IEnumerable<XPathNavigator> xmlNavigators = null)
        {
            var enumsDescriptions = new List<OpenApiString>();
            foreach (var enumValue in Enum.GetValues(enumType))
            {
                var enumDescription = string.Empty;
                try
                {
                    switch (descriptionSource)
                    {
                        case DescriptionSources.DescriptionAttributes:
                            enumDescription = GetDescriptionFromEnumOption(enumType, enumValue);
                            break;
                        case DescriptionSources.XmlComments:
                            var memberInfo = enumType.GetMembers().FirstOrDefault(m =>
                                m.Name.Equals(enumValue.ToString(), StringComparison.InvariantCultureIgnoreCase));
                            enumDescription = TryGetMemberComments(memberInfo, xmlNavigators);
                            break;
                        case DescriptionSources.DescriptionAttributesThenXmlComments:
                            enumDescription = GetDescriptionFromEnumOption(enumType, enumValue);
                            if (string.IsNullOrWhiteSpace(enumDescription))
                            {
                                var memberInfo2 = enumType.GetMembers().FirstOrDefault(m =>
                                    m.Name.Equals(enumValue.ToString(), StringComparison.InvariantCultureIgnoreCase));
                                enumDescription = TryGetMemberComments(memberInfo2, xmlNavigators);
                            }
                            break;
                    }
                }

                finally
                {
                    enumsDescriptions.Add(new OpenApiString(enumDescription));
                }
            }
            return enumsDescriptions;
        }

        private static string TryGetMemberComments(MemberInfo memberInfo, IEnumerable<XPathNavigator> xmlNavigators)
        {
            if (xmlNavigators == null)
                return string.Empty;

            foreach (var xmlNavigator in xmlNavigators)
            {
                var nodeNameForMember = GetNodeNameForMember(memberInfo);
                var xpathNavigator1 = xmlNavigator.SelectSingleNode(
                    $"/doc/members/member[@name='{nodeNameForMember}']");
                var xpathNavigator2 = xpathNavigator1?.SelectSingleNode("summary");
                return xpathNavigator2 != null ? XmlCommentsTextHelper.Humanize(xpathNavigator2.InnerXml) : string.Empty;
            }

            return string.Empty;
        }

        public static string GetNodeNameForMember(MemberInfo memberInfo)
        {
            var builder = new StringBuilder(((memberInfo.MemberType & MemberTypes.Field) != 0) ? "F:" : "P:");
            builder.Append(QualifiedNameFor(memberInfo.DeclaringType));
            builder.Append($".{memberInfo.Name}");

            return builder.ToString();
        }
        private static string QualifiedNameFor(Type type, bool expandGenericArgs = false)
        {
            if (type.IsArray)
                return $"{QualifiedNameFor(type.GetElementType(), expandGenericArgs)}[]";

            var builder = new StringBuilder();

            if (!string.IsNullOrEmpty(type.Namespace))
                builder.Append($"{type.Namespace}.");

            if (type.IsNested)
                builder.Append($"{type.DeclaringType.Name}.");

            if (type.IsConstructedGenericType && expandGenericArgs)
            {
                var nameSansGenericArgs = type.Name.Split('`').First();
                builder.Append(nameSansGenericArgs);

                var genericArgsNames = type.GetGenericArguments().Select(t =>
                {
                    return t.IsGenericParameter
                        ? $"`{t.GenericParameterPosition}"
                        : QualifiedNameFor(t, true);
                });

                builder.Append($"{{{string.Join(",", genericArgsNames)}}}");
            }
            else
            {
                builder.Append(type.Name);
            }

            return builder.ToString();
        }


        internal static string AddEnumValuesDescription(this OpenApiSchema schema, bool includeDescriptionFromAttribute = false)
        {
            if (schema.Enum == null || schema.Enum.Count == 0)
                return null;

            if (!schema.Extensions.ContainsKey("x-enumNames") || ((OpenApiArray)schema.Extensions["x-enumNames"]).Count != schema.Enum.Count)
                return null;

            var sb = new StringBuilder();
            for (var i = 0; i < schema.Enum.Count; i++)
            {
                if (schema.Enum[i] is OpenApiInteger schemaEnumInt)
                {
                    var value = schemaEnumInt.Value;
                    var name = ((OpenApiString)((OpenApiArray)schema.Extensions["x-enumNames"])[i]).Value;
                    //sb.Append($"{Environment.NewLine}{value}={name}");
                    sb.Append($"{value}={name}");
                }
                else if (schema.Enum[i] is OpenApiString schemaEnumString)
                {
                    var value = schemaEnumString.Value;
                    sb.Append($"{value}");
                }
                if (i != (schema.Enum.Count - 1))
                {
                    sb.Append(", ");
                }

                //// add description from DescriptionAttribute
                //if (includeDescriptionFromAttribute)
                //{
                //    if (!schema.Extensions.ContainsKey("x-enumDescriptions"))
                //        continue;

                //    var xEnumDescriptions = (OpenApiArray)schema.Extensions["x-enumDescriptions"];
                //    if (xEnumDescriptions?.Count == schema.Enum.Count)
                //    {
                //        var description = ((OpenApiString)((OpenApiArray)schema.Extensions["x-enumDescriptions"])[i]).Value;
                //        if (!string.IsNullOrWhiteSpace(description))
                //            sb.Append($" ({description})");
                //    }
                //}
            }
            return  "[" +  sb.ToString() + "]";
        }
    }

    public enum DescriptionSources
    {
        /// <summary>
        /// <see cref="DescriptionAttribute"/>.
        /// </summary>
        DescriptionAttributes = 0,

        /// <summary>
        /// Xml comments.
        /// </summary>
        XmlComments = 1,

        /// <summary>
        /// <see cref="DescriptionAttribute"/> then xml comments.
        /// </summary>
        DescriptionAttributesThenXmlComments = 2
    }
}
