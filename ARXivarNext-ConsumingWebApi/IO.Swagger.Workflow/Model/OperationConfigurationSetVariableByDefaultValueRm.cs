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
    /// OperationConfigurationSetVariableByDefaultValueRm
    /// </summary>
    [DataContract]
        public partial class OperationConfigurationSetVariableByDefaultValueRm : OperationsConfigurationRm,  IEquatable<OperationConfigurationSetVariableByDefaultValueRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationConfigurationSetVariableByDefaultValueRm" /> class.
        /// </summary>
        /// <param name="variable">variable (required).</param>
        /// <param name="value">value (required).</param>
        public OperationConfigurationSetVariableByDefaultValueRm(VariableInfoRm variable = default(VariableInfoRm), VariableDefaultValueRm value = default(VariableDefaultValueRm), int? operationType = default(int?), OperationRetryConfigurationRm retryConfiguration = default(OperationRetryConfigurationRm), EventInfoRm onErrorEventConfiguration = default(EventInfoRm), EventInfoRm onFailedEventConfiguration = default(EventInfoRm), bool? invalidateOtherOperations = default(bool?), string userDescription = default(string)) : base(operationType, retryConfiguration, onErrorEventConfiguration, onFailedEventConfiguration, invalidateOtherOperations, userDescription)
        {
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for OperationConfigurationSetVariableByDefaultValueRm and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for OperationConfigurationSetVariableByDefaultValueRm and cannot be null");
            }
            else
            {
                this.Value = value;
            }
        }
        
        /// <summary>
        /// Gets or Sets Variable
        /// </summary>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public VariableInfoRm Variable { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public VariableDefaultValueRm Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationConfigurationSetVariableByDefaultValueRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as OperationConfigurationSetVariableByDefaultValueRm);
        }

        /// <summary>
        /// Returns true if OperationConfigurationSetVariableByDefaultValueRm instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationConfigurationSetVariableByDefaultValueRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationConfigurationSetVariableByDefaultValueRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
