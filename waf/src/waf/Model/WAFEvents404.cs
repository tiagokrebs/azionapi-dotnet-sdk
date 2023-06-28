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
    /// WAFEvents404
    /// </summary>
    [DataContract(Name = "WAFEvents404")]
    public partial class WAFEvents404 : IEquatable<WAFEvents404>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WAFEvents404" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="schemaVersion">schemaVersion.</param>
        public WAFEvents404(List<Object> errors = default(List<Object>), int schemaVersion = default(int))
        {
            this.Errors = errors;
            this.SchemaVersion = schemaVersion;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<Object> Errors { get; set; }

        /// <summary>
        /// Gets or Sets SchemaVersion
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "schema_version", EmitDefaultValue = false)]
        public int SchemaVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WAFEvents404 {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
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
            return this.Equals(input as WAFEvents404);
        }

        /// <summary>
        /// Returns true if WAFEvents404 instances are equal
        /// </summary>
        /// <param name="input">Instance of WAFEvents404 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WAFEvents404 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    this.SchemaVersion.Equals(input.SchemaVersion)
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
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
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