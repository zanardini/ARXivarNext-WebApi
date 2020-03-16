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
    /// Class of task layout
    /// </summary>
    [DataContract]
    public partial class TaskLayoutDTO :  IEquatable<TaskLayoutDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLayoutDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="author">Author Identifier.</param>
        /// <param name="authorCompleteName">Author Name.</param>
        /// <param name="creationDate">Creation Date.</param>
        /// <param name="details">Details.</param>
        /// <param name="associations">Association Fields.</param>
        /// <param name="users">Users.</param>
        /// <param name="isSystem">Task Layout is of system.</param>
        /// <param name="priority">Priority.</param>
        /// <param name="idLayout">Layout Identifier.</param>
        /// <param name="isUser">Task Layout is user layout.</param>
        public TaskLayoutDTO(int? id = default(int?), string name = default(string), int? author = default(int?), string authorCompleteName = default(string), DateTime? creationDate = default(DateTime?), List<TaskLayoutDetailDTO> details = default(List<TaskLayoutDetailDTO>), List<TaskLayoutAssociationDTO> associations = default(List<TaskLayoutAssociationDTO>), List<UserDTO> users = default(List<UserDTO>), bool? isSystem = default(bool?), int? priority = default(int?), int? idLayout = default(int?), bool? isUser = default(bool?))
        {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            this.AuthorCompleteName = authorCompleteName;
            this.CreationDate = creationDate;
            this.Details = details;
            this.Associations = associations;
            this.Users = users;
            this.IsSystem = isSystem;
            this.Priority = priority;
            this.IdLayout = idLayout;
            this.IsUser = isUser;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Author Identifier
        /// </summary>
        /// <value>Author Identifier</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public int? Author { get; set; }

        /// <summary>
        /// Author Name
        /// </summary>
        /// <value>Author Name</value>
        [DataMember(Name="authorCompleteName", EmitDefaultValue=false)]
        public string AuthorCompleteName { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<TaskLayoutDetailDTO> Details { get; set; }

        /// <summary>
        /// Association Fields
        /// </summary>
        /// <value>Association Fields</value>
        [DataMember(Name="associations", EmitDefaultValue=false)]
        public List<TaskLayoutAssociationDTO> Associations { get; set; }

        /// <summary>
        /// Users
        /// </summary>
        /// <value>Users</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserDTO> Users { get; set; }

        /// <summary>
        /// Task Layout is of system
        /// </summary>
        /// <value>Task Layout is of system</value>
        [DataMember(Name="isSystem", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Priority
        /// </summary>
        /// <value>Priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Layout Identifier
        /// </summary>
        /// <value>Layout Identifier</value>
        [DataMember(Name="idLayout", EmitDefaultValue=false)]
        public int? IdLayout { get; set; }

        /// <summary>
        /// Task Layout is user layout
        /// </summary>
        /// <value>Task Layout is user layout</value>
        [DataMember(Name="isUser", EmitDefaultValue=false)]
        public bool? IsUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLayoutDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  AuthorCompleteName: ").Append(AuthorCompleteName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  IdLayout: ").Append(IdLayout).Append("\n");
            sb.Append("  IsUser: ").Append(IsUser).Append("\n");
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
            return this.Equals(input as TaskLayoutDTO);
        }

        /// <summary>
        /// Returns true if TaskLayoutDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskLayoutDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskLayoutDTO input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.AuthorCompleteName == input.AuthorCompleteName ||
                    (this.AuthorCompleteName != null &&
                    this.AuthorCompleteName.Equals(input.AuthorCompleteName))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Associations == input.Associations ||
                    this.Associations != null &&
                    this.Associations.SequenceEqual(input.Associations)
                ) && 
                (
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.IdLayout == input.IdLayout ||
                    (this.IdLayout != null &&
                    this.IdLayout.Equals(input.IdLayout))
                ) && 
                (
                    this.IsUser == input.IsUser ||
                    (this.IsUser != null &&
                    this.IsUser.Equals(input.IsUser))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.AuthorCompleteName != null)
                    hashCode = hashCode * 59 + this.AuthorCompleteName.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Associations != null)
                    hashCode = hashCode * 59 + this.Associations.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.IdLayout != null)
                    hashCode = hashCode * 59 + this.IdLayout.GetHashCode();
                if (this.IsUser != null)
                    hashCode = hashCode * 59 + this.IsUser.GetHashCode();
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
