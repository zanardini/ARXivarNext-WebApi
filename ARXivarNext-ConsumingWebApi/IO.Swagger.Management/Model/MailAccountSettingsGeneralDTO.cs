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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Class for Mail general settings
    /// </summary>
    [DataContract]
    public partial class MailAccountSettingsGeneralDTO :  IEquatable<MailAccountSettingsGeneralDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountSettingsGeneralDTO" /> class.
        /// </summary>
        /// <param name="mail">User e-mail.</param>
        /// <param name="notify">Notification of movement via SMTP.</param>
        /// <param name="internalFax">Personal Fax.</param>
        /// <param name="lastMail">Date of last reading email.</param>
        /// <param name="mailBody">Txt Disclamer.</param>
        /// <param name="maxMailOutSize">Mail out max size.</param>
        public MailAccountSettingsGeneralDTO(string mail = default(string), bool? notify = default(bool?), string internalFax = default(string), DateTime? lastMail = default(DateTime?), string mailBody = default(string), int? maxMailOutSize = default(int?))
        {
            this.Mail = mail;
            this.Notify = notify;
            this.InternalFax = internalFax;
            this.LastMail = lastMail;
            this.MailBody = mailBody;
            this.MaxMailOutSize = maxMailOutSize;
        }
        
        /// <summary>
        /// User e-mail
        /// </summary>
        /// <value>User e-mail</value>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public string Mail { get; set; }

        /// <summary>
        /// Notification of movement via SMTP
        /// </summary>
        /// <value>Notification of movement via SMTP</value>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public bool? Notify { get; set; }

        /// <summary>
        /// Personal Fax
        /// </summary>
        /// <value>Personal Fax</value>
        [DataMember(Name="internalFax", EmitDefaultValue=false)]
        public string InternalFax { get; set; }

        /// <summary>
        /// Date of last reading email
        /// </summary>
        /// <value>Date of last reading email</value>
        [DataMember(Name="lastMail", EmitDefaultValue=false)]
        public DateTime? LastMail { get; set; }

        /// <summary>
        /// Txt Disclamer
        /// </summary>
        /// <value>Txt Disclamer</value>
        [DataMember(Name="mailBody", EmitDefaultValue=false)]
        public string MailBody { get; set; }

        /// <summary>
        /// Mail out max size
        /// </summary>
        /// <value>Mail out max size</value>
        [DataMember(Name="maxMailOutSize", EmitDefaultValue=false)]
        public int? MaxMailOutSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountSettingsGeneralDTO {\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  InternalFax: ").Append(InternalFax).Append("\n");
            sb.Append("  LastMail: ").Append(LastMail).Append("\n");
            sb.Append("  MailBody: ").Append(MailBody).Append("\n");
            sb.Append("  MaxMailOutSize: ").Append(MaxMailOutSize).Append("\n");
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
            return this.Equals(input as MailAccountSettingsGeneralDTO);
        }

        /// <summary>
        /// Returns true if MailAccountSettingsGeneralDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountSettingsGeneralDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountSettingsGeneralDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
                ) && 
                (
                    this.Notify == input.Notify ||
                    (this.Notify != null &&
                    this.Notify.Equals(input.Notify))
                ) && 
                (
                    this.InternalFax == input.InternalFax ||
                    (this.InternalFax != null &&
                    this.InternalFax.Equals(input.InternalFax))
                ) && 
                (
                    this.LastMail == input.LastMail ||
                    (this.LastMail != null &&
                    this.LastMail.Equals(input.LastMail))
                ) && 
                (
                    this.MailBody == input.MailBody ||
                    (this.MailBody != null &&
                    this.MailBody.Equals(input.MailBody))
                ) && 
                (
                    this.MaxMailOutSize == input.MaxMailOutSize ||
                    (this.MaxMailOutSize != null &&
                    this.MaxMailOutSize.Equals(input.MaxMailOutSize))
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
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.Notify != null)
                    hashCode = hashCode * 59 + this.Notify.GetHashCode();
                if (this.InternalFax != null)
                    hashCode = hashCode * 59 + this.InternalFax.GetHashCode();
                if (this.LastMail != null)
                    hashCode = hashCode * 59 + this.LastMail.GetHashCode();
                if (this.MailBody != null)
                    hashCode = hashCode * 59 + this.MailBody.GetHashCode();
                if (this.MaxMailOutSize != null)
                    hashCode = hashCode * 59 + this.MaxMailOutSize.GetHashCode();
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
