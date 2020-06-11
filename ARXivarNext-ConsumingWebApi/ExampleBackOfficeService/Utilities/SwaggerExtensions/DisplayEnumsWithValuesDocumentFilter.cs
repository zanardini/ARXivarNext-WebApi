using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.XPath;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    internal class DisplayEnumsWithValuesDocumentFilter : IDocumentFilter
    {
        #region Methods

        /// <summary>
        /// Apply the filter.
        /// </summary>
        /// <param name="openApiDoc"><see cref="OpenApiDocument"/>.</param>
        /// <param name="context"><see cref="DocumentFilterContext"/>.</param>
        public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
        {
            foreach (var schemaDictionaryItem in openApiDoc.Components.Schemas)
            {
                var schema = schemaDictionaryItem.Value;
                var description = schema.AddEnumValuesDescription(true);
                if (description != null)
                {
                    schema.Description += (" " + description);
                }
            }

            if (openApiDoc.Paths.Count <= 0)
            {
                return;
            }

            // add enum descriptions to input parameters of every operation
            foreach (var parameter in openApiDoc.Paths.Values.SelectMany(v => v.Operations).SelectMany(op => op.Value.Parameters))
            {
                if (parameter.Schema.Reference == null)
                {
                    continue;
                }

                var componentReference = parameter.Schema.Reference.Id;
                var schema = openApiDoc.Components.Schemas[componentReference];
                var description = schema.AddEnumValuesDescription(true);
                if (description != null)
                {
                    parameter.Description += (" " + description);
                }
            }

            // add enum descriptions to request body
            foreach (var operation in openApiDoc.Paths.Values.SelectMany(v => v.Operations))
            {
                var requestBodyContents = operation.Value.RequestBody?.Content;
                if (requestBodyContents != null)
                {
                    foreach (var requestBodyContent in requestBodyContents)
                    {
                        if (requestBodyContent.Value.Schema?.Reference?.Id != null)
                        {
                            var schema = context.SchemaRepository.Schemas[requestBodyContent.Value.Schema?.Reference?.Id];
                            if (schema != null)
                            {
                                requestBodyContent.Value.Schema.Description = schema.Description;
                                requestBodyContent.Value.Schema.Extensions = schema.Extensions;
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}