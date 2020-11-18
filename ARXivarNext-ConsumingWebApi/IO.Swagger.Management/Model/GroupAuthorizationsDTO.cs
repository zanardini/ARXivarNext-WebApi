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
    /// Class for Group Authorizations
    /// </summary>
    [DataContract]
    public partial class GroupAuthorizationsDTO :  IEquatable<GroupAuthorizationsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupAuthorizationsDTO" /> class.
        /// </summary>
        /// <param name="active">Enable user.</param>
        /// <param name="protocol">Enabled to Public Amministration (PA) Protocol.</param>
        /// <param name="workflow">Enabled to Workflow.</param>
        /// <param name="sign">Enabled to Sign.</param>
        /// <param name="flow">Enabling Workflow Management.</param>
        /// <param name="distributionList">Abilitazione alla manutenzione delle liste di distribuzione.</param>
        /// <param name="mailDeleteProfile">Abilitazione alla cancellazione del profilo se associato alle mail.</param>
        /// <param name="addressBookProfile">Abilitazione all&#39;inserimento immediato in rubrica durante la profilazione, nel caso non esista il contatto..</param>
        /// <param name="businessUnitUserUnlock">Comportamento dell&#39;utente nel caso di impianto ad \&quot;aoo\&quot; bloccate.</param>
        /// <param name="barcodeAccess">Enabled to Barcode.</param>
        /// <param name="canAddVirtualStamps">Possible values:  0: NotApplied  1: Allow  2: Denied .</param>
        /// <param name="canApplyStaps">Possible values:  0: NotApplied  1: Allow  2: Denied .</param>
        public GroupAuthorizationsDTO(bool? active = default(bool?), bool? protocol = default(bool?), bool? workflow = default(bool?), bool? sign = default(bool?), bool? flow = default(bool?), bool? distributionList = default(bool?), bool? mailDeleteProfile = default(bool?), bool? addressBookProfile = default(bool?), bool? businessUnitUserUnlock = default(bool?), bool? barcodeAccess = default(bool?), int? canAddVirtualStamps = default(int?), int? canApplyStaps = default(int?))
        {
            this.Active = active;
            this.Protocol = protocol;
            this.Workflow = workflow;
            this.Sign = sign;
            this.Flow = flow;
            this.DistributionList = distributionList;
            this.MailDeleteProfile = mailDeleteProfile;
            this.AddressBookProfile = addressBookProfile;
            this.BusinessUnitUserUnlock = businessUnitUserUnlock;
            this.BarcodeAccess = barcodeAccess;
            this.CanAddVirtualStamps = canAddVirtualStamps;
            this.CanApplyStaps = canApplyStaps;
        }
        
        /// <summary>
        /// Enable user
        /// </summary>
        /// <value>Enable user</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Enabled to Public Amministration (PA) Protocol
        /// </summary>
        /// <value>Enabled to Public Amministration (PA) Protocol</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public bool? Protocol { get; set; }

        /// <summary>
        /// Enabled to Workflow
        /// </summary>
        /// <value>Enabled to Workflow</value>
        [DataMember(Name="workflow", EmitDefaultValue=false)]
        public bool? Workflow { get; set; }

        /// <summary>
        /// Enabled to Sign
        /// </summary>
        /// <value>Enabled to Sign</value>
        [DataMember(Name="sign", EmitDefaultValue=false)]
        public bool? Sign { get; set; }

        /// <summary>
        /// Enabling Workflow Management
        /// </summary>
        /// <value>Enabling Workflow Management</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public bool? Flow { get; set; }

        /// <summary>
        /// Abilitazione alla manutenzione delle liste di distribuzione
        /// </summary>
        /// <value>Abilitazione alla manutenzione delle liste di distribuzione</value>
        [DataMember(Name="distributionList", EmitDefaultValue=false)]
        public bool? DistributionList { get; set; }

        /// <summary>
        /// Abilitazione alla cancellazione del profilo se associato alle mail
        /// </summary>
        /// <value>Abilitazione alla cancellazione del profilo se associato alle mail</value>
        [DataMember(Name="mailDeleteProfile", EmitDefaultValue=false)]
        public bool? MailDeleteProfile { get; set; }

        /// <summary>
        /// Abilitazione all&#39;inserimento immediato in rubrica durante la profilazione, nel caso non esista il contatto.
        /// </summary>
        /// <value>Abilitazione all&#39;inserimento immediato in rubrica durante la profilazione, nel caso non esista il contatto.</value>
        [DataMember(Name="addressBookProfile", EmitDefaultValue=false)]
        public bool? AddressBookProfile { get; set; }

        /// <summary>
        /// Comportamento dell&#39;utente nel caso di impianto ad \&quot;aoo\&quot; bloccate
        /// </summary>
        /// <value>Comportamento dell&#39;utente nel caso di impianto ad \&quot;aoo\&quot; bloccate</value>
        [DataMember(Name="businessUnitUserUnlock", EmitDefaultValue=false)]
        public bool? BusinessUnitUserUnlock { get; set; }

        /// <summary>
        /// Enabled to Barcode
        /// </summary>
        /// <value>Enabled to Barcode</value>
        [DataMember(Name="barcodeAccess", EmitDefaultValue=false)]
        public bool? BarcodeAccess { get; set; }

        /// <summary>
        /// Possible values:  0: NotApplied  1: Allow  2: Denied 
        /// </summary>
        /// <value>Possible values:  0: NotApplied  1: Allow  2: Denied </value>
        [DataMember(Name="canAddVirtualStamps", EmitDefaultValue=false)]
        public int? CanAddVirtualStamps { get; set; }

        /// <summary>
        /// Possible values:  0: NotApplied  1: Allow  2: Denied 
        /// </summary>
        /// <value>Possible values:  0: NotApplied  1: Allow  2: Denied </value>
        [DataMember(Name="canApplyStaps", EmitDefaultValue=false)]
        public int? CanApplyStaps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupAuthorizationsDTO {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Workflow: ").Append(Workflow).Append("\n");
            sb.Append("  Sign: ").Append(Sign).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  DistributionList: ").Append(DistributionList).Append("\n");
            sb.Append("  MailDeleteProfile: ").Append(MailDeleteProfile).Append("\n");
            sb.Append("  AddressBookProfile: ").Append(AddressBookProfile).Append("\n");
            sb.Append("  BusinessUnitUserUnlock: ").Append(BusinessUnitUserUnlock).Append("\n");
            sb.Append("  BarcodeAccess: ").Append(BarcodeAccess).Append("\n");
            sb.Append("  CanAddVirtualStamps: ").Append(CanAddVirtualStamps).Append("\n");
            sb.Append("  CanApplyStaps: ").Append(CanApplyStaps).Append("\n");
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
            return this.Equals(input as GroupAuthorizationsDTO);
        }

        /// <summary>
        /// Returns true if GroupAuthorizationsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupAuthorizationsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupAuthorizationsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Workflow == input.Workflow ||
                    (this.Workflow != null &&
                    this.Workflow.Equals(input.Workflow))
                ) && 
                (
                    this.Sign == input.Sign ||
                    (this.Sign != null &&
                    this.Sign.Equals(input.Sign))
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.DistributionList == input.DistributionList ||
                    (this.DistributionList != null &&
                    this.DistributionList.Equals(input.DistributionList))
                ) && 
                (
                    this.MailDeleteProfile == input.MailDeleteProfile ||
                    (this.MailDeleteProfile != null &&
                    this.MailDeleteProfile.Equals(input.MailDeleteProfile))
                ) && 
                (
                    this.AddressBookProfile == input.AddressBookProfile ||
                    (this.AddressBookProfile != null &&
                    this.AddressBookProfile.Equals(input.AddressBookProfile))
                ) && 
                (
                    this.BusinessUnitUserUnlock == input.BusinessUnitUserUnlock ||
                    (this.BusinessUnitUserUnlock != null &&
                    this.BusinessUnitUserUnlock.Equals(input.BusinessUnitUserUnlock))
                ) && 
                (
                    this.BarcodeAccess == input.BarcodeAccess ||
                    (this.BarcodeAccess != null &&
                    this.BarcodeAccess.Equals(input.BarcodeAccess))
                ) && 
                (
                    this.CanAddVirtualStamps == input.CanAddVirtualStamps ||
                    (this.CanAddVirtualStamps != null &&
                    this.CanAddVirtualStamps.Equals(input.CanAddVirtualStamps))
                ) && 
                (
                    this.CanApplyStaps == input.CanApplyStaps ||
                    (this.CanApplyStaps != null &&
                    this.CanApplyStaps.Equals(input.CanApplyStaps))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Workflow != null)
                    hashCode = hashCode * 59 + this.Workflow.GetHashCode();
                if (this.Sign != null)
                    hashCode = hashCode * 59 + this.Sign.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.DistributionList != null)
                    hashCode = hashCode * 59 + this.DistributionList.GetHashCode();
                if (this.MailDeleteProfile != null)
                    hashCode = hashCode * 59 + this.MailDeleteProfile.GetHashCode();
                if (this.AddressBookProfile != null)
                    hashCode = hashCode * 59 + this.AddressBookProfile.GetHashCode();
                if (this.BusinessUnitUserUnlock != null)
                    hashCode = hashCode * 59 + this.BusinessUnitUserUnlock.GetHashCode();
                if (this.BarcodeAccess != null)
                    hashCode = hashCode * 59 + this.BarcodeAccess.GetHashCode();
                if (this.CanAddVirtualStamps != null)
                    hashCode = hashCode * 59 + this.CanAddVirtualStamps.GetHashCode();
                if (this.CanApplyStaps != null)
                    hashCode = hashCode * 59 + this.CanApplyStaps.GetHashCode();
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
