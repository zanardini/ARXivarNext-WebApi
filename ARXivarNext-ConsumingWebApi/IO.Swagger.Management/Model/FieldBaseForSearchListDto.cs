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
    /// FieldBaseForSearchListDto
    /// </summary>
    [DataContract]
    public partial class FieldBaseForSearchListDto :  IEquatable<FieldBaseForSearchListDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchListDto" /> class.
        /// </summary>
        /// <param name="_operator">Possible values:  0: Non_Impostato  1: Uguale  2: Diverso  3: Inizia  4: Contiene  5: Termina  6: Nullo  7: Non_Nullo  8: Vuoto  9: Non_Vuoto  10: Nullo_o_Vuoto  11: Non_Nullo_e_Non_Vuoto  12: Like .</param>
        /// <param name="and">Search by and.</param>
        /// <param name="valore1">The value of this field.</param>
        /// <param name="valore2">The second value for this field (used only for some operator).</param>
        public FieldBaseForSearchListDto(int? _operator = default(int?), bool? and = default(bool?), List<string> valore1 = default(List<string>), List<string> valore2 = default(List<string>))
        {
            this.Operator = _operator;
            this.And = and;
            this.Valore1 = valore1;
            this.Valore2 = valore2;
        }
        
        /// <summary>
        /// Possible values:  0: Non_Impostato  1: Uguale  2: Diverso  3: Inizia  4: Contiene  5: Termina  6: Nullo  7: Non_Nullo  8: Vuoto  9: Non_Vuoto  10: Nullo_o_Vuoto  11: Non_Nullo_e_Non_Vuoto  12: Like 
        /// </summary>
        /// <value>Possible values:  0: Non_Impostato  1: Uguale  2: Diverso  3: Inizia  4: Contiene  5: Termina  6: Nullo  7: Non_Nullo  8: Vuoto  9: Non_Vuoto  10: Nullo_o_Vuoto  11: Non_Nullo_e_Non_Vuoto  12: Like </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public int? Operator { get; set; }

        /// <summary>
        /// Search by and
        /// </summary>
        /// <value>Search by and</value>
        [DataMember(Name="and", EmitDefaultValue=false)]
        public bool? And { get; set; }

        /// <summary>
        /// The value of this field
        /// </summary>
        /// <value>The value of this field</value>
        [DataMember(Name="valore1", EmitDefaultValue=false)]
        public List<string> Valore1 { get; set; }

        /// <summary>
        /// The second value for this field (used only for some operator)
        /// </summary>
        /// <value>The second value for this field (used only for some operator)</value>
        [DataMember(Name="valore2", EmitDefaultValue=false)]
        public List<string> Valore2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSearchListDto {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  And: ").Append(And).Append("\n");
            sb.Append("  Valore1: ").Append(Valore1).Append("\n");
            sb.Append("  Valore2: ").Append(Valore2).Append("\n");
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
            return this.Equals(input as FieldBaseForSearchListDto);
        }

        /// <summary>
        /// Returns true if FieldBaseForSearchListDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldBaseForSearchListDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSearchListDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.And == input.And ||
                    (this.And != null &&
                    this.And.Equals(input.And))
                ) && 
                (
                    this.Valore1 == input.Valore1 ||
                    this.Valore1 != null &&
                    this.Valore1.SequenceEqual(input.Valore1)
                ) && 
                (
                    this.Valore2 == input.Valore2 ||
                    this.Valore2 != null &&
                    this.Valore2.SequenceEqual(input.Valore2)
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
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.And != null)
                    hashCode = hashCode * 59 + this.And.GetHashCode();
                if (this.Valore1 != null)
                    hashCode = hashCode * 59 + this.Valore1.GetHashCode();
                if (this.Valore2 != null)
                    hashCode = hashCode * 59 + this.Valore2.GetHashCode();
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
