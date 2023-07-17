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
    /// UpdateRulesEngineRequest
    /// </summary>
    [DataContract(Name = "UpdateRulesEngineRequest")]
    public partial class UpdateRulesEngineRequest : IEquatable<UpdateRulesEngineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRulesEngineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateRulesEngineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRulesEngineRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="criteria">criteria (required).</param>
        /// <param name="behaviors">behaviors (required).</param>
        public UpdateRulesEngineRequest(string name = default(string), string description = default(string), List<List<RulesEngineCriteria>> criteria = default(List<List<RulesEngineCriteria>>), List<RulesEngineBehavior> behaviors = default(List<RulesEngineBehavior>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateRulesEngineRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "criteria" is required (not null)
            if (criteria == null)
            {
                throw new ArgumentNullException("criteria is a required property for UpdateRulesEngineRequest and cannot be null");
            }
            this.Criteria = criteria;
            // to ensure "behaviors" is required (not null)
            if (behaviors == null)
            {
                throw new ArgumentNullException("behaviors is a required property for UpdateRulesEngineRequest and cannot be null");
            }
            this.Behaviors = behaviors;
            this.Description = description;
        }

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
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name = "criteria", IsRequired = true, EmitDefaultValue = true)]
        public List<List<RulesEngineCriteria>> Criteria { get; set; }

        /// <summary>
        /// Gets or Sets Behaviors
        /// </summary>
        [DataMember(Name = "behaviors", IsRequired = true, EmitDefaultValue = true)]
        public List<RulesEngineBehavior> Behaviors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateRulesEngineRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
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
            return this.Equals(input as UpdateRulesEngineRequest);
        }

        /// <summary>
        /// Returns true if UpdateRulesEngineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateRulesEngineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateRulesEngineRequest input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Criteria == input.Criteria ||
                    this.Criteria != null &&
                    input.Criteria != null &&
                    this.Criteria.SequenceEqual(input.Criteria)
                ) && 
                (
                    this.Behaviors == input.Behaviors ||
                    this.Behaviors != null &&
                    input.Behaviors != null &&
                    this.Behaviors.SequenceEqual(input.Behaviors)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Criteria != null)
                {
                    hashCode = (hashCode * 59) + this.Criteria.GetHashCode();
                }
                if (this.Behaviors != null)
                {
                    hashCode = (hashCode * 59) + this.Behaviors.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1000.", new [] { "Description" });
            }

            yield break;
        }
    }

}
