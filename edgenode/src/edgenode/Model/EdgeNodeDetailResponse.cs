/*
 * Edge Node API
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
using OpenAPIDateConverter = edgenode.Client.OpenAPIDateConverter;

namespace edgenode.Model
{
    /// <summary>
    /// EdgeNodeDetailResponse
    /// </summary>
    [DataContract(Name = "EdgeNodeDetailResponse")]
    public partial class EdgeNodeDetailResponse : IEquatable<EdgeNodeDetailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeNodeDetailResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeNodeDetailResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeNodeDetailResponse" /> class.
        /// </summary>
        /// <param name="groups">groups (required).</param>
        /// <param name="hasServices">hasServices (required).</param>
        /// <param name="hashId">hashId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="modules">modules (required).</param>
        /// <param name="name">name (required).</param>
        public EdgeNodeDetailResponse(List<NodeGroup> groups = default(List<NodeGroup>), bool hasServices = default(bool), string hashId = default(string), long id = default(long), EdgeNodeModules modules = default(EdgeNodeModules), string name = default(string))
        {
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new ArgumentNullException("groups is a required property for EdgeNodeDetailResponse and cannot be null");
            }
            this.Groups = groups;
            this.HasServices = hasServices;
            // to ensure "hashId" is required (not null)
            if (hashId == null)
            {
                throw new ArgumentNullException("hashId is a required property for EdgeNodeDetailResponse and cannot be null");
            }
            this.HashId = hashId;
            this.Id = id;
            // to ensure "modules" is required (not null)
            if (modules == null)
            {
                throw new ArgumentNullException("modules is a required property for EdgeNodeDetailResponse and cannot be null");
            }
            this.Modules = modules;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for EdgeNodeDetailResponse and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", IsRequired = true, EmitDefaultValue = true)]
        public List<NodeGroup> Groups { get; set; }

        /// <summary>
        /// Gets or Sets HasServices
        /// </summary>
        [DataMember(Name = "has_services", IsRequired = true, EmitDefaultValue = true)]
        public bool HasServices { get; set; }

        /// <summary>
        /// Gets or Sets HashId
        /// </summary>
        [DataMember(Name = "hash_id", IsRequired = true, EmitDefaultValue = true)]
        public string HashId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name = "modules", IsRequired = true, EmitDefaultValue = true)]
        public EdgeNodeModules Modules { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdgeNodeDetailResponse {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  HasServices: ").Append(HasServices).Append("\n");
            sb.Append("  HashId: ").Append(HashId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as EdgeNodeDetailResponse);
        }

        /// <summary>
        /// Returns true if EdgeNodeDetailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdgeNodeDetailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeNodeDetailResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.HasServices == input.HasServices ||
                    this.HasServices.Equals(input.HasServices)
                ) && 
                (
                    this.HashId == input.HashId ||
                    (this.HashId != null &&
                    this.HashId.Equals(input.HashId))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Modules == input.Modules ||
                    (this.Modules != null &&
                    this.Modules.Equals(input.Modules))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasServices.GetHashCode();
                if (this.HashId != null)
                {
                    hashCode = (hashCode * 59) + this.HashId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Modules != null)
                {
                    hashCode = (hashCode * 59) + this.Modules.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
