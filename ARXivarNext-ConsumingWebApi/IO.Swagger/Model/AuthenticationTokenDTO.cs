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
    /// Class of authentication token
    /// </summary>
    [DataContract]
    public partial class AuthenticationTokenDTO :  IEquatable<AuthenticationTokenDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenDTO" /> class.
        /// </summary>
        /// <param name="error">Error code.</param>
        /// <param name="errorDescription">Error desciption.</param>
        /// <param name="errorUri">Error Uri.</param>
        /// <param name="accessToken">Access token string.</param>
        /// <param name="tokenType">Token type (bearer).</param>
        /// <param name="expiresIn">Token and refresh token expire in ExpiresIn seconds.</param>
        /// <param name="refreshToken">Refresh token string.</param>
        /// <param name="issued">Issue date of the token.</param>
        /// <param name="expires">Expiration date of the token.</param>
        /// <param name="arxclientId">Client id.</param>
        /// <param name="arxuserMustChangePassword">User must change password after this &#39;login&#39;.</param>
        public AuthenticationTokenDTO(string error = default(string), string errorDescription = default(string), string errorUri = default(string), string accessToken = default(string), string tokenType = default(string), int? expiresIn = default(int?), string refreshToken = default(string), DateTime? issued = default(DateTime?), DateTime? expires = default(DateTime?), string arxclientId = default(string), bool? arxuserMustChangePassword = default(bool?))
        {
            this.Error = error;
            this.ErrorDescription = errorDescription;
            this.ErrorUri = errorUri;
            this.AccessToken = accessToken;
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.RefreshToken = refreshToken;
            this.Issued = issued;
            this.Expires = expires;
            this.ArxclientId = arxclientId;
            this.ArxuserMustChangePassword = arxuserMustChangePassword;
        }
        
        /// <summary>
        /// Error code
        /// </summary>
        /// <value>Error code</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Error desciption
        /// </summary>
        /// <value>Error desciption</value>
        [DataMember(Name="errorDescription", EmitDefaultValue=false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Error Uri
        /// </summary>
        /// <value>Error Uri</value>
        [DataMember(Name="errorUri", EmitDefaultValue=false)]
        public string ErrorUri { get; set; }

        /// <summary>
        /// Access token string
        /// </summary>
        /// <value>Access token string</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Token type (bearer)
        /// </summary>
        /// <value>Token type (bearer)</value>
        [DataMember(Name="tokenType", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Token and refresh token expire in ExpiresIn seconds
        /// </summary>
        /// <value>Token and refresh token expire in ExpiresIn seconds</value>
        [DataMember(Name="expiresIn", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Refresh token string
        /// </summary>
        /// <value>Refresh token string</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Issue date of the token
        /// </summary>
        /// <value>Issue date of the token</value>
        [DataMember(Name="issued", EmitDefaultValue=false)]
        public DateTime? Issued { get; set; }

        /// <summary>
        /// Expiration date of the token
        /// </summary>
        /// <value>Expiration date of the token</value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Client id
        /// </summary>
        /// <value>Client id</value>
        [DataMember(Name="arxclientId", EmitDefaultValue=false)]
        public string ArxclientId { get; set; }

        /// <summary>
        /// User must change password after this &#39;login&#39;
        /// </summary>
        /// <value>User must change password after this &#39;login&#39;</value>
        [DataMember(Name="arxuserMustChangePassword", EmitDefaultValue=false)]
        public bool? ArxuserMustChangePassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationTokenDTO {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  ErrorUri: ").Append(ErrorUri).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Issued: ").Append(Issued).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  ArxclientId: ").Append(ArxclientId).Append("\n");
            sb.Append("  ArxuserMustChangePassword: ").Append(ArxuserMustChangePassword).Append("\n");
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
            return this.Equals(input as AuthenticationTokenDTO);
        }

        /// <summary>
        /// Returns true if AuthenticationTokenDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticationTokenDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationTokenDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
                ) && 
                (
                    this.ErrorUri == input.ErrorUri ||
                    (this.ErrorUri != null &&
                    this.ErrorUri.Equals(input.ErrorUri))
                ) && 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.Issued == input.Issued ||
                    (this.Issued != null &&
                    this.Issued.Equals(input.Issued))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
                ) && 
                (
                    this.ArxclientId == input.ArxclientId ||
                    (this.ArxclientId != null &&
                    this.ArxclientId.Equals(input.ArxclientId))
                ) && 
                (
                    this.ArxuserMustChangePassword == input.ArxuserMustChangePassword ||
                    (this.ArxuserMustChangePassword != null &&
                    this.ArxuserMustChangePassword.Equals(input.ArxuserMustChangePassword))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.ErrorDescription != null)
                    hashCode = hashCode * 59 + this.ErrorDescription.GetHashCode();
                if (this.ErrorUri != null)
                    hashCode = hashCode * 59 + this.ErrorUri.GetHashCode();
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.ExpiresIn != null)
                    hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.Issued != null)
                    hashCode = hashCode * 59 + this.Issued.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.ArxclientId != null)
                    hashCode = hashCode * 59 + this.ArxclientId.GetHashCode();
                if (this.ArxuserMustChangePassword != null)
                    hashCode = hashCode * 59 + this.ArxuserMustChangePassword.GetHashCode();
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
