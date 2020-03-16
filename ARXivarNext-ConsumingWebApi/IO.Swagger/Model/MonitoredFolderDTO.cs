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
    /// MonitoredFolderDTO
    /// </summary>
    [DataContract]
    public partial class MonitoredFolderDTO :  IEquatable<MonitoredFolderDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoredFolderDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="type">Possible values:  0: Manual  1: Automatic  2: Wizard .</param>
        /// <param name="maskId">maskId.</param>
        /// <param name="predefinedProfileId">predefinedProfileId.</param>
        /// <param name="useSubFolders">useSubFolders.</param>
        /// <param name="path">path.</param>
        /// <param name="parseMode">Possible values:  0: ByPosition  1: BySeparator  2: None .</param>
        /// <param name="characterSeparator">characterSeparator.</param>
        /// <param name="softwareType">Possible values:  0: Generic  1: ArxivarServer  2: ArxivarOcr  3: ArxivarFax  4: ArxivarBarcode  5: ArxivarSpoolRecPro  6: ArxivarSpoolPdf  7: ArxivarSpoolConsole  8: ArxivarWeb  9: ArxivarPmArchiviazione  10: ArxivarPmRubrica  11: ArxivarPmUsersAndGroups  12: ArxivarPmAllegati  13: ArxivarUnitTest  14: ArxivarStartWorkflow  15: ArxivarMailer  16: ArxivarArxService  17: ArxivarPostalizzatore  18: ArxivarSigner  19: ArxivarSdk  20: SAPR3  21: ArxivarThumbnail  22: ArxivarSharedDocument  23: ArxivarDownloaderDocument  24: ArxivarClient  25: ArxivarAWP  26: ArxivarPmOrganizationChart  27: ArxivarMobile  28: Credemtel  29: ArxivarRelationService  30: ArxivarPmLogonProviderAssoc  31: ArxivarMassiveUpdates  32: ArxivarMobileService  33: ArxivarMobileApp  34: ArxivarFasciculationService  35: ArxivarPushNotificationsService  36: ArxivarIX  37: ArxivarPmDocumentDeleting  38: ArxivarMobileOfficeSign  39: GenericWebService  40: ArxivarIndex  41: ArxDrive  42: ArxDriveExtension  43: ArxivarSmartTaskApp  44: ArxDriveMobile  45: Unimatica  46: Eni  47: ArxivarSwapOutService  48: ArxivarSuiteClient  49: ArxivarServerWcf  50: ArxAuthService  51: ArxivarSuiteServer  52: ArxivarSetup  53: ImapPlugin  54: ArxLinkClient  55: BiometricSign  56: ArxCommand  57: ArxivarPmFlatFileTextWriter  58: ArxAssistant  59: ArxLocalSign  60: ArxNode .</param>
        /// <param name="operativity">Possible values:  0: AskConfirm  1: Proceed  2: Buffer .</param>
        public MonitoredFolderDTO(string id = default(string), int? userId = default(int?), int? type = default(int?), string maskId = default(string), int? predefinedProfileId = default(int?), bool? useSubFolders = default(bool?), string path = default(string), int? parseMode = default(int?), string characterSeparator = default(string), int? softwareType = default(int?), int? operativity = default(int?))
        {
            this.Id = id;
            this.UserId = userId;
            this.Type = type;
            this.MaskId = maskId;
            this.PredefinedProfileId = predefinedProfileId;
            this.UseSubFolders = useSubFolders;
            this.Path = path;
            this.ParseMode = parseMode;
            this.CharacterSeparator = characterSeparator;
            this.SoftwareType = softwareType;
            this.Operativity = operativity;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Possible values:  0: Manual  1: Automatic  2: Wizard 
        /// </summary>
        /// <value>Possible values:  0: Manual  1: Automatic  2: Wizard </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets MaskId
        /// </summary>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// Gets or Sets PredefinedProfileId
        /// </summary>
        [DataMember(Name="predefinedProfileId", EmitDefaultValue=false)]
        public int? PredefinedProfileId { get; set; }

        /// <summary>
        /// Gets or Sets UseSubFolders
        /// </summary>
        [DataMember(Name="useSubFolders", EmitDefaultValue=false)]
        public bool? UseSubFolders { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Possible values:  0: ByPosition  1: BySeparator  2: None 
        /// </summary>
        /// <value>Possible values:  0: ByPosition  1: BySeparator  2: None </value>
        [DataMember(Name="parseMode", EmitDefaultValue=false)]
        public int? ParseMode { get; set; }

        /// <summary>
        /// Gets or Sets CharacterSeparator
        /// </summary>
        [DataMember(Name="characterSeparator", EmitDefaultValue=false)]
        public string CharacterSeparator { get; set; }

        /// <summary>
        /// Possible values:  0: Generic  1: ArxivarServer  2: ArxivarOcr  3: ArxivarFax  4: ArxivarBarcode  5: ArxivarSpoolRecPro  6: ArxivarSpoolPdf  7: ArxivarSpoolConsole  8: ArxivarWeb  9: ArxivarPmArchiviazione  10: ArxivarPmRubrica  11: ArxivarPmUsersAndGroups  12: ArxivarPmAllegati  13: ArxivarUnitTest  14: ArxivarStartWorkflow  15: ArxivarMailer  16: ArxivarArxService  17: ArxivarPostalizzatore  18: ArxivarSigner  19: ArxivarSdk  20: SAPR3  21: ArxivarThumbnail  22: ArxivarSharedDocument  23: ArxivarDownloaderDocument  24: ArxivarClient  25: ArxivarAWP  26: ArxivarPmOrganizationChart  27: ArxivarMobile  28: Credemtel  29: ArxivarRelationService  30: ArxivarPmLogonProviderAssoc  31: ArxivarMassiveUpdates  32: ArxivarMobileService  33: ArxivarMobileApp  34: ArxivarFasciculationService  35: ArxivarPushNotificationsService  36: ArxivarIX  37: ArxivarPmDocumentDeleting  38: ArxivarMobileOfficeSign  39: GenericWebService  40: ArxivarIndex  41: ArxDrive  42: ArxDriveExtension  43: ArxivarSmartTaskApp  44: ArxDriveMobile  45: Unimatica  46: Eni  47: ArxivarSwapOutService  48: ArxivarSuiteClient  49: ArxivarServerWcf  50: ArxAuthService  51: ArxivarSuiteServer  52: ArxivarSetup  53: ImapPlugin  54: ArxLinkClient  55: BiometricSign  56: ArxCommand  57: ArxivarPmFlatFileTextWriter  58: ArxAssistant  59: ArxLocalSign  60: ArxNode 
        /// </summary>
        /// <value>Possible values:  0: Generic  1: ArxivarServer  2: ArxivarOcr  3: ArxivarFax  4: ArxivarBarcode  5: ArxivarSpoolRecPro  6: ArxivarSpoolPdf  7: ArxivarSpoolConsole  8: ArxivarWeb  9: ArxivarPmArchiviazione  10: ArxivarPmRubrica  11: ArxivarPmUsersAndGroups  12: ArxivarPmAllegati  13: ArxivarUnitTest  14: ArxivarStartWorkflow  15: ArxivarMailer  16: ArxivarArxService  17: ArxivarPostalizzatore  18: ArxivarSigner  19: ArxivarSdk  20: SAPR3  21: ArxivarThumbnail  22: ArxivarSharedDocument  23: ArxivarDownloaderDocument  24: ArxivarClient  25: ArxivarAWP  26: ArxivarPmOrganizationChart  27: ArxivarMobile  28: Credemtel  29: ArxivarRelationService  30: ArxivarPmLogonProviderAssoc  31: ArxivarMassiveUpdates  32: ArxivarMobileService  33: ArxivarMobileApp  34: ArxivarFasciculationService  35: ArxivarPushNotificationsService  36: ArxivarIX  37: ArxivarPmDocumentDeleting  38: ArxivarMobileOfficeSign  39: GenericWebService  40: ArxivarIndex  41: ArxDrive  42: ArxDriveExtension  43: ArxivarSmartTaskApp  44: ArxDriveMobile  45: Unimatica  46: Eni  47: ArxivarSwapOutService  48: ArxivarSuiteClient  49: ArxivarServerWcf  50: ArxAuthService  51: ArxivarSuiteServer  52: ArxivarSetup  53: ImapPlugin  54: ArxLinkClient  55: BiometricSign  56: ArxCommand  57: ArxivarPmFlatFileTextWriter  58: ArxAssistant  59: ArxLocalSign  60: ArxNode </value>
        [DataMember(Name="softwareType", EmitDefaultValue=false)]
        public int? SoftwareType { get; set; }

        /// <summary>
        /// Possible values:  0: AskConfirm  1: Proceed  2: Buffer 
        /// </summary>
        /// <value>Possible values:  0: AskConfirm  1: Proceed  2: Buffer </value>
        [DataMember(Name="operativity", EmitDefaultValue=false)]
        public int? Operativity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonitoredFolderDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  PredefinedProfileId: ").Append(PredefinedProfileId).Append("\n");
            sb.Append("  UseSubFolders: ").Append(UseSubFolders).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ParseMode: ").Append(ParseMode).Append("\n");
            sb.Append("  CharacterSeparator: ").Append(CharacterSeparator).Append("\n");
            sb.Append("  SoftwareType: ").Append(SoftwareType).Append("\n");
            sb.Append("  Operativity: ").Append(Operativity).Append("\n");
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
            return this.Equals(input as MonitoredFolderDTO);
        }

        /// <summary>
        /// Returns true if MonitoredFolderDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MonitoredFolderDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonitoredFolderDTO input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.PredefinedProfileId == input.PredefinedProfileId ||
                    (this.PredefinedProfileId != null &&
                    this.PredefinedProfileId.Equals(input.PredefinedProfileId))
                ) && 
                (
                    this.UseSubFolders == input.UseSubFolders ||
                    (this.UseSubFolders != null &&
                    this.UseSubFolders.Equals(input.UseSubFolders))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ParseMode == input.ParseMode ||
                    (this.ParseMode != null &&
                    this.ParseMode.Equals(input.ParseMode))
                ) && 
                (
                    this.CharacterSeparator == input.CharacterSeparator ||
                    (this.CharacterSeparator != null &&
                    this.CharacterSeparator.Equals(input.CharacterSeparator))
                ) && 
                (
                    this.SoftwareType == input.SoftwareType ||
                    (this.SoftwareType != null &&
                    this.SoftwareType.Equals(input.SoftwareType))
                ) && 
                (
                    this.Operativity == input.Operativity ||
                    (this.Operativity != null &&
                    this.Operativity.Equals(input.Operativity))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.PredefinedProfileId != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileId.GetHashCode();
                if (this.UseSubFolders != null)
                    hashCode = hashCode * 59 + this.UseSubFolders.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ParseMode != null)
                    hashCode = hashCode * 59 + this.ParseMode.GetHashCode();
                if (this.CharacterSeparator != null)
                    hashCode = hashCode * 59 + this.CharacterSeparator.GetHashCode();
                if (this.SoftwareType != null)
                    hashCode = hashCode * 59 + this.SoftwareType.GetHashCode();
                if (this.Operativity != null)
                    hashCode = hashCode * 59 + this.Operativity.GetHashCode();
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
