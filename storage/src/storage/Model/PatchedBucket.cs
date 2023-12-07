/*
 * Object Storage
 *
 * REST API OpenAPI documentation for the Object Storage
 *
 * The version of the OpenAPI document: 1.0.0 (v1)
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
using OpenAPIDateConverter = storage.Client.OpenAPIDateConverter;

namespace storage.Model
{
    /// <summary>
    /// PatchedBucket
    /// </summary>
    [DataContract(Name = "PatchedBucket")]
    public partial class PatchedBucket : IEquatable<PatchedBucket>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EdgeAccess
        /// </summary>
        [DataMember(Name = "edge_access", EmitDefaultValue = false)]
        public EdgeAccessEnum? EdgeAccess { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedBucket" /> class.
        /// </summary>
        /// <param name="edgeAccess">edgeAccess.</param>
        public PatchedBucket(EdgeAccessEnum? edgeAccess = default(EdgeAccessEnum?))
        {
            this.EdgeAccess = edgeAccess;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchedBucket {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EdgeAccess: ").Append(EdgeAccess).Append("\n");
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
            return this.Equals(input as PatchedBucket);
        }

        /// <summary>
        /// Returns true if PatchedBucket instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchedBucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchedBucket input)
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
                    this.EdgeAccess == input.EdgeAccess ||
                    this.EdgeAccess.Equals(input.EdgeAccess)
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
                hashCode = (hashCode * 59) + this.EdgeAccess.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 63)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 63.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 6.", new [] { "Name" });
            }

            yield break;
        }
    }

}
