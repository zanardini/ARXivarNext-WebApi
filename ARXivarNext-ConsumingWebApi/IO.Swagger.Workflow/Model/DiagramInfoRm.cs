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
    /// Describes the diagram base information
    /// </summary>
    [DataContract]
        public partial class DiagramInfoRm :  IEquatable<DiagramInfoRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramInfoRm" /> class.
        /// </summary>
        /// <param name="id">Diagram identifier.</param>
        /// <param name="parentId">Reference at the first revision of the diagram.</param>
        /// <param name="revision">Index revision of the diagram.</param>
        /// <param name="priority">Priority of the diagram.</param>
        /// <param name="name">Diagram name.</param>
        /// <param name="diagramGroupId">Group identifier.</param>
        /// <param name="status">This enumerative indicates the state of the diagram [0&#x3D;Deleted, 1&#x3D;Online, 2&#x3D;Edit, 3&#x3D;WaitForApprove, 4&#x3D;Offline, 5&#x3D;Revisioned, 6&#x3D;Instance].</param>
        /// <param name="creationDateUtc">The creation date of the diagram.</param>
        /// <param name="calendarInfo">calendarInfo.</param>
        public DiagramInfoRm(Guid? id = default(Guid?), Guid? parentId = default(Guid?), int? revision = default(int?), int? priority = default(int?), string name = default(string), Guid? diagramGroupId = default(Guid?), int? status = default(int?), DateTime? creationDateUtc = default(DateTime?), CalendarInfoRm calendarInfo = default(CalendarInfoRm))
        {
            this.Id = id;
            this.ParentId = parentId;
            this.Revision = revision;
            this.Priority = priority;
            this.Name = name;
            this.DiagramGroupId = diagramGroupId;
            this.Status = status;
            this.CreationDateUtc = creationDateUtc;
            this.CalendarInfo = calendarInfo;
        }
        
        /// <summary>
        /// Diagram identifier
        /// </summary>
        /// <value>Diagram identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Reference at the first revision of the diagram
        /// </summary>
        /// <value>Reference at the first revision of the diagram</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Index revision of the diagram
        /// </summary>
        /// <value>Index revision of the diagram</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Priority of the diagram
        /// </summary>
        /// <value>Priority of the diagram</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Diagram name
        /// </summary>
        /// <value>Diagram name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Group identifier
        /// </summary>
        /// <value>Group identifier</value>
        [DataMember(Name="diagramGroupId", EmitDefaultValue=false)]
        public Guid? DiagramGroupId { get; set; }

        /// <summary>
        /// This enumerative indicates the state of the diagram [0&#x3D;Deleted, 1&#x3D;Online, 2&#x3D;Edit, 3&#x3D;WaitForApprove, 4&#x3D;Offline, 5&#x3D;Revisioned, 6&#x3D;Instance]
        /// </summary>
        /// <value>This enumerative indicates the state of the diagram [0&#x3D;Deleted, 1&#x3D;Online, 2&#x3D;Edit, 3&#x3D;WaitForApprove, 4&#x3D;Offline, 5&#x3D;Revisioned, 6&#x3D;Instance]</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The creation date of the diagram
        /// </summary>
        /// <value>The creation date of the diagram</value>
        [DataMember(Name="creationDateUtc", EmitDefaultValue=false)]
        public DateTime? CreationDateUtc { get; set; }

        /// <summary>
        /// Gets or Sets CalendarInfo
        /// </summary>
        [DataMember(Name="calendarInfo", EmitDefaultValue=false)]
        public CalendarInfoRm CalendarInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramInfoRm {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DiagramGroupId: ").Append(DiagramGroupId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationDateUtc: ").Append(CreationDateUtc).Append("\n");
            sb.Append("  CalendarInfo: ").Append(CalendarInfo).Append("\n");
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
            return this.Equals(input as DiagramInfoRm);
        }

        /// <summary>
        /// Returns true if DiagramInfoRm instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagramInfoRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagramInfoRm input)
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
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DiagramGroupId == input.DiagramGroupId ||
                    (this.DiagramGroupId != null &&
                    this.DiagramGroupId.Equals(input.DiagramGroupId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreationDateUtc == input.CreationDateUtc ||
                    (this.CreationDateUtc != null &&
                    this.CreationDateUtc.Equals(input.CreationDateUtc))
                ) && 
                (
                    this.CalendarInfo == input.CalendarInfo ||
                    (this.CalendarInfo != null &&
                    this.CalendarInfo.Equals(input.CalendarInfo))
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
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DiagramGroupId != null)
                    hashCode = hashCode * 59 + this.DiagramGroupId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreationDateUtc != null)
                    hashCode = hashCode * 59 + this.CreationDateUtc.GetHashCode();
                if (this.CalendarInfo != null)
                    hashCode = hashCode * 59 + this.CalendarInfo.GetHashCode();
                return hashCode;
            }
        }

    }
}