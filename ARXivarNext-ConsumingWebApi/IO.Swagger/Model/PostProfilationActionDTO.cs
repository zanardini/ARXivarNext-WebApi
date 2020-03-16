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
    /// Class of a action in post profilation
    /// </summary>
    [DataContract]
    public partial class PostProfilationActionDTO :  IEquatable<PostProfilationActionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostProfilationActionDTO" /> class.
        /// </summary>
        /// <param name="shortDescription">Short description.</param>
        /// <param name="description">Description.</param>
        /// <param name="action">Possible values:  15: StartWorkFlow  16: SendViaFax  17: SendViaMail  18: AttachToActiveWorkflow  19: InsertInAssociation  20: InsertInFolder  21: InsertInManualRelation  29: SetPermissions  31: AttachMemo  33: StartCollaboration  34: ImmediatlyScan .</param>
        /// <param name="visible">Visible.</param>
        /// <param name="value">Active.</param>
        public PostProfilationActionDTO(string shortDescription = default(string), string description = default(string), int? action = default(int?), bool? visible = default(bool?), bool? value = default(bool?))
        {
            this.ShortDescription = shortDescription;
            this.Description = description;
            this.Action = action;
            this.Visible = visible;
            this.Value = value;
        }
        
        /// <summary>
        /// Short description
        /// </summary>
        /// <value>Short description</value>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Possible values:  15: StartWorkFlow  16: SendViaFax  17: SendViaMail  18: AttachToActiveWorkflow  19: InsertInAssociation  20: InsertInFolder  21: InsertInManualRelation  29: SetPermissions  31: AttachMemo  33: StartCollaboration  34: ImmediatlyScan 
        /// </summary>
        /// <value>Possible values:  15: StartWorkFlow  16: SendViaFax  17: SendViaMail  18: AttachToActiveWorkflow  19: InsertInAssociation  20: InsertInFolder  21: InsertInManualRelation  29: SetPermissions  31: AttachMemo  33: StartCollaboration  34: ImmediatlyScan </value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public int? Action { get; set; }

        /// <summary>
        /// Visible
        /// </summary>
        /// <value>Visible</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        /// <value>Active</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public bool? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostProfilationActionDTO {\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as PostProfilationActionDTO);
        }

        /// <summary>
        /// Returns true if PostProfilationActionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PostProfilationActionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostProfilationActionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
                ) && 
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
                int hashCode = 41;
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
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
            yield break;
        }
    }

}
