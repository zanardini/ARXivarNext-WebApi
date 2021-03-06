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
    /// VariableArrayConfigurationRm
    /// </summary>
    [DataContract]
        public partial class VariableArrayConfigurationRm : VariabileConfigurationRm,  IEquatable<VariableArrayConfigurationRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableArrayConfigurationRm" /> class.
        /// </summary>
        /// <param name="maxRowLength">The maximum number of rows.  The default value is 0 (Unbound).</param>
        /// <param name="valueType">Indicates the matrix value type [0&#x3D;Auto, 1&#x3D;String, 2&#x3D;Custom].</param>
        /// <param name="customConfiguration">customConfiguration.</param>
        /// <param name="evaluateEvent">evaluateEvent.</param>
        public VariableArrayConfigurationRm(int? maxRowLength = default(int?), int? valueType = default(int?), VariabileConfigurationRm customConfiguration = default(VariabileConfigurationRm), EvaluateEventRm evaluateEvent = default(EvaluateEventRm), int? variableType = default(int?), string name = default(string), bool? encryption = default(bool?), List<MultiLanguageValueRm> labels = default(List<MultiLanguageValueRm>), List<MultiLanguageValueRm> descriptions = default(List<MultiLanguageValueRm>), int? validationType = default(int?), string validationString = default(string), List<MultiLanguageValueRm> validationErrors = default(List<MultiLanguageValueRm>)) : base(variableType, name, encryption, labels, descriptions, validationType, validationString, validationErrors)
        {
            this.MaxRowLength = maxRowLength;
            this.ValueType = valueType;
            this.CustomConfiguration = customConfiguration;
            this.EvaluateEvent = evaluateEvent;
        }
        
        /// <summary>
        /// The maximum number of rows.  The default value is 0 (Unbound)
        /// </summary>
        /// <value>The maximum number of rows.  The default value is 0 (Unbound)</value>
        [DataMember(Name="maxRowLength", EmitDefaultValue=false)]
        public int? MaxRowLength { get; set; }

        /// <summary>
        /// Indicates the matrix value type [0&#x3D;Auto, 1&#x3D;String, 2&#x3D;Custom]
        /// </summary>
        /// <value>Indicates the matrix value type [0&#x3D;Auto, 1&#x3D;String, 2&#x3D;Custom]</value>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public int? ValueType { get; set; }

        /// <summary>
        /// Gets or Sets CustomConfiguration
        /// </summary>
        [DataMember(Name="customConfiguration", EmitDefaultValue=false)]
        public VariabileConfigurationRm CustomConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets EvaluateEvent
        /// </summary>
        [DataMember(Name="evaluateEvent", EmitDefaultValue=false)]
        public EvaluateEventRm EvaluateEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableArrayConfigurationRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  MaxRowLength: ").Append(MaxRowLength).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  CustomConfiguration: ").Append(CustomConfiguration).Append("\n");
            sb.Append("  EvaluateEvent: ").Append(EvaluateEvent).Append("\n");
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
            return this.Equals(input as VariableArrayConfigurationRm);
        }

        /// <summary>
        /// Returns true if VariableArrayConfigurationRm instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableArrayConfigurationRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableArrayConfigurationRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.MaxRowLength == input.MaxRowLength ||
                    (this.MaxRowLength != null &&
                    this.MaxRowLength.Equals(input.MaxRowLength))
                ) && base.Equals(input) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && base.Equals(input) && 
                (
                    this.CustomConfiguration == input.CustomConfiguration ||
                    (this.CustomConfiguration != null &&
                    this.CustomConfiguration.Equals(input.CustomConfiguration))
                ) && base.Equals(input) && 
                (
                    this.EvaluateEvent == input.EvaluateEvent ||
                    (this.EvaluateEvent != null &&
                    this.EvaluateEvent.Equals(input.EvaluateEvent))
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
                if (this.MaxRowLength != null)
                    hashCode = hashCode * 59 + this.MaxRowLength.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.CustomConfiguration != null)
                    hashCode = hashCode * 59 + this.CustomConfiguration.GetHashCode();
                if (this.EvaluateEvent != null)
                    hashCode = hashCode * 59 + this.EvaluateEvent.GetHashCode();
                return hashCode;
            }
        }

    }
}
