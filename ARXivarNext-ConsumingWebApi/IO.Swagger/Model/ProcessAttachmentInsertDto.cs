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
    /// Class of insert a process attachment
    /// </summary>
    [DataContract]
    public partial class ProcessAttachmentInsertDto :  IEquatable<ProcessAttachmentInsertDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessAttachmentInsertDto" /> class.
        /// </summary>
        /// <param name="taskworkId">Taskwork Identifier.</param>
        /// <param name="docnumber">Document Identifier.</param>
        /// <param name="toSend">Set the attachment \&quot;tosend\&quot; flag.</param>
        /// <param name="link">Create a link.</param>
        public ProcessAttachmentInsertDto(int? taskworkId = default(int?), int? docnumber = default(int?), bool? toSend = default(bool?), bool? link = default(bool?))
        {
            this.TaskworkId = taskworkId;
            this.Docnumber = docnumber;
            this.ToSend = toSend;
            this.Link = link;
        }
        
        /// <summary>
        /// Taskwork Identifier
        /// </summary>
        /// <value>Taskwork Identifier</value>
        [DataMember(Name="taskworkId", EmitDefaultValue=false)]
        public int? TaskworkId { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Set the attachment \&quot;tosend\&quot; flag
        /// </summary>
        /// <value>Set the attachment \&quot;tosend\&quot; flag</value>
        [DataMember(Name="toSend", EmitDefaultValue=false)]
        public bool? ToSend { get; set; }

        /// <summary>
        /// Create a link
        /// </summary>
        /// <value>Create a link</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public bool? Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessAttachmentInsertDto {\n");
            sb.Append("  TaskworkId: ").Append(TaskworkId).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  ToSend: ").Append(ToSend).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as ProcessAttachmentInsertDto);
        }

        /// <summary>
        /// Returns true if ProcessAttachmentInsertDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessAttachmentInsertDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessAttachmentInsertDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskworkId == input.TaskworkId ||
                    (this.TaskworkId != null &&
                    this.TaskworkId.Equals(input.TaskworkId))
                ) && 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.ToSend == input.ToSend ||
                    (this.ToSend != null &&
                    this.ToSend.Equals(input.ToSend))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.TaskworkId != null)
                    hashCode = hashCode * 59 + this.TaskworkId.GetHashCode();
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.ToSend != null)
                    hashCode = hashCode * 59 + this.ToSend.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
