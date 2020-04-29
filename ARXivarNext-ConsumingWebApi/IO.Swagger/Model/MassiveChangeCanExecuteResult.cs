/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
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
    /// Dto for possible start of a massive change
    /// </summary>
    [DataContract]
    public partial class MassiveChangeCanExecuteResult :  IEquatable<MassiveChangeCanExecuteResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MassiveChangeCanExecuteResult" /> class.
        /// </summary>
        /// <param name="canExecute">Can execute information for the user.</param>
        /// <param name="errorMEssage">Optional message for the user.</param>
        public MassiveChangeCanExecuteResult(bool? canExecute = default(bool?), string errorMEssage = default(string))
        {
            this.CanExecute = canExecute;
            this.ErrorMEssage = errorMEssage;
        }
        
        /// <summary>
        /// Can execute information for the user
        /// </summary>
        /// <value>Can execute information for the user</value>
        [DataMember(Name="canExecute", EmitDefaultValue=false)]
        public bool? CanExecute { get; set; }

        /// <summary>
        /// Optional message for the user
        /// </summary>
        /// <value>Optional message for the user</value>
        [DataMember(Name="errorMEssage", EmitDefaultValue=false)]
        public string ErrorMEssage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MassiveChangeCanExecuteResult {\n");
            sb.Append("  CanExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  ErrorMEssage: ").Append(ErrorMEssage).Append("\n");
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
            return this.Equals(input as MassiveChangeCanExecuteResult);
        }

        /// <summary>
        /// Returns true if MassiveChangeCanExecuteResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MassiveChangeCanExecuteResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MassiveChangeCanExecuteResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanExecute == input.CanExecute ||
                    (this.CanExecute != null &&
                    this.CanExecute.Equals(input.CanExecute))
                ) && 
                (
                    this.ErrorMEssage == input.ErrorMEssage ||
                    (this.ErrorMEssage != null &&
                    this.ErrorMEssage.Equals(input.ErrorMEssage))
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
                if (this.CanExecute != null)
                    hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.ErrorMEssage != null)
                    hashCode = hashCode * 59 + this.ErrorMEssage.GetHashCode();
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