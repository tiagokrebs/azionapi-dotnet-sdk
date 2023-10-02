/*
 * Web Application Firewall API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = waf.Client.OpenAPIDateConverter;

namespace waf.Model
{
    /// <summary>
    /// CreateNewWAFRulesetRequest
    /// </summary>
    [DataContract(Name = "createNewWAFRuleset_request")]
    public partial class CreateNewWAFRulesetRequest : IEquatable<CreateNewWAFRulesetRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Blocking for value: blocking
            /// </summary>
            [EnumMember(Value = "blocking")]
            Blocking = 1,

            /// <summary>
            /// Enum Counting for value: counting
            /// </summary>
            [EnumMember(Value = "counting")]
            Counting = 2
        }


        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public ModeEnum Mode { get; set; }

        /// <summary>
        /// Gets or Sets SqlInjectionSensitivity
        /// </summary>
        [DataMember(Name = "sql_injection_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices SqlInjectionSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets RemoteFileInclusionSensitivity
        /// </summary>
        [DataMember(Name = "remote_file_inclusion_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices RemoteFileInclusionSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryTraversalSensitivity
        /// </summary>
        [DataMember(Name = "directory_traversal_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices DirectoryTraversalSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets CrossSiteScriptingSensitivity
        /// </summary>
        [DataMember(Name = "cross_site_scripting_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices CrossSiteScriptingSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets EvadingTricksSensitivity
        /// </summary>
        [DataMember(Name = "evading_tricks_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices EvadingTricksSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets FileUploadSensitivity
        /// </summary>
        [DataMember(Name = "file_upload_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices FileUploadSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets UnwantedAccessSensitivity
        /// </summary>
        [DataMember(Name = "unwanted_access_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices UnwantedAccessSensitivity { get; set; }

        /// <summary>
        /// Gets or Sets IdentifiedAttackSensitivity
        /// </summary>
        [DataMember(Name = "identified_attack_sensitivity", IsRequired = true, EmitDefaultValue = true)]
        public WAFSensitivityChoices IdentifiedAttackSensitivity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewWAFRulesetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateNewWAFRulesetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewWAFRulesetRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">Identification name for WAF Rule Set. (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="active">active (required).</param>
        /// <param name="sqlInjection">sqlInjection (required).</param>
        /// <param name="sqlInjectionSensitivity">sqlInjectionSensitivity (required).</param>
        /// <param name="remoteFileInclusion">remoteFileInclusion (required).</param>
        /// <param name="remoteFileInclusionSensitivity">remoteFileInclusionSensitivity (required).</param>
        /// <param name="directoryTraversal">directoryTraversal (required).</param>
        /// <param name="directoryTraversalSensitivity">directoryTraversalSensitivity (required).</param>
        /// <param name="crossSiteScripting">crossSiteScripting (required).</param>
        /// <param name="crossSiteScriptingSensitivity">crossSiteScriptingSensitivity (required).</param>
        /// <param name="evadingTricks">evadingTricks (required).</param>
        /// <param name="evadingTricksSensitivity">evadingTricksSensitivity (required).</param>
        /// <param name="fileUpload">fileUpload (required).</param>
        /// <param name="fileUploadSensitivity">fileUploadSensitivity (required).</param>
        /// <param name="unwantedAccess">unwantedAccess (required).</param>
        /// <param name="unwantedAccessSensitivity">unwantedAccessSensitivity (required).</param>
        /// <param name="identifiedAttack">identifiedAttack (required).</param>
        /// <param name="identifiedAttackSensitivity">identifiedAttackSensitivity (required).</param>
        /// <param name="bypassAddresses">bypassAddresses (required).</param>
        public CreateNewWAFRulesetRequest(long id = default(long), string name = default(string), ModeEnum mode = default(ModeEnum), bool active = default(bool), bool sqlInjection = default(bool), WAFSensitivityChoices sqlInjectionSensitivity = default(WAFSensitivityChoices), bool remoteFileInclusion = default(bool), WAFSensitivityChoices remoteFileInclusionSensitivity = default(WAFSensitivityChoices), bool directoryTraversal = default(bool), WAFSensitivityChoices directoryTraversalSensitivity = default(WAFSensitivityChoices), bool crossSiteScripting = default(bool), WAFSensitivityChoices crossSiteScriptingSensitivity = default(WAFSensitivityChoices), bool evadingTricks = default(bool), WAFSensitivityChoices evadingTricksSensitivity = default(WAFSensitivityChoices), bool fileUpload = default(bool), WAFSensitivityChoices fileUploadSensitivity = default(WAFSensitivityChoices), bool unwantedAccess = default(bool), WAFSensitivityChoices unwantedAccessSensitivity = default(WAFSensitivityChoices), bool identifiedAttack = default(bool), WAFSensitivityChoices identifiedAttackSensitivity = default(WAFSensitivityChoices), List<string> bypassAddresses = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateNewWAFRulesetRequest and cannot be null");
            }
            this.Name = name;
            this.Mode = mode;
            this.Active = active;
            this.SqlInjection = sqlInjection;
            this.SqlInjectionSensitivity = sqlInjectionSensitivity;
            this.RemoteFileInclusion = remoteFileInclusion;
            this.RemoteFileInclusionSensitivity = remoteFileInclusionSensitivity;
            this.DirectoryTraversal = directoryTraversal;
            this.DirectoryTraversalSensitivity = directoryTraversalSensitivity;
            this.CrossSiteScripting = crossSiteScripting;
            this.CrossSiteScriptingSensitivity = crossSiteScriptingSensitivity;
            this.EvadingTricks = evadingTricks;
            this.EvadingTricksSensitivity = evadingTricksSensitivity;
            this.FileUpload = fileUpload;
            this.FileUploadSensitivity = fileUploadSensitivity;
            this.UnwantedAccess = unwantedAccess;
            this.UnwantedAccessSensitivity = unwantedAccessSensitivity;
            this.IdentifiedAttack = identifiedAttack;
            this.IdentifiedAttackSensitivity = identifiedAttackSensitivity;
            // to ensure "bypassAddresses" is required (not null)
            if (bypassAddresses == null)
            {
                throw new ArgumentNullException("bypassAddresses is a required property for CreateNewWAFRulesetRequest and cannot be null");
            }
            this.BypassAddresses = bypassAddresses;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Identification name for WAF Rule Set.
        /// </summary>
        /// <value>Identification name for WAF Rule Set.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets SqlInjection
        /// </summary>
        [DataMember(Name = "sql_injection", IsRequired = true, EmitDefaultValue = true)]
        public bool SqlInjection { get; set; }

        /// <summary>
        /// Gets or Sets RemoteFileInclusion
        /// </summary>
        [DataMember(Name = "remote_file_inclusion", IsRequired = true, EmitDefaultValue = true)]
        public bool RemoteFileInclusion { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryTraversal
        /// </summary>
        [DataMember(Name = "directory_traversal", IsRequired = true, EmitDefaultValue = true)]
        public bool DirectoryTraversal { get; set; }

        /// <summary>
        /// Gets or Sets CrossSiteScripting
        /// </summary>
        [DataMember(Name = "cross_site_scripting", IsRequired = true, EmitDefaultValue = true)]
        public bool CrossSiteScripting { get; set; }

        /// <summary>
        /// Gets or Sets EvadingTricks
        /// </summary>
        [DataMember(Name = "evading_tricks", IsRequired = true, EmitDefaultValue = true)]
        public bool EvadingTricks { get; set; }

        /// <summary>
        /// Gets or Sets FileUpload
        /// </summary>
        [DataMember(Name = "file_upload", IsRequired = true, EmitDefaultValue = true)]
        public bool FileUpload { get; set; }

        /// <summary>
        /// Gets or Sets UnwantedAccess
        /// </summary>
        [DataMember(Name = "unwanted_access", IsRequired = true, EmitDefaultValue = true)]
        public bool UnwantedAccess { get; set; }

        /// <summary>
        /// Gets or Sets IdentifiedAttack
        /// </summary>
        [DataMember(Name = "identified_attack", IsRequired = true, EmitDefaultValue = true)]
        public bool IdentifiedAttack { get; set; }

        /// <summary>
        /// Gets or Sets BypassAddresses
        /// </summary>
        [DataMember(Name = "bypass_addresses", IsRequired = true, EmitDefaultValue = true)]
        public List<string> BypassAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateNewWAFRulesetRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  SqlInjection: ").Append(SqlInjection).Append("\n");
            sb.Append("  SqlInjectionSensitivity: ").Append(SqlInjectionSensitivity).Append("\n");
            sb.Append("  RemoteFileInclusion: ").Append(RemoteFileInclusion).Append("\n");
            sb.Append("  RemoteFileInclusionSensitivity: ").Append(RemoteFileInclusionSensitivity).Append("\n");
            sb.Append("  DirectoryTraversal: ").Append(DirectoryTraversal).Append("\n");
            sb.Append("  DirectoryTraversalSensitivity: ").Append(DirectoryTraversalSensitivity).Append("\n");
            sb.Append("  CrossSiteScripting: ").Append(CrossSiteScripting).Append("\n");
            sb.Append("  CrossSiteScriptingSensitivity: ").Append(CrossSiteScriptingSensitivity).Append("\n");
            sb.Append("  EvadingTricks: ").Append(EvadingTricks).Append("\n");
            sb.Append("  EvadingTricksSensitivity: ").Append(EvadingTricksSensitivity).Append("\n");
            sb.Append("  FileUpload: ").Append(FileUpload).Append("\n");
            sb.Append("  FileUploadSensitivity: ").Append(FileUploadSensitivity).Append("\n");
            sb.Append("  UnwantedAccess: ").Append(UnwantedAccess).Append("\n");
            sb.Append("  UnwantedAccessSensitivity: ").Append(UnwantedAccessSensitivity).Append("\n");
            sb.Append("  IdentifiedAttack: ").Append(IdentifiedAttack).Append("\n");
            sb.Append("  IdentifiedAttackSensitivity: ").Append(IdentifiedAttackSensitivity).Append("\n");
            sb.Append("  BypassAddresses: ").Append(BypassAddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNewWAFRulesetRequest);
        }

        /// <summary>
        /// Returns true if CreateNewWAFRulesetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNewWAFRulesetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNewWAFRulesetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.SqlInjection == input.SqlInjection ||
                    this.SqlInjection.Equals(input.SqlInjection)
                ) && 
                (
                    this.SqlInjectionSensitivity == input.SqlInjectionSensitivity ||
                    this.SqlInjectionSensitivity.Equals(input.SqlInjectionSensitivity)
                ) && 
                (
                    this.RemoteFileInclusion == input.RemoteFileInclusion ||
                    this.RemoteFileInclusion.Equals(input.RemoteFileInclusion)
                ) && 
                (
                    this.RemoteFileInclusionSensitivity == input.RemoteFileInclusionSensitivity ||
                    this.RemoteFileInclusionSensitivity.Equals(input.RemoteFileInclusionSensitivity)
                ) && 
                (
                    this.DirectoryTraversal == input.DirectoryTraversal ||
                    this.DirectoryTraversal.Equals(input.DirectoryTraversal)
                ) && 
                (
                    this.DirectoryTraversalSensitivity == input.DirectoryTraversalSensitivity ||
                    this.DirectoryTraversalSensitivity.Equals(input.DirectoryTraversalSensitivity)
                ) && 
                (
                    this.CrossSiteScripting == input.CrossSiteScripting ||
                    this.CrossSiteScripting.Equals(input.CrossSiteScripting)
                ) && 
                (
                    this.CrossSiteScriptingSensitivity == input.CrossSiteScriptingSensitivity ||
                    this.CrossSiteScriptingSensitivity.Equals(input.CrossSiteScriptingSensitivity)
                ) && 
                (
                    this.EvadingTricks == input.EvadingTricks ||
                    this.EvadingTricks.Equals(input.EvadingTricks)
                ) && 
                (
                    this.EvadingTricksSensitivity == input.EvadingTricksSensitivity ||
                    this.EvadingTricksSensitivity.Equals(input.EvadingTricksSensitivity)
                ) && 
                (
                    this.FileUpload == input.FileUpload ||
                    this.FileUpload.Equals(input.FileUpload)
                ) && 
                (
                    this.FileUploadSensitivity == input.FileUploadSensitivity ||
                    this.FileUploadSensitivity.Equals(input.FileUploadSensitivity)
                ) && 
                (
                    this.UnwantedAccess == input.UnwantedAccess ||
                    this.UnwantedAccess.Equals(input.UnwantedAccess)
                ) && 
                (
                    this.UnwantedAccessSensitivity == input.UnwantedAccessSensitivity ||
                    this.UnwantedAccessSensitivity.Equals(input.UnwantedAccessSensitivity)
                ) && 
                (
                    this.IdentifiedAttack == input.IdentifiedAttack ||
                    this.IdentifiedAttack.Equals(input.IdentifiedAttack)
                ) && 
                (
                    this.IdentifiedAttackSensitivity == input.IdentifiedAttackSensitivity ||
                    this.IdentifiedAttackSensitivity.Equals(input.IdentifiedAttackSensitivity)
                ) && 
                (
                    this.BypassAddresses == input.BypassAddresses ||
                    this.BypassAddresses != null &&
                    input.BypassAddresses != null &&
                    this.BypassAddresses.SequenceEqual(input.BypassAddresses)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.SqlInjection.GetHashCode();
                hashCode = (hashCode * 59) + this.SqlInjectionSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoteFileInclusion.GetHashCode();
                hashCode = (hashCode * 59) + this.RemoteFileInclusionSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.DirectoryTraversal.GetHashCode();
                hashCode = (hashCode * 59) + this.DirectoryTraversalSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.CrossSiteScripting.GetHashCode();
                hashCode = (hashCode * 59) + this.CrossSiteScriptingSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.EvadingTricks.GetHashCode();
                hashCode = (hashCode * 59) + this.EvadingTricksSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.FileUpload.GetHashCode();
                hashCode = (hashCode * 59) + this.FileUploadSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.UnwantedAccess.GetHashCode();
                hashCode = (hashCode * 59) + this.UnwantedAccessSensitivity.GetHashCode();
                hashCode = (hashCode * 59) + this.IdentifiedAttack.GetHashCode();
                hashCode = (hashCode * 59) + this.IdentifiedAttackSensitivity.GetHashCode();
                if (this.BypassAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.BypassAddresses.GetHashCode();
                }
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