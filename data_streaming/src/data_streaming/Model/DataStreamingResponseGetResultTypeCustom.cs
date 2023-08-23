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
    /// DataStreamingResponseGetResultTypeCustom
    /// </summary>
    [DataContract(Name = "DataStreamingResponseGetResultTypeCustom")]
    public partial class DataStreamingResponseGetResultTypeCustom : IEquatable<DataStreamingResponseGetResultTypeCustom>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingResponseGetResultTypeCustom" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="dataSource">dataSource.</param>
        /// <param name="active">active.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="allDomains">allDomains.</param>
        /// <param name="templateModel">templateModel.</param>
        public DataStreamingResponseGetResultTypeCustom(int id = default(int), string name = default(string), string dataSource = default(string), bool active = default(bool), DataStreamingEndpointTypeKafka endpoint = default(DataStreamingEndpointTypeKafka), bool allDomains = default(bool), string templateModel = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.DataSource = dataSource;
            this.Active = active;
            this.Endpoint = endpoint;
            this.AllDomains = allDomains;
            this.TemplateModel = templateModel;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name = "data_source", EmitDefaultValue = false)]
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public DataStreamingEndpointTypeKafka Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets AllDomains
        /// </summary>
        [DataMember(Name = "all_domains", EmitDefaultValue = true)]
        public bool AllDomains { get; set; }

        /// <summary>
        /// Gets or Sets TemplateModel
        /// </summary>
        [DataMember(Name = "template_model", EmitDefaultValue = false)]
        public string TemplateModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataStreamingResponseGetResultTypeCustom {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  AllDomains: ").Append(AllDomains).Append("\n");
            sb.Append("  TemplateModel: ").Append(TemplateModel).Append("\n");
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
            return this.Equals(input as DataStreamingResponseGetResultTypeCustom);
        }

        /// <summary>
        /// Returns true if DataStreamingResponseGetResultTypeCustom instances are equal
        /// </summary>
        /// <param name="input">Instance of DataStreamingResponseGetResultTypeCustom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataStreamingResponseGetResultTypeCustom input)
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
                    this.DataSource == input.DataSource ||
                    (this.DataSource != null &&
                    this.DataSource.Equals(input.DataSource))
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.AllDomains == input.AllDomains ||
                    this.AllDomains.Equals(input.AllDomains)
                ) && 
                (
                    this.TemplateModel == input.TemplateModel ||
                    (this.TemplateModel != null &&
                    this.TemplateModel.Equals(input.TemplateModel))
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
                if (this.DataSource != null)
                {
                    hashCode = (hashCode * 59) + this.DataSource.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllDomains.GetHashCode();
                if (this.TemplateModel != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateModel.GetHashCode();
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
