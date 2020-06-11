using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    /// <summary>
    /// Sort schema document filter
    /// </summary>
    public sealed class SortSchemasDocumentFilter : IDocumentFilter
    {
        /// <summary>
        /// Try to sort the data definitions that appear in the "Schemas" section of the Swagger page.
        /// This is an ugly way to do it.
        /// </summary>
        /// <param name="openApiDoc">The swagger document</param>
        /// <param name="context">The filter context</param>
        public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
        {
            if (openApiDoc == null)
                throw new ArgumentNullException(nameof(openApiDoc));
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var schemaList = new List<KeyValuePair<string, OpenApiSchema>>();
            foreach (var kv in openApiDoc.Components.Schemas)
            {
                schemaList.Add(kv);
            }

            int KvCompare(KeyValuePair<string, OpenApiSchema> x, KeyValuePair<string, OpenApiSchema> y)
            {
                return string.Compare(x.Key, y.Key, StringComparison.InvariantCulture);
            }

            schemaList.Sort(KvCompare);

            var newDict = new Dictionary<string, OpenApiSchema>();
            foreach (var kv in schemaList)
            {
                newDict.Add(kv.Key, kv.Value);
            }

            openApiDoc.Components.Schemas = newDict;
        }
    }
}