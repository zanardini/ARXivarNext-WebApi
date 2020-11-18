/* 
 * ARXivar Workflow API
 *
 * ARXivar Workflow API
 *
 * OpenAPI spec version: v1
 * Contact: info@abletech.it
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Workflow.Client.SwaggerDateConverter;

namespace IO.Swagger.Workflow.Model
{
    /// <summary>
    /// MatrixCustomMappingApiResultItemRm
    /// </summary>
    [DataContract]
        public partial class MatrixCustomMappingApiResultItemRm : BaseMappingApiResultItemRm,  IEquatable<MatrixCustomMappingApiResultItemRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixCustomMappingApiResultItemRm" /> class.
        /// </summary>
        /// <param name="columnMapping">Mapping definition to matrix (required).</param>
        public MatrixCustomMappingApiResultItemRm(List<MatrixCustomMappingApiColumnResultItemRm> columnMapping = default(List<MatrixCustomMappingApiColumnResultItemRm>), int? mappingType = default(int?)) : base(mappingType)
        {
            // to ensure "columnMapping" is required (not null)
            if (columnMapping == null)
            {
                throw new InvalidDataException("columnMapping is a required property for MatrixCustomMappingApiResultItemRm and cannot be null");
            }
            else
            {
                this.ColumnMapping = columnMapping;
            }
        }
        
        /// <summary>
        /// Mapping definition to matrix
        /// </summary>
        /// <value>Mapping definition to matrix</value>
        [DataMember(Name="columnMapping", EmitDefaultValue=false)]
        public List<MatrixCustomMappingApiColumnResultItemRm> ColumnMapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatrixCustomMappingApiResultItemRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ColumnMapping: ").Append(ColumnMapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MatrixCustomMappingApiResultItemRm);
        }

        /// <summary>
        /// Returns true if MatrixCustomMappingApiResultItemRm instances are equal
        /// </summary>
        /// <param name="input">Instance of MatrixCustomMappingApiResultItemRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatrixCustomMappingApiResultItemRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ColumnMapping == input.ColumnMapping ||
                    this.ColumnMapping != null &&
                    input.ColumnMapping != null &&
                    this.ColumnMapping.SequenceEqual(input.ColumnMapping)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.ColumnMapping != null)
                    hashCode = hashCode * 59 + this.ColumnMapping.GetHashCode();
                return hashCode;
            }
        }

    }
}
