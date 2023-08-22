/*
 * Data Streaming - OpenAPI
 *
 * The Data Streaming API allows you to manage your existing data streamings and templates. Data Streaming allows you to feed your stream processing, SIEM, and big data platforms with the event logs from your applications on Azion in real time. 
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
using OpenAPIDateConverter = data_streaming.Client.OpenAPIDateConverter;

namespace data_streaming.Model
{
    /// <summary>
    /// EndpointAWSKinesisFirehose
    /// </summary>
    [DataContract(Name = "Endpoint_AWS_Kinesis_Firehose")]
    public partial class EndpointAWSKinesisFirehose : IEquatable<EndpointAWSKinesisFirehose>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointAWSKinesisFirehose" /> class.
        /// </summary>
        /// <param name="endpointType">endpointType.</param>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="streamName">streamName.</param>
        /// <param name="region">region.</param>
        /// <param name="secretKey">secretKey.</param>
        public EndpointAWSKinesisFirehose(string endpointType = default(string), string accessKey = default(string), string streamName = default(string), string region = default(string), string secretKey = default(string))
        {
            this.EndpointType = endpointType;
            this.AccessKey = accessKey;
            this.StreamName = streamName;
            this.Region = region;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Gets or Sets EndpointType
        /// </summary>
        /// <example>&quot;aws_kinesis_firehose&quot;</example>
        [DataMember(Name = "endpoint_type", EmitDefaultValue = false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "access_key", EmitDefaultValue = false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets StreamName
        /// </summary>
        [DataMember(Name = "stream_name", EmitDefaultValue = false)]
        public string StreamName { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secret_key", EmitDefaultValue = false)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EndpointAWSKinesisFirehose {\n");
            sb.Append("  EndpointType: ").Append(EndpointType).Append("\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  StreamName: ").Append(StreamName).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
            return this.Equals(input as EndpointAWSKinesisFirehose);
        }

        /// <summary>
        /// Returns true if EndpointAWSKinesisFirehose instances are equal
        /// </summary>
        /// <param name="input">Instance of EndpointAWSKinesisFirehose to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointAWSKinesisFirehose input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EndpointType == input.EndpointType ||
                    (this.EndpointType != null &&
                    this.EndpointType.Equals(input.EndpointType))
                ) && 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.StreamName == input.StreamName ||
                    (this.StreamName != null &&
                    this.StreamName.Equals(input.StreamName))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
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
                if (this.EndpointType != null)
                {
                    hashCode = (hashCode * 59) + this.EndpointType.GetHashCode();
                }
                if (this.AccessKey != null)
                {
                    hashCode = (hashCode * 59) + this.AccessKey.GetHashCode();
                }
                if (this.StreamName != null)
                {
                    hashCode = (hashCode * 59) + this.StreamName.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.SecretKey != null)
                {
                    hashCode = (hashCode * 59) + this.SecretKey.GetHashCode();
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
