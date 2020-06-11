using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    public class AdditionalPropertiesDisableSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema.AdditionalProperties != null)
            {
                schema.AdditionalPropertiesAllowed = false;
            }
        }
    }
}