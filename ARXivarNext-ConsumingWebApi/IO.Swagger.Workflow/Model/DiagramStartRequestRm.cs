/* 
 * ARXivar Workflow API
 *
 * ARXivar Workflow API
 *
 * OpenAPI spec version: v1
 * Contact: info@abletech.it
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
using SwaggerDateConverter = IO.Swagger.Workflow.Client.SwaggerDateConverter;

namespace IO.Swagger.Workflow.Model
{
    /// <summary>
    /// Diagram start request model
    /// </summary>
    [DataContract]
        public partial class DiagramStartRequestRm :  IEquatable<DiagramStartRequestRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramStartRequestRm" /> class.
        /// </summary>
        /// <param name="id">Diagram start identifier.</param>
        /// <param name="externalData">External data list.</param>
        /// <param name="documentData">Document list.</param>
        /// <param name="notes">Notes list.</param>
        public DiagramStartRequestRm(Guid? id = default(Guid?), List<ProcessExternalParameterRm> externalData = default(List<ProcessExternalParameterRm>), List<ProcessDocumentParameterRm> documentData = default(List<ProcessDocumentParameterRm>), List<string> notes = default(List<string>))
        {
            this.Id = id;
            this.ExternalData = externalData;
            this.DocumentData = documentData;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Diagram start identifier
        /// </summary>
        /// <value>Diagram start identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// External data list
        /// </summary>
        /// <value>External data list</value>
        [DataMember(Name="externalData", EmitDefaultValue=false)]
        public List<ProcessExternalParameterRm> ExternalData { get; set; }

        /// <summary>
        /// Document list
        /// </summary>
        /// <value>Document list</value>
        [DataMember(Name="documentData", EmitDefaultValue=false)]
        public List<ProcessDocumentParameterRm> DocumentData { get; set; }

        /// <summary>
        /// Notes list
        /// </summary>
        /// <value>Notes list</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<string> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramStartRequestRm {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalData: ").Append(ExternalData).Append("\n");
            sb.Append("  DocumentData: ").Append(DocumentData).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as DiagramStartRequestRm);
        }

        /// <summary>
        /// Returns true if DiagramStartRequestRm instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagramStartRequestRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagramStartRequestRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalData == input.ExternalData ||
                    this.ExternalData != null &&
                    input.ExternalData != null &&
                    this.ExternalData.SequenceEqual(input.ExternalData)
                ) && 
                (
                    this.DocumentData == input.DocumentData ||
                    this.DocumentData != null &&
                    input.DocumentData != null &&
                    this.DocumentData.SequenceEqual(input.DocumentData)
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalData != null)
                    hashCode = hashCode * 59 + this.ExternalData.GetHashCode();
                if (this.DocumentData != null)
                    hashCode = hashCode * 59 + this.DocumentData.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                return hashCode;
            }
        }

    }
}
