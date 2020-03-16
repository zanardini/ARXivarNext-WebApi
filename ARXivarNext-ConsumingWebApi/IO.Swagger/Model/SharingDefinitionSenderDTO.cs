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
    /// SharingDefinitionSenderDTO
    /// </summary>
    [DataContract]
    public partial class SharingDefinitionSenderDTO :  IEquatable<SharingDefinitionSenderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDefinitionSenderDTO" /> class.
        /// </summary>
        /// <param name="sharingDefinitionSenderId">Id..</param>
        /// <param name="sharingDefinitionId">Sharing Id.</param>
        /// <param name="email">Sender Email..</param>
        /// <param name="alias">External Id..</param>
        /// <param name="addressBookId">Id of the addressbook element..</param>
        public SharingDefinitionSenderDTO(string sharingDefinitionSenderId = default(string), string sharingDefinitionId = default(string), string email = default(string), string alias = default(string), int? addressBookId = default(int?))
        {
            this.SharingDefinitionSenderId = sharingDefinitionSenderId;
            this.SharingDefinitionId = sharingDefinitionId;
            this.Email = email;
            this.Alias = alias;
            this.AddressBookId = addressBookId;
        }
        
        /// <summary>
        /// Id.
        /// </summary>
        /// <value>Id.</value>
        [DataMember(Name="sharingDefinitionSenderId", EmitDefaultValue=false)]
        public string SharingDefinitionSenderId { get; set; }

        /// <summary>
        /// Sharing Id
        /// </summary>
        /// <value>Sharing Id</value>
        [DataMember(Name="sharingDefinitionId", EmitDefaultValue=false)]
        public string SharingDefinitionId { get; set; }

        /// <summary>
        /// Sender Email.
        /// </summary>
        /// <value>Sender Email.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// External Id.
        /// </summary>
        /// <value>External Id.</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Id of the addressbook element.
        /// </summary>
        /// <value>Id of the addressbook element.</value>
        [DataMember(Name="addressBookId", EmitDefaultValue=false)]
        public int? AddressBookId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingDefinitionSenderDTO {\n");
            sb.Append("  SharingDefinitionSenderId: ").Append(SharingDefinitionSenderId).Append("\n");
            sb.Append("  SharingDefinitionId: ").Append(SharingDefinitionId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  AddressBookId: ").Append(AddressBookId).Append("\n");
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
            return this.Equals(input as SharingDefinitionSenderDTO);
        }

        /// <summary>
        /// Returns true if SharingDefinitionSenderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingDefinitionSenderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingDefinitionSenderDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharingDefinitionSenderId == input.SharingDefinitionSenderId ||
                    (this.SharingDefinitionSenderId != null &&
                    this.SharingDefinitionSenderId.Equals(input.SharingDefinitionSenderId))
                ) && 
                (
                    this.SharingDefinitionId == input.SharingDefinitionId ||
                    (this.SharingDefinitionId != null &&
                    this.SharingDefinitionId.Equals(input.SharingDefinitionId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.AddressBookId == input.AddressBookId ||
                    (this.AddressBookId != null &&
                    this.AddressBookId.Equals(input.AddressBookId))
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
                if (this.SharingDefinitionSenderId != null)
                    hashCode = hashCode * 59 + this.SharingDefinitionSenderId.GetHashCode();
                if (this.SharingDefinitionId != null)
                    hashCode = hashCode * 59 + this.SharingDefinitionId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.AddressBookId != null)
                    hashCode = hashCode * 59 + this.AddressBookId.GetHashCode();
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
