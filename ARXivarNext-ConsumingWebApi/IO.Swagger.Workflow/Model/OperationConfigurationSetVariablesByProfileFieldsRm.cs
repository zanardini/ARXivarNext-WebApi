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
    /// OperationConfigurationSetVariablesByProfileFieldsRm
    /// </summary>
    [DataContract]
        public partial class OperationConfigurationSetVariablesByProfileFieldsRm : OperationsConfigurationRm,  IEquatable<OperationConfigurationSetVariablesByProfileFieldsRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationConfigurationSetVariablesByProfileFieldsRm" /> class.
        /// </summary>
        /// <param name="mappings">Mapping from profile fields and variables (required).</param>
        public OperationConfigurationSetVariablesByProfileFieldsRm(List<MappingVariableProfileFieldRm> mappings = default(List<MappingVariableProfileFieldRm>), int? operationType = default(int?), OperationRetryConfigurationRm retryConfiguration = default(OperationRetryConfigurationRm), EventInfoRm onErrorEventConfiguration = default(EventInfoRm), EventInfoRm onFailedEventConfiguration = default(EventInfoRm), bool? invalidateOtherOperations = default(bool?), string userDescription = default(string)) : base(operationType, retryConfiguration, onErrorEventConfiguration, onFailedEventConfiguration, invalidateOtherOperations, userDescription)
        {
            // to ensure "mappings" is required (not null)
            if (mappings == null)
            {
                throw new InvalidDataException("mappings is a required property for OperationConfigurationSetVariablesByProfileFieldsRm and cannot be null");
            }
            else
            {
                this.Mappings = mappings;
            }
        }
        
        /// <summary>
        /// Mapping from profile fields and variables
        /// </summary>
        /// <value>Mapping from profile fields and variables</value>
        [DataMember(Name="mappings", EmitDefaultValue=false)]
        public List<MappingVariableProfileFieldRm> Mappings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationConfigurationSetVariablesByProfileFieldsRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Mappings: ").Append(Mappings).Append("\n");
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
            return this.Equals(input as OperationConfigurationSetVariablesByProfileFieldsRm);
        }

        /// <summary>
        /// Returns true if OperationConfigurationSetVariablesByProfileFieldsRm instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationConfigurationSetVariablesByProfileFieldsRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationConfigurationSetVariablesByProfileFieldsRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Mappings == input.Mappings ||
                    this.Mappings != null &&
                    input.Mappings != null &&
                    this.Mappings.SequenceEqual(input.Mappings)
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
                if (this.Mappings != null)
                    hashCode = hashCode * 59 + this.Mappings.GetHashCode();
                return hashCode;
            }
        }

    }
}
