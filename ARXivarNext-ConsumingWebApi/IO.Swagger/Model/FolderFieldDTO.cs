/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FolderFieldDTO
    /// </summary>
    [DataContract]
    public partial class FolderFieldDTO : FieldBaseDTO,  IEquatable<FolderFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderFieldDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FolderFieldDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderFieldDTO" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public FolderFieldDTO(FolderDTO value = default(FolderDTO), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = "FolderFieldDTO", bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> associations = default(List<AssocitationFieldItem>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string)) : base(name, externalId, description, order, dataSource, required, formula, className, locked, comboGruppiId, dependencyFields, associations, isAdditional, visible, predefinedProfileFormula)
        {
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public FolderDTO Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderFieldDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as FolderFieldDTO);
        }

        /// <summary>
        /// Returns true if FolderFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FolderFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FolderFieldDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
