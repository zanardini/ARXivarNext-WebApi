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
    /// ARXivar document information
    /// </summary>
    [DataContract]
        public partial class ARXivarDocumentInfoRm :  IEquatable<ARXivarDocumentInfoRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ARXivarDocumentInfoRm" /> class.
        /// </summary>
        /// <param name="docnumber">ARXivar document identifier.</param>
        /// <param name="revision">Document revision.</param>
        public ARXivarDocumentInfoRm(int? docnumber = default(int?), int? revision = default(int?))
        {
            this.Docnumber = docnumber;
            this.Revision = revision;
        }
        
        /// <summary>
        /// ARXivar document identifier
        /// </summary>
        /// <value>ARXivar document identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Document revision
        /// </summary>
        /// <value>Document revision</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ARXivarDocumentInfoRm {\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
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
            return this.Equals(input as ARXivarDocumentInfoRm);
        }

        /// <summary>
        /// Returns true if ARXivarDocumentInfoRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ARXivarDocumentInfoRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ARXivarDocumentInfoRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                return hashCode;
            }
        }

    }
}
