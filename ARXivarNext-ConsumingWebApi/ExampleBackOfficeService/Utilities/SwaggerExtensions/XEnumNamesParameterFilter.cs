using System;
using System.Linq;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    internal class XEnumNamesParameterFilter : IParameterFilter
    {
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            var typeInfo = context.ParameterInfo?.ParameterType ?? context.PropertyInfo.PropertyType;
            var enumsArray = new OpenApiArray();
            if (typeInfo.IsEnum)
            {
                var names = Enum.GetNames(typeInfo).Select(name => new OpenApiString(name));
                enumsArray.AddRange(names);
                if (!parameter.Extensions.ContainsKey("x-enumNames") && enumsArray.Any())
                {
                    parameter.Extensions.Add("x-enumNames", enumsArray);
                }
            }
            else if (typeInfo.IsGenericType && !parameter.Extensions.ContainsKey("x-enumNames"))
            {
                foreach (var genericArgumentType in typeInfo.GetGenericArguments())
                {
                    if (genericArgumentType.IsEnum)
                    {
                        var names = Enum.GetNames(genericArgumentType).Select(name => new OpenApiString(name));
                        enumsArray.AddRange(names);
                        if (!parameter.Extensions.ContainsKey("x-enumNames") && enumsArray.Any())
                        {
                            parameter.Extensions.Add("x-enumNames", enumsArray);
                        }
                    }
                }
            }
        }
    }
}