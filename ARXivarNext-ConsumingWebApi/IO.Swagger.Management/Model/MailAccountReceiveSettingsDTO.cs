/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Abstract class for receiving mail
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(MailAccountReceiveSettingsImapDTO), "MailAccountReceiveSettingsImapDTO")]
    [JsonSubtypes.KnownSubType(typeof(MailAccountReceiveSettingsPop3DTO), "MailAccountReceiveSettingsPop3DTO")]
    public partial class MailAccountReceiveSettingsDTO :  IEquatable<MailAccountReceiveSettingsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountReceiveSettingsDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MailAccountReceiveSettingsDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountReceiveSettingsDTO" /> class.
        /// </summary>
        /// <param name="className">Name of class (required).</param>
        public MailAccountReceiveSettingsDTO(string className = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for MailAccountReceiveSettingsDTO and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }
        }
        
        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountReceiveSettingsDTO {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
            return this.Equals(input as MailAccountReceiveSettingsDTO);
        }

        /// <summary>
        /// Returns true if MailAccountReceiveSettingsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountReceiveSettingsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountReceiveSettingsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
