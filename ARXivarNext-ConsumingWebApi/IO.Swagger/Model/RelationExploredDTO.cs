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
    /// RelationExploredDTO
    /// </summary>
    [DataContract]
    public partial class RelationExploredDTO :  IEquatable<RelationExploredDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationExploredDTO" /> class.
        /// </summary>
        /// <param name="rootNode">Root node.</param>
        /// <param name="composedValues">Entire datasource of contained profiles.</param>
        public RelationExploredDTO(RelationNodeDTO rootNode = default(RelationNodeDTO), List<RowSearchResult> composedValues = default(List<RowSearchResult>))
        {
            this.RootNode = rootNode;
            this.ComposedValues = composedValues;
        }
        
        /// <summary>
        /// Root node
        /// </summary>
        /// <value>Root node</value>
        [DataMember(Name="rootNode", EmitDefaultValue=false)]
        public RelationNodeDTO RootNode { get; set; }

        /// <summary>
        /// Entire datasource of contained profiles
        /// </summary>
        /// <value>Entire datasource of contained profiles</value>
        [DataMember(Name="composedValues", EmitDefaultValue=false)]
        public List<RowSearchResult> ComposedValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationExploredDTO {\n");
            sb.Append("  RootNode: ").Append(RootNode).Append("\n");
            sb.Append("  ComposedValues: ").Append(ComposedValues).Append("\n");
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
            return this.Equals(input as RelationExploredDTO);
        }

        /// <summary>
        /// Returns true if RelationExploredDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationExploredDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationExploredDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootNode == input.RootNode ||
                    (this.RootNode != null &&
                    this.RootNode.Equals(input.RootNode))
                ) && 
                (
                    this.ComposedValues == input.ComposedValues ||
                    this.ComposedValues != null &&
                    this.ComposedValues.SequenceEqual(input.ComposedValues)
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
                if (this.RootNode != null)
                    hashCode = hashCode * 59 + this.RootNode.GetHashCode();
                if (this.ComposedValues != null)
                    hashCode = hashCode * 59 + this.ComposedValues.GetHashCode();
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