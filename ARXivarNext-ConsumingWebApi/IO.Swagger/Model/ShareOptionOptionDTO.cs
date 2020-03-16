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
    /// ShareOptionOptionDTO
    /// </summary>
    [DataContract]
    public partial class ShareOptionOptionDTO :  IEquatable<ShareOptionOptionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareOptionOptionDTO" /> class.
        /// </summary>
        /// <param name="option">Possible values:  1: Read  2: ReadAndWrite .</param>
        /// <param name="optionUserMessage">User label for this option.</param>
        public ShareOptionOptionDTO(int? option = default(int?), string optionUserMessage = default(string))
        {
            this.Option = option;
            this.OptionUserMessage = optionUserMessage;
        }
        
        /// <summary>
        /// Possible values:  1: Read  2: ReadAndWrite 
        /// </summary>
        /// <value>Possible values:  1: Read  2: ReadAndWrite </value>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public int? Option { get; set; }

        /// <summary>
        /// User label for this option
        /// </summary>
        /// <value>User label for this option</value>
        [DataMember(Name="optionUserMessage", EmitDefaultValue=false)]
        public string OptionUserMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareOptionOptionDTO {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  OptionUserMessage: ").Append(OptionUserMessage).Append("\n");
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
            return this.Equals(input as ShareOptionOptionDTO);
        }

        /// <summary>
        /// Returns true if ShareOptionOptionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ShareOptionOptionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareOptionOptionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
                ) && 
                (
                    this.OptionUserMessage == input.OptionUserMessage ||
                    (this.OptionUserMessage != null &&
                    this.OptionUserMessage.Equals(input.OptionUserMessage))
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
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                if (this.OptionUserMessage != null)
                    hashCode = hashCode * 59 + this.OptionUserMessage.GetHashCode();
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
            yield break;
        }
    }

}
