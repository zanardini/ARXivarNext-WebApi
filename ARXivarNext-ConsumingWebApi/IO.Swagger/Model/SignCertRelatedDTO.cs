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
    /// SignCertRelatedDTO
    /// </summary>
    [DataContract]
    public partial class SignCertRelatedDTO :  IEquatable<SignCertRelatedDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignCertRelatedDTO" /> class.
        /// </summary>
        /// <param name="signCertId">Identifier of signature certificate.</param>
        /// <param name="relatedCertId">Identifier of related certificate.</param>
        /// <param name="relatedCertDescription">Description of related certificate.</param>
        /// <param name="isActive">Certificate is Active.</param>
        public SignCertRelatedDTO(int? signCertId = default(int?), string relatedCertId = default(string), string relatedCertDescription = default(string), bool? isActive = default(bool?))
        {
            this.SignCertId = signCertId;
            this.RelatedCertId = relatedCertId;
            this.RelatedCertDescription = relatedCertDescription;
            this.IsActive = isActive;
        }
        
        /// <summary>
        /// Identifier of signature certificate
        /// </summary>
        /// <value>Identifier of signature certificate</value>
        [DataMember(Name="signCertId", EmitDefaultValue=false)]
        public int? SignCertId { get; set; }

        /// <summary>
        /// Identifier of related certificate
        /// </summary>
        /// <value>Identifier of related certificate</value>
        [DataMember(Name="relatedCertId", EmitDefaultValue=false)]
        public string RelatedCertId { get; set; }

        /// <summary>
        /// Description of related certificate
        /// </summary>
        /// <value>Description of related certificate</value>
        [DataMember(Name="relatedCertDescription", EmitDefaultValue=false)]
        public string RelatedCertDescription { get; set; }

        /// <summary>
        /// Certificate is Active
        /// </summary>
        /// <value>Certificate is Active</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignCertRelatedDTO {\n");
            sb.Append("  SignCertId: ").Append(SignCertId).Append("\n");
            sb.Append("  RelatedCertId: ").Append(RelatedCertId).Append("\n");
            sb.Append("  RelatedCertDescription: ").Append(RelatedCertDescription).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as SignCertRelatedDTO);
        }

        /// <summary>
        /// Returns true if SignCertRelatedDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SignCertRelatedDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignCertRelatedDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignCertId == input.SignCertId ||
                    (this.SignCertId != null &&
                    this.SignCertId.Equals(input.SignCertId))
                ) && 
                (
                    this.RelatedCertId == input.RelatedCertId ||
                    (this.RelatedCertId != null &&
                    this.RelatedCertId.Equals(input.RelatedCertId))
                ) && 
                (
                    this.RelatedCertDescription == input.RelatedCertDescription ||
                    (this.RelatedCertDescription != null &&
                    this.RelatedCertDescription.Equals(input.RelatedCertDescription))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
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
                if (this.SignCertId != null)
                    hashCode = hashCode * 59 + this.SignCertId.GetHashCode();
                if (this.RelatedCertId != null)
                    hashCode = hashCode * 59 + this.RelatedCertId.GetHashCode();
                if (this.RelatedCertDescription != null)
                    hashCode = hashCode * 59 + this.RelatedCertDescription.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
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
