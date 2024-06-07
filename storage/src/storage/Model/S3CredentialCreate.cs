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
    /// S3CredentialCreate
    /// </summary>
    [DataContract(Name = "S3CredentialCreate")]
    public partial class S3CredentialCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="S3CredentialCreate" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="bucket">bucket.</param>
        /// <param name="expirationDate">expirationDate.</param>
        public S3CredentialCreate(string name = default(string), List<string> capabilities = default(List<string>), string bucket = default(string), DateTime expirationDate = default(DateTime))
        {
            this.Name = name;
            this.Capabilities = capabilities;
            this.Bucket = bucket;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>my-s3-credential-all-permissions</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        /// <example>[&quot;listAllBucketNames&quot;,&quot;listBuckets&quot;,&quot;listFiles&quot;,&quot;readFiles&quot;,&quot;writeFiles&quot;,&quot;deleteFiles&quot;]</example>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        /// <example>s3-credentials-bucket</example>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        /// <example>2025-01-31T10:57Z</example>
        [DataMember(Name = "expiration_date", EmitDefaultValue = false)]
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class S3CredentialCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 200.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            if (this.Name != null) {
                // Name (string) pattern
                Regex regexName = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexName.Match(this.Name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
                }
            }

            // Bucket (string) maxLength
            if (this.Bucket != null && this.Bucket.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bucket, length must be less than 200.", new [] { "Bucket" });
            }

            // Bucket (string) minLength
            if (this.Bucket != null && this.Bucket.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bucket, length must be greater than 1.", new [] { "Bucket" });
            }

            if (this.Bucket != null) {
                // Bucket (string) pattern
                Regex regexBucket = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexBucket.Match(this.Bucket).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bucket, must match a pattern of " + regexBucket, new [] { "Bucket" });
                }
            }

            // ExpirationDate (DateTime) maxLength
            if (this.ExpirationDate != null && this.ExpirationDate.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, length must be less than 30.", new [] { "ExpirationDate" });
            }

            // ExpirationDate (DateTime) minLength
            if (this.ExpirationDate != null && this.ExpirationDate.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, length must be greater than 10.", new [] { "ExpirationDate" });
            }

            if (this.ExpirationDate != null) {
                // ExpirationDate (DateTime) pattern
                Regex regexExpirationDate = new Regex(@".*", RegexOptions.CultureInvariant);
                if (!regexExpirationDate.Match(this.ExpirationDate).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationDate, must match a pattern of " + regexExpirationDate, new [] { "ExpirationDate" });
                }
            }

            yield break;
        }
    }

}
