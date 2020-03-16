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
    /// Class of options associated with a profiling mask.
    /// </summary>
    [DataContract]
    public partial class ProfileMaskOptionsDTO :  IEquatable<ProfileMaskOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileMaskOptionsDTO" /> class.
        /// </summary>
        /// <param name="showNotes">Show notes.</param>
        /// <param name="showAttachments">Show attachments.</param>
        /// <param name="showFileSelection">Show file selection.</param>
        /// <param name="showScannerSelection">Show scanner selection.</param>
        /// <param name="showBarcodeSelection">Show barcode selection.</param>
        public ProfileMaskOptionsDTO(bool? showNotes = default(bool?), bool? showAttachments = default(bool?), bool? showFileSelection = default(bool?), bool? showScannerSelection = default(bool?), bool? showBarcodeSelection = default(bool?))
        {
            this.ShowNotes = showNotes;
            this.ShowAttachments = showAttachments;
            this.ShowFileSelection = showFileSelection;
            this.ShowScannerSelection = showScannerSelection;
            this.ShowBarcodeSelection = showBarcodeSelection;
        }
        
        /// <summary>
        /// Show notes
        /// </summary>
        /// <value>Show notes</value>
        [DataMember(Name="showNotes", EmitDefaultValue=false)]
        public bool? ShowNotes { get; set; }

        /// <summary>
        /// Show attachments
        /// </summary>
        /// <value>Show attachments</value>
        [DataMember(Name="showAttachments", EmitDefaultValue=false)]
        public bool? ShowAttachments { get; set; }

        /// <summary>
        /// Show file selection
        /// </summary>
        /// <value>Show file selection</value>
        [DataMember(Name="showFileSelection", EmitDefaultValue=false)]
        public bool? ShowFileSelection { get; set; }

        /// <summary>
        /// Show scanner selection
        /// </summary>
        /// <value>Show scanner selection</value>
        [DataMember(Name="showScannerSelection", EmitDefaultValue=false)]
        public bool? ShowScannerSelection { get; set; }

        /// <summary>
        /// Show barcode selection
        /// </summary>
        /// <value>Show barcode selection</value>
        [DataMember(Name="showBarcodeSelection", EmitDefaultValue=false)]
        public bool? ShowBarcodeSelection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileMaskOptionsDTO {\n");
            sb.Append("  ShowNotes: ").Append(ShowNotes).Append("\n");
            sb.Append("  ShowAttachments: ").Append(ShowAttachments).Append("\n");
            sb.Append("  ShowFileSelection: ").Append(ShowFileSelection).Append("\n");
            sb.Append("  ShowScannerSelection: ").Append(ShowScannerSelection).Append("\n");
            sb.Append("  ShowBarcodeSelection: ").Append(ShowBarcodeSelection).Append("\n");
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
            return this.Equals(input as ProfileMaskOptionsDTO);
        }

        /// <summary>
        /// Returns true if ProfileMaskOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileMaskOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileMaskOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShowNotes == input.ShowNotes ||
                    (this.ShowNotes != null &&
                    this.ShowNotes.Equals(input.ShowNotes))
                ) && 
                (
                    this.ShowAttachments == input.ShowAttachments ||
                    (this.ShowAttachments != null &&
                    this.ShowAttachments.Equals(input.ShowAttachments))
                ) && 
                (
                    this.ShowFileSelection == input.ShowFileSelection ||
                    (this.ShowFileSelection != null &&
                    this.ShowFileSelection.Equals(input.ShowFileSelection))
                ) && 
                (
                    this.ShowScannerSelection == input.ShowScannerSelection ||
                    (this.ShowScannerSelection != null &&
                    this.ShowScannerSelection.Equals(input.ShowScannerSelection))
                ) && 
                (
                    this.ShowBarcodeSelection == input.ShowBarcodeSelection ||
                    (this.ShowBarcodeSelection != null &&
                    this.ShowBarcodeSelection.Equals(input.ShowBarcodeSelection))
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
                if (this.ShowNotes != null)
                    hashCode = hashCode * 59 + this.ShowNotes.GetHashCode();
                if (this.ShowAttachments != null)
                    hashCode = hashCode * 59 + this.ShowAttachments.GetHashCode();
                if (this.ShowFileSelection != null)
                    hashCode = hashCode * 59 + this.ShowFileSelection.GetHashCode();
                if (this.ShowScannerSelection != null)
                    hashCode = hashCode * 59 + this.ShowScannerSelection.GetHashCode();
                if (this.ShowBarcodeSelection != null)
                    hashCode = hashCode * 59 + this.ShowBarcodeSelection.GetHashCode();
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