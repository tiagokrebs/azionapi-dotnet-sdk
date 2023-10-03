/*
 * Edge Firewall API
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
using OpenAPIDateConverter = edgefirewall.Client.OpenAPIDateConverter;

namespace edgefirewall.Model
{
    /// <summary>
    /// RuleSetResponse
    /// </summary>
    [DataContract(Name = "RuleSetResponse")]
    public partial class RuleSetResponse : IEquatable<RuleSetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSetResponse" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="behaviors">behaviors.</param>
        /// <param name="criteria">criteria.</param>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="lastEditor">lastEditor.</param>
        /// <param name="id">id.</param>
        /// <param name="order">order.</param>
        public RuleSetResponse(string name = default(string), bool isActive = default(bool), List<Behaviors> behaviors = default(List<Behaviors>), List<List<SSLVerificationStatusCriteria>> criteria = default(List<List<SSLVerificationStatusCriteria>>), DateTime lastModified = default(DateTime), string lastEditor = default(string), long id = default(long), long order = default(long))
        {
            this.Name = name;
            this.IsActive = isActive;
            this.Behaviors = behaviors;
            this.Criteria = criteria;
            this.LastModified = lastModified;
            this.LastEditor = lastEditor;
            this.Id = id;
            this.Order = order;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "is_active", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Behaviors
        /// </summary>
        [DataMember(Name = "behaviors", EmitDefaultValue = false)]
        public List<Behaviors> Behaviors { get; set; }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name = "criteria", EmitDefaultValue = false)]
        public List<List<SSLVerificationStatusCriteria>> Criteria { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name = "last_modified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Gets or Sets LastEditor
        /// </summary>
        [DataMember(Name = "last_editor", EmitDefaultValue = false)]
        public string LastEditor { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public long Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleSetResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  LastEditor: ").Append(LastEditor).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as RuleSetResponse);
        }

        /// <summary>
        /// Returns true if RuleSetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleSetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleSetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Behaviors == input.Behaviors ||
                    this.Behaviors != null &&
                    input.Behaviors != null &&
                    this.Behaviors.SequenceEqual(input.Behaviors)
                ) && 
                (
                    this.Criteria == input.Criteria ||
                    this.Criteria != null &&
                    input.Criteria != null &&
                    this.Criteria.SequenceEqual(input.Criteria)
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.LastEditor == input.LastEditor ||
                    (this.LastEditor != null &&
                    this.LastEditor.Equals(input.LastEditor))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                if (this.Behaviors != null)
                {
                    hashCode = (hashCode * 59) + this.Behaviors.GetHashCode();
                }
                if (this.Criteria != null)
                {
                    hashCode = (hashCode * 59) + this.Criteria.GetHashCode();
                }
                if (this.LastModified != null)
                {
                    hashCode = (hashCode * 59) + this.LastModified.GetHashCode();
                }
                if (this.LastEditor != null)
                {
                    hashCode = (hashCode * 59) + this.LastEditor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
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
            // Id (long) minimum
            if (this.Id < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            // Order (long) minimum
            if (this.Order < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value greater than or equal to 1.", new [] { "Order" });
            }

            yield break;
        }
    }

}
