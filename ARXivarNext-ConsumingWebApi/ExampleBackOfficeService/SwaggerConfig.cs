using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using JsonSubTypes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using ExampleBackOfficeService.Utilities.SwaggerExtensions;

namespace ExampleBackOfficeService
{
    /// <summary>
    /// Raggruppamento delle personalizzazioni relative a swagger
    /// </summary>
    public static class SwaggerConfig
    {
        /// <summary>
        /// Aggiunge la parte relativa alla security delle API
        /// </summary>
        /// <param name="options"></param>
        public static void AddSecurityConfiguration(this SwaggerGenOptions options)
        {
            options.AddSecurityDefinition("Bearer",
                new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter into field the word 'bearer' following by space and access token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header
                    },
                    new List<string>()
                }
            });
        }

        /// <summary>
        /// Creato per sopperire ad un problema di swagger codegen >= 2.3.0
        /// che genera la classe problem Details in modo errato
        /// </summary>
        /// <param name="options"></param>
        public static void DisableAdditionalProperties(this SwaggerGenOptions options)
        {
            options.SchemaFilter<AdditionalPropertiesDisableSchemaFilter>();
        }

        /// <summary>
        /// Aggiunta della documentazione XML
        /// </summary>
        /// <param name="options"></param>
        public static void AddXmlDocumentation(this SwaggerGenOptions options)
        {
            var baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            baseDirectory = Path.Combine(baseDirectory, "App_Data");

            var apiDocumentationFile = Path.Combine(baseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");
            options.IncludeXmlComments(apiDocumentationFile, true);

            var modelsDocumentationFile = Path.Combine(baseDirectory, "Abletech.Workflow.WebApi.Models.xml");
            options.IncludeXmlComments(modelsDocumentationFile);
        }

        /// <summary>
        /// Aggiunge alle API la parte finale di counters
        /// </summary>
        /// <param name="options"></param>
        public static void AddApiCounters(this SwaggerGenOptions options)
        {
            options.DocumentFilter<AppendActionCountToTagSummaryDocumentFilter>();
        }

        /// <summary>
        /// Sort schema in the documentations
        /// </summary>
        /// <param name="options"></param>
        public static void SortSchemas(this SwaggerGenOptions options)
        {
            options.DocumentFilter<SortSchemasDocumentFilter>();
        }

        /// <summary>
        /// Aggiunge a swagger la documentazione relativa agli enumerativi
        /// </summary>
        /// <param name="options"></param>
        public static void AddEnumDocumentation(this SwaggerGenOptions options)
        {
            options.SchemaFilter<XEnumNamesSchemaFilter>();
            options.ParameterFilter<XEnumNamesParameterFilter>();
            options.DocumentFilter<DisplayEnumsWithValuesDocumentFilter>();
            options.DocumentFilter<RemoveEnumsDocumentFilter>(); //DA usare DOPO DisplayEnumsWithValuesDocumentFilter 
        }

        /// <summary>
        /// Aggiunge la parte di informazioni polimorfiche
        /// </summary>
        public static void AddPolymorphism(this SwaggerGenOptions options, params Assembly[] assembliesToScan)
        {
            //var attribute = assembliesToScan
            //    .SelectMany(x => x.ExportedTypes)
            //    .Select(x => x.GetCustomAttribute<JsonConverterAttribute>(false))
            //    .Where(x => x != null && typeof(JsonPolymorphicConverter)
            //        .IsAssignableFrom(x.ConverterType));

            var types = assembliesToScan
                .SelectMany(x => x.ExportedTypes)
                .Where(x => x.GetCustomAttribute<JsonConverterAttribute>(false) != null)
                .ToList();

            foreach (var baseType in types)
            {
                var attribute = baseType.GetCustomAttribute<JsonConverterAttribute>();
                var discriminator = attribute.ConverterParameters.FirstOrDefault() as string;
                var mapping = new Dictionary<string, Type>();

                var concreteAttributes = baseType.GetCustomAttributes<JsonSubtypes.KnownSubTypeAttribute>().ToList();

                if (!concreteAttributes.Any())
                {
                    continue;
                }

                foreach (var ca in concreteAttributes)
                {
                    mapping.Add(ca.SubType.FullName, ca.SubType);
                }

                //options.SchemaFilter<PolymorphicSchemaFilter>(baseType, discriminator, mapping);
            }
        }
    }
}
