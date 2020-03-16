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
    /// ServerLicense
    /// </summary>
    [DataContract]
    public partial class ServerLicense :  IEquatable<ServerLicense>, IValidatableObject
    {
        /// <summary>
        /// Defines Purpose
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PurposeEnum
        {
            
            /// <summary>
            /// Enum RivenditoreUsoInterno for value: RivenditoreUsoInterno
            /// </summary>
            [EnumMember(Value = "RivenditoreUsoInterno")]
            RivenditoreUsoInterno = 1,
            
            /// <summary>
            /// Enum NFR for value: NFR
            /// </summary>
            [EnumMember(Value = "NFR")]
            NFR = 2,
            
            /// <summary>
            /// Enum TestRivenditore for value: TestRivenditore
            /// </summary>
            [EnumMember(Value = "TestRivenditore")]
            TestRivenditore = 3,
            
            /// <summary>
            /// Enum CorsoARXivarAcademy for value: CorsoARXivarAcademy
            /// </summary>
            [EnumMember(Value = "CorsoARXivarAcademy")]
            CorsoARXivarAcademy = 4,
            
            /// <summary>
            /// Enum CorsoAltro for value: CorsoAltro
            /// </summary>
            [EnumMember(Value = "CorsoAltro")]
            CorsoAltro = 5,
            
            /// <summary>
            /// Enum ProduzioneClienteFinale for value: ProduzioneClienteFinale
            /// </summary>
            [EnumMember(Value = "ProduzioneClienteFinale")]
            ProduzioneClienteFinale = 6,
            
            /// <summary>
            /// Enum TestClienteFinale for value: TestClienteFinale
            /// </summary>
            [EnumMember(Value = "TestClienteFinale")]
            TestClienteFinale = 7,
            
            /// <summary>
            /// Enum Demo for value: Demo
            /// </summary>
            [EnumMember(Value = "Demo")]
            Demo = 8,
            
            /// <summary>
            /// Enum Development for value: Development
            /// </summary>
            [EnumMember(Value = "Development")]
            Development = 9,
            
            /// <summary>
            /// Enum NextFe for value: NextFe
            /// </summary>
            [EnumMember(Value = "NextFe")]
            NextFe = 10,
            
            /// <summary>
            /// Enum NextFeTest for value: NextFeTest
            /// </summary>
            [EnumMember(Value = "NextFeTest")]
            NextFeTest = 11
        }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum? Purpose { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Standard for value: Standard
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard = 1,
            
            /// <summary>
            /// Enum PluginManager for value: PluginManager
            /// </summary>
            [EnumMember(Value = "PluginManager")]
            PluginManager = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerLicense" /> class.
        /// </summary>
        /// <param name="purpose">purpose.</param>
        /// <param name="type">type.</param>
        /// <param name="idLicense">idLicense.</param>
        /// <param name="machineKey">machineKey.</param>
        /// <param name="activationCode">activationCode.</param>
        /// <param name="note">note.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="issuedTo">issuedTo.</param>
        /// <param name="utcIssuedDate">utcIssuedDate.</param>
        /// <param name="formatVersion">formatVersion.</param>
        /// <param name="formatVersionString">formatVersionString.</param>
        /// <param name="softwareVersion">softwareVersion.</param>
        /// <param name="softwareVersionString">softwareVersionString.</param>
        /// <param name="moduleList">moduleList.</param>
        /// <param name="permissionList">permissionList.</param>
        /// <param name="moduleInstallationList">moduleInstallationList.</param>
        /// <param name="signature">signature.</param>
        public ServerLicense(PurposeEnum? purpose = default(PurposeEnum?), TypeEnum? type = default(TypeEnum?), string idLicense = default(string), string machineKey = default(string), string activationCode = default(string), string note = default(string), string issuer = default(string), LicenseCustomer issuedTo = default(LicenseCustomer), DateTime? utcIssuedDate = default(DateTime?), Version formatVersion = default(Version), string formatVersionString = default(string), Version softwareVersion = default(Version), string softwareVersionString = default(string), List<LicenseModule> moduleList = default(List<LicenseModule>), List<LicensePermission> permissionList = default(List<LicensePermission>), List<LicenseModuleInstallation> moduleInstallationList = default(List<LicenseModuleInstallation>), byte[] signature = default(byte[]))
        {
            this.Purpose = purpose;
            this.Type = type;
            this.IdLicense = idLicense;
            this.MachineKey = machineKey;
            this.ActivationCode = activationCode;
            this.Note = note;
            this.Issuer = issuer;
            this.IssuedTo = issuedTo;
            this.UtcIssuedDate = utcIssuedDate;
            this.FormatVersion = formatVersion;
            this.FormatVersionString = formatVersionString;
            this.SoftwareVersion = softwareVersion;
            this.SoftwareVersionString = softwareVersionString;
            this.ModuleList = moduleList;
            this.PermissionList = permissionList;
            this.ModuleInstallationList = moduleInstallationList;
            this.Signature = signature;
        }
        


        /// <summary>
        /// Gets or Sets IdLicense
        /// </summary>
        [DataMember(Name="idLicense", EmitDefaultValue=false)]
        public string IdLicense { get; set; }

        /// <summary>
        /// Gets or Sets MachineKey
        /// </summary>
        [DataMember(Name="machineKey", EmitDefaultValue=false)]
        public string MachineKey { get; set; }

        /// <summary>
        /// Gets or Sets ActivationCode
        /// </summary>
        [DataMember(Name="activationCode", EmitDefaultValue=false)]
        public string ActivationCode { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or Sets IssuedTo
        /// </summary>
        [DataMember(Name="issuedTo", EmitDefaultValue=false)]
        public LicenseCustomer IssuedTo { get; set; }

        /// <summary>
        /// Gets or Sets UtcIssuedDate
        /// </summary>
        [DataMember(Name="utcIssuedDate", EmitDefaultValue=false)]
        public DateTime? UtcIssuedDate { get; set; }

        /// <summary>
        /// Gets or Sets FormatVersion
        /// </summary>
        [DataMember(Name="formatVersion", EmitDefaultValue=false)]
        public Version FormatVersion { get; set; }

        /// <summary>
        /// Gets or Sets FormatVersionString
        /// </summary>
        [DataMember(Name="formatVersionString", EmitDefaultValue=false)]
        public string FormatVersionString { get; set; }

        /// <summary>
        /// Gets or Sets SoftwareVersion
        /// </summary>
        [DataMember(Name="softwareVersion", EmitDefaultValue=false)]
        public Version SoftwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets SoftwareVersionString
        /// </summary>
        [DataMember(Name="softwareVersionString", EmitDefaultValue=false)]
        public string SoftwareVersionString { get; set; }

        /// <summary>
        /// Gets or Sets ModuleList
        /// </summary>
        [DataMember(Name="moduleList", EmitDefaultValue=false)]
        public List<LicenseModule> ModuleList { get; set; }

        /// <summary>
        /// Gets or Sets PermissionList
        /// </summary>
        [DataMember(Name="permissionList", EmitDefaultValue=false)]
        public List<LicensePermission> PermissionList { get; set; }

        /// <summary>
        /// Gets or Sets ModuleInstallationList
        /// </summary>
        [DataMember(Name="moduleInstallationList", EmitDefaultValue=false)]
        public List<LicenseModuleInstallation> ModuleInstallationList { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public byte[] Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerLicense {\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IdLicense: ").Append(IdLicense).Append("\n");
            sb.Append("  MachineKey: ").Append(MachineKey).Append("\n");
            sb.Append("  ActivationCode: ").Append(ActivationCode).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  IssuedTo: ").Append(IssuedTo).Append("\n");
            sb.Append("  UtcIssuedDate: ").Append(UtcIssuedDate).Append("\n");
            sb.Append("  FormatVersion: ").Append(FormatVersion).Append("\n");
            sb.Append("  FormatVersionString: ").Append(FormatVersionString).Append("\n");
            sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
            sb.Append("  SoftwareVersionString: ").Append(SoftwareVersionString).Append("\n");
            sb.Append("  ModuleList: ").Append(ModuleList).Append("\n");
            sb.Append("  PermissionList: ").Append(PermissionList).Append("\n");
            sb.Append("  ModuleInstallationList: ").Append(ModuleInstallationList).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as ServerLicense);
        }

        /// <summary>
        /// Returns true if ServerLicense instances are equal
        /// </summary>
        /// <param name="input">Instance of ServerLicense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerLicense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IdLicense == input.IdLicense ||
                    (this.IdLicense != null &&
                    this.IdLicense.Equals(input.IdLicense))
                ) && 
                (
                    this.MachineKey == input.MachineKey ||
                    (this.MachineKey != null &&
                    this.MachineKey.Equals(input.MachineKey))
                ) && 
                (
                    this.ActivationCode == input.ActivationCode ||
                    (this.ActivationCode != null &&
                    this.ActivationCode.Equals(input.ActivationCode))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.IssuedTo == input.IssuedTo ||
                    (this.IssuedTo != null &&
                    this.IssuedTo.Equals(input.IssuedTo))
                ) && 
                (
                    this.UtcIssuedDate == input.UtcIssuedDate ||
                    (this.UtcIssuedDate != null &&
                    this.UtcIssuedDate.Equals(input.UtcIssuedDate))
                ) && 
                (
                    this.FormatVersion == input.FormatVersion ||
                    (this.FormatVersion != null &&
                    this.FormatVersion.Equals(input.FormatVersion))
                ) && 
                (
                    this.FormatVersionString == input.FormatVersionString ||
                    (this.FormatVersionString != null &&
                    this.FormatVersionString.Equals(input.FormatVersionString))
                ) && 
                (
                    this.SoftwareVersion == input.SoftwareVersion ||
                    (this.SoftwareVersion != null &&
                    this.SoftwareVersion.Equals(input.SoftwareVersion))
                ) && 
                (
                    this.SoftwareVersionString == input.SoftwareVersionString ||
                    (this.SoftwareVersionString != null &&
                    this.SoftwareVersionString.Equals(input.SoftwareVersionString))
                ) && 
                (
                    this.ModuleList == input.ModuleList ||
                    this.ModuleList != null &&
                    this.ModuleList.SequenceEqual(input.ModuleList)
                ) && 
                (
                    this.PermissionList == input.PermissionList ||
                    this.PermissionList != null &&
                    this.PermissionList.SequenceEqual(input.PermissionList)
                ) && 
                (
                    this.ModuleInstallationList == input.ModuleInstallationList ||
                    this.ModuleInstallationList != null &&
                    this.ModuleInstallationList.SequenceEqual(input.ModuleInstallationList)
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IdLicense != null)
                    hashCode = hashCode * 59 + this.IdLicense.GetHashCode();
                if (this.MachineKey != null)
                    hashCode = hashCode * 59 + this.MachineKey.GetHashCode();
                if (this.ActivationCode != null)
                    hashCode = hashCode * 59 + this.ActivationCode.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.IssuedTo != null)
                    hashCode = hashCode * 59 + this.IssuedTo.GetHashCode();
                if (this.UtcIssuedDate != null)
                    hashCode = hashCode * 59 + this.UtcIssuedDate.GetHashCode();
                if (this.FormatVersion != null)
                    hashCode = hashCode * 59 + this.FormatVersion.GetHashCode();
                if (this.FormatVersionString != null)
                    hashCode = hashCode * 59 + this.FormatVersionString.GetHashCode();
                if (this.SoftwareVersion != null)
                    hashCode = hashCode * 59 + this.SoftwareVersion.GetHashCode();
                if (this.SoftwareVersionString != null)
                    hashCode = hashCode * 59 + this.SoftwareVersionString.GetHashCode();
                if (this.ModuleList != null)
                    hashCode = hashCode * 59 + this.ModuleList.GetHashCode();
                if (this.PermissionList != null)
                    hashCode = hashCode * 59 + this.PermissionList.GetHashCode();
                if (this.ModuleInstallationList != null)
                    hashCode = hashCode * 59 + this.ModuleInstallationList.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
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
