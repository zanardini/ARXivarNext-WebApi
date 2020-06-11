using System;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    internal class XEnumNamesSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var typeInfo = context.Type.GetTypeInfo();
            var enumsArray = new OpenApiArray();
            if (typeInfo.IsEnum)
            {
                var names = Enum.GetNames(context.Type).Select(name => new OpenApiString(name)).ToList();
                enumsArray.AddRange(names);
                if (!schema.Extensions.ContainsKey("x-enumNames") && enumsArray.Any())
                {
                    schema.Extensions.Add("x-enumNames", enumsArray);
                }
               
                return;
            }

            // add "x-enumNames" for schema with generic types
            if (typeInfo.IsGenericType && !schema.Extensions.ContainsKey("x-enumNames"))
            {
                foreach (var genericArgumentType in typeInfo.GetGenericArguments())
                {
                    if (genericArgumentType.IsEnum)
                    {
                        if (schema.Properties?.Count > 0)
                        {
                            foreach (var schemaProperty in schema.Properties)
                            {
                                var schemaPropertyValue = schemaProperty.Value;
                                var propertySchema = context.SchemaRepository.Schemas.FirstOrDefault(s => schemaPropertyValue.AllOf.FirstOrDefault(a => a.Reference.Id == s.Key) != null).Value;
                                if (propertySchema != null)
                                {
                                    var names = Enum.GetNames(genericArgumentType).Select(name => new OpenApiString(name));
                                    enumsArray.AddRange(names);
                                    if (!schemaPropertyValue.Extensions.ContainsKey("x-enumNames") && enumsArray.Any())
                                    {
                                        schemaPropertyValue.Extensions.Add("x-enumNames", enumsArray);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}