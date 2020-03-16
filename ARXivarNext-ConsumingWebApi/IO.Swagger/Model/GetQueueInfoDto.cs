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
    /// Class of queue information
    /// </summary>
    [DataContract]
    public partial class GetQueueInfoDto :  IEquatable<GetQueueInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueueInfoDto" /> class.
        /// </summary>
        /// <param name="dateFrom">Start Date.</param>
        /// <param name="typeFullName">Type Name.</param>
        /// <param name="startItem">Start Item.</param>
        /// <param name="count">Count.</param>
        public GetQueueInfoDto(DateTime? dateFrom = default(DateTime?), string typeFullName = default(string), int? startItem = default(int?), int? count = default(int?))
        {
            this.DateFrom = dateFrom;
            this.TypeFullName = typeFullName;
            this.StartItem = startItem;
            this.Count = count;
        }
        
        /// <summary>
        /// Start Date
        /// </summary>
        /// <value>Start Date</value>
        [DataMember(Name="dateFrom", EmitDefaultValue=false)]
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Type Name
        /// </summary>
        /// <value>Type Name</value>
        [DataMember(Name="typeFullName", EmitDefaultValue=false)]
        public string TypeFullName { get; set; }

        /// <summary>
        /// Start Item
        /// </summary>
        /// <value>Start Item</value>
        [DataMember(Name="startItem", EmitDefaultValue=false)]
        public int? StartItem { get; set; }

        /// <summary>
        /// Count
        /// </summary>
        /// <value>Count</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetQueueInfoDto {\n");
            sb.Append("  DateFrom: ").Append(DateFrom).Append("\n");
            sb.Append("  TypeFullName: ").Append(TypeFullName).Append("\n");
            sb.Append("  StartItem: ").Append(StartItem).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as GetQueueInfoDto);
        }

        /// <summary>
        /// Returns true if GetQueueInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of GetQueueInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetQueueInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateFrom == input.DateFrom ||
                    (this.DateFrom != null &&
                    this.DateFrom.Equals(input.DateFrom))
                ) && 
                (
                    this.TypeFullName == input.TypeFullName ||
                    (this.TypeFullName != null &&
                    this.TypeFullName.Equals(input.TypeFullName))
                ) && 
                (
                    this.StartItem == input.StartItem ||
                    (this.StartItem != null &&
                    this.StartItem.Equals(input.StartItem))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.DateFrom != null)
                    hashCode = hashCode * 59 + this.DateFrom.GetHashCode();
                if (this.TypeFullName != null)
                    hashCode = hashCode * 59 + this.TypeFullName.GetHashCode();
                if (this.StartItem != null)
                    hashCode = hashCode * 59 + this.StartItem.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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
