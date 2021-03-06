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
    /// Mapping from a variable and a profile field
    /// </summary>
    [DataContract]
        public partial class MappingVariableProfileFieldRm :  IEquatable<MappingVariableProfileFieldRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingVariableProfileFieldRm" /> class.
        /// </summary>
        /// <param name="variable">variable (required).</param>
        /// <param name="profileFieldName">Profile field (required).</param>
        public MappingVariableProfileFieldRm(VariableInfoRm variable = default(VariableInfoRm), string profileFieldName = default(string))
        {
            // to ensure "variable" is required (not null)
            if (variable == null)
            {
                throw new InvalidDataException("variable is a required property for MappingVariableProfileFieldRm and cannot be null");
            }
            else
            {
                this.Variable = variable;
            }
            // to ensure "profileFieldName" is required (not null)
            if (profileFieldName == null)
            {
                throw new InvalidDataException("profileFieldName is a required property for MappingVariableProfileFieldRm and cannot be null");
            }
            else
            {
                this.ProfileFieldName = profileFieldName;
            }
        }
        
        /// <summary>
        /// Gets or Sets Variable
        /// </summary>
        [DataMember(Name="variable", EmitDefaultValue=false)]
        public VariableInfoRm Variable { get; set; }

        /// <summary>
        /// Profile field
        /// </summary>
        /// <value>Profile field</value>
        [DataMember(Name="profileFieldName", EmitDefaultValue=false)]
        public string ProfileFieldName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MappingVariableProfileFieldRm {\n");
            sb.Append("  Variable: ").Append(Variable).Append("\n");
            sb.Append("  ProfileFieldName: ").Append(ProfileFieldName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as MappingVariableProfileFieldRm);
        }

        /// <summary>
        /// Returns true if MappingVariableProfileFieldRm instances are equal
        /// </summary>
        /// <param name="input">Instance of MappingVariableProfileFieldRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MappingVariableProfileFieldRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variable == input.Variable ||
                    (this.Variable != null &&
                    this.Variable.Equals(input.Variable))
                ) && 
                (
                    this.ProfileFieldName == input.ProfileFieldName ||
                    (this.ProfileFieldName != null &&
                    this.ProfileFieldName.Equals(input.ProfileFieldName))
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
                int hashCode = 41;
                if (this.Variable != null)
                    hashCode = hashCode * 59 + this.Variable.GetHashCode();
                if (this.ProfileFieldName != null)
                    hashCode = hashCode * 59 + this.ProfileFieldName.GetHashCode();
                return hashCode;
            }
        }

    }
}
