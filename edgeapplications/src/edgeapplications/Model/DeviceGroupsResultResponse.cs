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
    /// DeviceGroupsResultResponse
    /// </summary>
    [DataContract(Name = "DeviceGroupsResultResponse")]
    public partial class DeviceGroupsResultResponse : IEquatable<DeviceGroupsResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupsResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceGroupsResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupsResultResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="userAgent">userAgent (required).</param>
        public DeviceGroupsResultResponse(long id = default(long), string name = default(string), string userAgent = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DeviceGroupsResultResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "userAgent" is required (not null)
            if (userAgent == null)
            {
                throw new ArgumentNullException("userAgent is a required property for DeviceGroupsResultResponse and cannot be null");
            }
            this.UserAgent = userAgent;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name = "user_agent", IsRequired = true, EmitDefaultValue = true)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceGroupsResultResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(input as DeviceGroupsResultResponse);
        }

        /// <summary>
        /// Returns true if DeviceGroupsResultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceGroupsResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceGroupsResultResponse input)
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
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
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
                if (this.UserAgent != null)
                {
                    hashCode = (hashCode * 59) + this.UserAgent.GetHashCode();
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
