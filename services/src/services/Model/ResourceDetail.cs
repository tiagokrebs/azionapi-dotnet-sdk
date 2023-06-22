/*
 * Services API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// ResourceDetail
    /// </summary>
    [DataContract(Name = "ResourceDetail")]
    public partial class ResourceDetail : IEquatable<ResourceDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDetail" /> class.
        /// </summary>
        /// <param name="content">content (required).</param>
        /// <param name="contentType">contentType (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="trigger">trigger (required).</param>
        public ResourceDetail(string content = default(string), string contentType = default(string), long id = default(long), string name = default(string), string trigger = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for ResourceDetail and cannot be null");
            }
            this.Content = content;
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType is a required property for ResourceDetail and cannot be null");
            }
            this.ContentType = contentType;
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ResourceDetail and cannot be null");
            }
            this.Name = name;
            // to ensure "trigger" is required (not null)
            if (trigger == null)
            {
                throw new ArgumentNullException("trigger is a required property for ResourceDetail and cannot be null");
            }
            this.Trigger = trigger;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceDetail {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
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
            return this.Equals(input as ResourceDetail);
        }

        /// <summary>
        /// Returns true if ResourceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Trigger != null)
                {
                    hashCode = (hashCode * 59) + this.Trigger.GetHashCode();
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
