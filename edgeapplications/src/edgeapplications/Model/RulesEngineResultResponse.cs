/*
 * Edge Application API
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
using OpenAPIDateConverter = edgeapplications.Client.OpenAPIDateConverter;

namespace edgeapplications.Model
{
    /// <summary>
    /// RulesEngineResultResponse
    /// </summary>
    [DataContract(Name = "RulesEngineResultResponse")]
    public partial class RulesEngineResultResponse : IEquatable<RulesEngineResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RulesEngineResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RulesEngineResultResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="phase">phase (required).</param>
        /// <param name="behaviors">behaviors.</param>
        /// <param name="criteria">criteria (required).</param>
        /// <param name="isActive">isActive (required).</param>
        /// <param name="order">order (required).</param>
        public RulesEngineResultResponse(long id = default(long), string name = default(string), string description = default(string), string phase = default(string), List<RulesEngineBehaviorEntry> behaviors = default(List<RulesEngineBehaviorEntry>), List<List<RulesEngineCriteria>> criteria = default(List<List<RulesEngineCriteria>>), bool isActive = default(bool), long order = default(long))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RulesEngineResultResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "phase" is required (not null)
            if (phase == null)
            {
                throw new ArgumentNullException("phase is a required property for RulesEngineResultResponse and cannot be null");
            }
            this.Phase = phase;
            // to ensure "criteria" is required (not null)
            if (criteria == null)
            {
                throw new ArgumentNullException("criteria is a required property for RulesEngineResultResponse and cannot be null");
            }
            this.Criteria = criteria;
            this.IsActive = isActive;
            this.Order = order;
            this.Description = description;
            this.Behaviors = behaviors;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name = "phase", IsRequired = true, EmitDefaultValue = true)]
        public string Phase { get; set; }

        /// <summary>
        /// Gets or Sets Behaviors
        /// </summary>
        [DataMember(Name = "behaviors", EmitDefaultValue = false)]
        public List<RulesEngineBehaviorEntry> Behaviors { get; set; }

        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name = "criteria", IsRequired = true, EmitDefaultValue = true)]
        public List<List<RulesEngineCriteria>> Criteria { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "is_active", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", IsRequired = true, EmitDefaultValue = true)]
        public long Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RulesEngineResultResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            return this.Equals(input as RulesEngineResultResponse);
        }

        /// <summary>
        /// Returns true if RulesEngineResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RulesEngineResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RulesEngineResultResponse input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
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
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Phase != null)
                {
                    hashCode = (hashCode * 59) + this.Phase.GetHashCode();
                }
                if (this.Behaviors != null)
                {
                    hashCode = (hashCode * 59) + this.Behaviors.GetHashCode();
                }
                if (this.Criteria != null)
                {
                    hashCode = (hashCode * 59) + this.Criteria.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
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
            yield break;
        }
    }

}
