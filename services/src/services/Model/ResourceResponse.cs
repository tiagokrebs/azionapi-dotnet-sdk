/*
 * Services API
 *
 * Azion Services
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
using OpenAPIDateConverter = services.Client.OpenAPIDateConverter;

namespace services.Model
{
    /// <summary>
    /// ResourceResponse
    /// </summary>
    [DataContract(Name = "ResourceResponse")]
    public partial class ResourceResponse : IEquatable<ResourceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceResponse" /> class.
        /// </summary>
        /// <param name="contentType">contentType (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="lastEditor">lastEditor (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="trigger">trigger (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public ResourceResponse(string contentType = default(string), long id = default(long), string lastEditor = default(string), string name = default(string), string trigger = default(string), string updatedAt = default(string))
        {
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType is a required property for ResourceResponse and cannot be null");
            }
            this.ContentType = contentType;
            this.Id = id;
            // to ensure "lastEditor" is required (not null)
            if (lastEditor == null)
            {
                throw new ArgumentNullException("lastEditor is a required property for ResourceResponse and cannot be null");
            }
            this.LastEditor = lastEditor;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ResourceResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new ArgumentNullException("trigger is a required property for ResourceResponse and cannot be null");
            }
            this.Trigger = trigger;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for ResourceResponse and cannot be null");
            }
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "content_type", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets LastEditor
        /// </summary>
        [DataMember(Name = "last_editor", IsRequired = true, EmitDefaultValue = true)]
        public string LastEditor { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = true)]
        public string Trigger { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceResponse {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastEditor: ").Append(LastEditor).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ResourceResponse);
        }

        /// <summary>
        /// Returns true if ResourceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.LastEditor == input.LastEditor ||
                    (this.LastEditor != null &&
                    this.LastEditor.Equals(input.LastEditor))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.LastEditor != null)
                {
                    hashCode = (hashCode * 59) + this.LastEditor.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Trigger != null)
                {
                    hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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