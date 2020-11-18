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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Class of sql condition
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "className")]
    [JsonSubtypes.KnownSubType(typeof(SqlConditionDateTimeDTO), "SqlConditionDateTimeDTO")]
    [JsonSubtypes.KnownSubType(typeof(SqlConditionIntDTO), "SqlConditionIntDTO")]
    [JsonSubtypes.KnownSubType(typeof(SqlConditionDoubleDTO), "SqlConditionDoubleDTO")]
    [JsonSubtypes.KnownSubType(typeof(SqlConditionStringDTO), "SqlConditionStringDTO")]
    [JsonSubtypes.KnownSubType(typeof(SqlConditionBoolDTO), "SqlConditionBoolDTO")]
    public partial class SqlConditionBaseDTO :  IEquatable<SqlConditionBaseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlConditionBaseDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SqlConditionBaseDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlConditionBaseDTO" /> class.
        /// </summary>
        /// <param name="className">Name of class (required).</param>
        /// <param name="id">Identifier.</param>
        /// <param name="name">Name.</param>
        /// <param name="table">Table.</param>
        /// <param name="field">Field.</param>
        /// <param name="insensitiveSearch">Case insensitive search.</param>
        /// <param name="external1">First External field.</param>
        /// <param name="external1Description">First External field description.</param>
        /// <param name="external2">Second External field.</param>
        /// <param name="external2Description">Second External field description.</param>
        public SqlConditionBaseDTO(string className = default(string), string id = default(string), string name = default(string), string table = default(string), string field = default(string), bool? insensitiveSearch = default(bool?), string external1 = default(string), string external1Description = default(string), string external2 = default(string), string external2Description = default(string))
        {
            // to ensure "className" is required (not null)
            if (className == null)
            {
                throw new InvalidDataException("className is a required property for SqlConditionBaseDTO and cannot be null");
            }
            else
            {
                this.ClassName = className;
            }
            this.Id = id;
            this.Name = name;
            this.Table = table;
            this.Field = field;
            this.InsensitiveSearch = insensitiveSearch;
            this.External1 = external1;
            this.External1Description = external1Description;
            this.External2 = external2;
            this.External2Description = external2Description;
        }
        
        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Table
        /// </summary>
        /// <value>Table</value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public string Table { get; set; }

        /// <summary>
        /// Field
        /// </summary>
        /// <value>Field</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Case insensitive search
        /// </summary>
        /// <value>Case insensitive search</value>
        [DataMember(Name="insensitiveSearch", EmitDefaultValue=false)]
        public bool? InsensitiveSearch { get; set; }

        /// <summary>
        /// First External field
        /// </summary>
        /// <value>First External field</value>
        [DataMember(Name="external1", EmitDefaultValue=false)]
        public string External1 { get; set; }

        /// <summary>
        /// First External field description
        /// </summary>
        /// <value>First External field description</value>
        [DataMember(Name="external1Description", EmitDefaultValue=false)]
        public string External1Description { get; set; }

        /// <summary>
        /// Second External field
        /// </summary>
        /// <value>Second External field</value>
        [DataMember(Name="external2", EmitDefaultValue=false)]
        public string External2 { get; set; }

        /// <summary>
        /// Second External field description
        /// </summary>
        /// <value>Second External field description</value>
        [DataMember(Name="external2Description", EmitDefaultValue=false)]
        public string External2Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlConditionBaseDTO {\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  InsensitiveSearch: ").Append(InsensitiveSearch).Append("\n");
            sb.Append("  External1: ").Append(External1).Append("\n");
            sb.Append("  External1Description: ").Append(External1Description).Append("\n");
            sb.Append("  External2: ").Append(External2).Append("\n");
            sb.Append("  External2Description: ").Append(External2Description).Append("\n");
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
            return this.Equals(input as SqlConditionBaseDTO);
        }

        /// <summary>
        /// Returns true if SqlConditionBaseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SqlConditionBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SqlConditionBaseDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && 
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
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.InsensitiveSearch == input.InsensitiveSearch ||
                    (this.InsensitiveSearch != null &&
                    this.InsensitiveSearch.Equals(input.InsensitiveSearch))
                ) && 
                (
                    this.External1 == input.External1 ||
                    (this.External1 != null &&
                    this.External1.Equals(input.External1))
                ) && 
                (
                    this.External1Description == input.External1Description ||
                    (this.External1Description != null &&
                    this.External1Description.Equals(input.External1Description))
                ) && 
                (
                    this.External2 == input.External2 ||
                    (this.External2 != null &&
                    this.External2.Equals(input.External2))
                ) && 
                (
                    this.External2Description == input.External2Description ||
                    (this.External2Description != null &&
                    this.External2Description.Equals(input.External2Description))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.InsensitiveSearch != null)
                    hashCode = hashCode * 59 + this.InsensitiveSearch.GetHashCode();
                if (this.External1 != null)
                    hashCode = hashCode * 59 + this.External1.GetHashCode();
                if (this.External1Description != null)
                    hashCode = hashCode * 59 + this.External1Description.GetHashCode();
                if (this.External2 != null)
                    hashCode = hashCode * 59 + this.External2.GetHashCode();
                if (this.External2Description != null)
                    hashCode = hashCode * 59 + this.External2Description.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
