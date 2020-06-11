using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ExampleBackOfficeService.Utilities.SwaggerExtensions
{
    /// <summary>
    /// Remove enums from any schema definition or reference
    /// The enum become an int32
    /// </summary>
    internal class RemoveEnumsDocumentFilter : IDocumentFilter
    {
        #region Methods

        /// <summary>
        /// Apply the filter.
        /// </summary>
        /// <param name="openApiDoc"><see cref="OpenApiDocument"/>.</param>
        /// <param name="context"><see cref="DocumentFilterContext"/>.</param>
        public void Apply(OpenApiDocument openApiDoc, DocumentFilterContext context)
        {
            // Dopo aver aggiornato tutte le descrizioni tolgo la parte di enum così l'enum viene interpretato come int
            // Cambio tipo enum -> int
            var dictEnumDefinitions = new Dictionary<string, OpenApiSchema>();

            foreach (var schemaDictionaryItem in openApiDoc.Components.Schemas)
            {
                var schema = schemaDictionaryItem.Value;

                if (schema.Enum != null && schema.Enum.Any())
                {
                    schema.Enum = null;
                    //Aggiungo alla mia lista tutti que
                    if (!dictEnumDefinitions.ContainsKey(schemaDictionaryItem.Key))
                    {
                        dictEnumDefinitions.Add(schemaDictionaryItem.Key, schemaDictionaryItem.Value);
                    }
                }
            }

            var parametersOp = openApiDoc.Paths.Values
                .SelectMany(v => v.Operations)
                .SelectMany(op => op.Value.Parameters)
                .ToList();
            for (var index = 0; index < parametersOp.Count; index++)
            {
                var parameter = parametersOp[index];
                UpdateEnumReference(parameter.Schema, dictEnumDefinitions, 1);
            }

            // Rimuovo dagli schema tutti gli enumerativi
            foreach (var enumKeyElement in dictEnumDefinitions)
            {
                openApiDoc.Components.Schemas.Remove(enumKeyElement);
            }

            // Ciclo i restanti schema per capire chi utilizzava questi enumerativi e gli associo un int
            foreach (var schemaDictionaryItem in openApiDoc.Components.Schemas)
            {
                var schema = schemaDictionaryItem.Value;

                foreach (KeyValuePair<string, OpenApiSchema> prop in schema.Properties)
                {
                    UpdateEnumReference(prop.Value, dictEnumDefinitions, 1);
                }
                foreach (OpenApiSchema allOfItem in schema.AllOf)
                {
                    UpdateEnumReference(allOfItem, dictEnumDefinitions, 1);
                }
                foreach (OpenApiSchema allOfItem in schema.AnyOf)
                {
                    UpdateEnumReference(allOfItem, dictEnumDefinitions, 1);
                }
            }
        }

        private static void UpdateEnumReference(OpenApiSchema propSchema, Dictionary<string, OpenApiSchema> dictEnumDefinitions, int levelRecursion)
        {
            if (levelRecursion > 100)
            {
                throw new Exception("Max level recursion");
            }

            if (propSchema.Reference != null)
            {
                SetIntReference(propSchema, dictEnumDefinitions);
            }

            if (propSchema.Type == "array")
            {
                if (propSchema.Items.Reference != null)
                {
                    SetIntReference(propSchema.Items, dictEnumDefinitions);
                }
            }

            if (propSchema.Properties != null)
            {
                foreach (var internalProp in propSchema.Properties)
                {
                    UpdateEnumReference(internalProp.Value, dictEnumDefinitions, levelRecursion + 1);
                }
            }
        }

        private static void SetIntReference(OpenApiSchema propSchema, Dictionary<string, OpenApiSchema> dictEnumDefinitions)
        {
            var componentReference = propSchema.Reference.Id;

            if (dictEnumDefinitions.ContainsKey(componentReference))
            {
                propSchema.Description = dictEnumDefinitions[componentReference].Description;

                propSchema.Type = "integer";
                propSchema.Format = "int32";
                propSchema.Reference = null;
            }
        }

        #endregion
    }
}