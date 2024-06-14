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
    /// ApplicationUpdateResults
    /// </summary>
    [DataContract(Name = "ApplicationUpdateResults")]
    public partial class ApplicationUpdateResults : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdateResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationUpdateResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdateResults" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="deliveryProtocol">deliveryProtocol (required).</param>
        /// <param name="httpPort">httpPort (required).</param>
        /// <param name="httpsPort">httpsPort (required).</param>
        /// <param name="minimumTlsVersion">minimumTlsVersion (required).</param>
        /// <param name="active">active (required).</param>
        /// <param name="debugRules">debugRules (required).</param>
        /// <param name="http3">http3 (required).</param>
        /// <param name="supportedCiphers">supportedCiphers (required).</param>
        /// <param name="applicationAcceleration">applicationAcceleration (required).</param>
        /// <param name="caching">caching (required).</param>
        /// <param name="deviceDetection">deviceDetection (required).</param>
        /// <param name="edgeFirewall">edgeFirewall (required).</param>
        /// <param name="edgeFunctions">edgeFunctions (required).</param>
        /// <param name="imageOptimization">imageOptimization (required).</param>
        /// <param name="l2Caching">l2Caching (required).</param>
        /// <param name="loadBalancer">loadBalancer (required).</param>
        /// <param name="rawLogs">rawLogs (required).</param>
        /// <param name="webApplicationFirewall">webApplicationFirewall (required).</param>
        /// <param name="websocket">websocket.</param>
        public ApplicationUpdateResults(long id = default(long), string name = default(string), string deliveryProtocol = default(string), Object httpPort = default(Object), Object httpsPort = default(Object), string minimumTlsVersion = default(string), bool active = default(bool), bool debugRules = default(bool), bool http3 = default(bool), string supportedCiphers = default(string), bool applicationAcceleration = default(bool), bool caching = default(bool), bool deviceDetection = default(bool), bool edgeFirewall = default(bool), bool edgeFunctions = default(bool), bool imageOptimization = default(bool), bool l2Caching = default(bool), bool loadBalancer = default(bool), bool rawLogs = default(bool), bool webApplicationFirewall = default(bool), bool websocket = default(bool))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApplicationUpdateResults and cannot be null");
            }
            this.Name = name;
            // to ensure "deliveryProtocol" is required (not null)
            if (deliveryProtocol == null)
            {
                throw new ArgumentNullException("deliveryProtocol is a required property for ApplicationUpdateResults and cannot be null");
            }
            this.DeliveryProtocol = deliveryProtocol;
            // to ensure "httpPort" is required (not null)
            if (httpPort == null)
            {
                throw new ArgumentNullException("httpPort is a required property for ApplicationUpdateResults and cannot be null");
            }
            this.HttpPort = httpPort;
            // to ensure "httpsPort" is required (not null)
            if (httpsPort == null)
            {
                throw new ArgumentNullException("httpsPort is a required property for ApplicationUpdateResults and cannot be null");
            }
            this.HttpsPort = httpsPort;
            // to ensure "minimumTlsVersion" is required (not null)
            if (minimumTlsVersion == null)
            {
                throw new ArgumentNullException("minimumTlsVersion is a required property for ApplicationUpdateResults and cannot be null");
            }
            this.MinimumTlsVersion = minimumTlsVersion;
            this.Active = active;
            this.DebugRules = debugRules;
            this.Http3 = http3;
            // to ensure "supportedCiphers" is required (not null)
            if (supportedCiphers == null)
            {
                throw new ArgumentNullException("supportedCiphers is a required property for ApplicationUpdateResults and cannot be null");
            }
            this.SupportedCiphers = supportedCiphers;
            this.ApplicationAcceleration = applicationAcceleration;
            this.Caching = caching;
            this.DeviceDetection = deviceDetection;
            this.EdgeFirewall = edgeFirewall;
            this.EdgeFunctions = edgeFunctions;
            this.ImageOptimization = imageOptimization;
            this.L2Caching = l2Caching;
            this.LoadBalancer = loadBalancer;
            this.RawLogs = rawLogs;
            this.WebApplicationFirewall = webApplicationFirewall;
            this.Websocket = websocket;
        }

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
        /// Gets or Sets DeliveryProtocol
        /// </summary>
        [DataMember(Name = "delivery_protocol", IsRequired = true, EmitDefaultValue = true)]
        public string DeliveryProtocol { get; set; }

        /// <summary>
        /// Gets or Sets HttpPort
        /// </summary>
        [DataMember(Name = "http_port", IsRequired = true, EmitDefaultValue = true)]
        public Object HttpPort { get; set; }

        /// <summary>
        /// Gets or Sets HttpsPort
        /// </summary>
        [DataMember(Name = "https_port", IsRequired = true, EmitDefaultValue = true)]
        public Object HttpsPort { get; set; }

        /// <summary>
        /// Gets or Sets MinimumTlsVersion
        /// </summary>
        [DataMember(Name = "minimum_tls_version", IsRequired = true, EmitDefaultValue = true)]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets DebugRules
        /// </summary>
        [DataMember(Name = "debug_rules", IsRequired = true, EmitDefaultValue = true)]
        public bool DebugRules { get; set; }

        /// <summary>
        /// Gets or Sets Http3
        /// </summary>
        [DataMember(Name = "http3", IsRequired = true, EmitDefaultValue = true)]
        public bool Http3 { get; set; }

        /// <summary>
        /// Gets or Sets SupportedCiphers
        /// </summary>
        [DataMember(Name = "supported_ciphers", IsRequired = true, EmitDefaultValue = true)]
        public string SupportedCiphers { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationAcceleration
        /// </summary>
        [DataMember(Name = "application_acceleration", IsRequired = true, EmitDefaultValue = true)]
        public bool ApplicationAcceleration { get; set; }

        /// <summary>
        /// Gets or Sets Caching
        /// </summary>
        [DataMember(Name = "caching", IsRequired = true, EmitDefaultValue = true)]
        public bool Caching { get; set; }

        /// <summary>
        /// Gets or Sets DeviceDetection
        /// </summary>
        [DataMember(Name = "device_detection", IsRequired = true, EmitDefaultValue = true)]
        public bool DeviceDetection { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFirewall
        /// </summary>
        [DataMember(Name = "edge_firewall", IsRequired = true, EmitDefaultValue = true)]
        public bool EdgeFirewall { get; set; }

        /// <summary>
        /// Gets or Sets EdgeFunctions
        /// </summary>
        [DataMember(Name = "edge_functions", IsRequired = true, EmitDefaultValue = true)]
        public bool EdgeFunctions { get; set; }

        /// <summary>
        /// Gets or Sets ImageOptimization
        /// </summary>
        [DataMember(Name = "image_optimization", IsRequired = true, EmitDefaultValue = true)]
        public bool ImageOptimization { get; set; }

        /// <summary>
        /// Gets or Sets L2Caching
        /// </summary>
        [DataMember(Name = "l2_caching", IsRequired = true, EmitDefaultValue = true)]
        public bool L2Caching { get; set; }

        /// <summary>
        /// Gets or Sets LoadBalancer
        /// </summary>
        [DataMember(Name = "load_balancer", IsRequired = true, EmitDefaultValue = true)]
        public bool LoadBalancer { get; set; }

        /// <summary>
        /// Gets or Sets RawLogs
        /// </summary>
        [DataMember(Name = "raw_logs", IsRequired = true, EmitDefaultValue = true)]
        public bool RawLogs { get; set; }

        /// <summary>
        /// Gets or Sets WebApplicationFirewall
        /// </summary>
        [DataMember(Name = "web_application_firewall", IsRequired = true, EmitDefaultValue = true)]
        public bool WebApplicationFirewall { get; set; }

        /// <summary>
        /// Gets or Sets Websocket
        /// </summary>
        [DataMember(Name = "websocket", EmitDefaultValue = true)]
        public bool Websocket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationUpdateResults {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeliveryProtocol: ").Append(DeliveryProtocol).Append("\n");
            sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  HttpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  MinimumTlsVersion: ").Append(MinimumTlsVersion).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DebugRules: ").Append(DebugRules).Append("\n");
            sb.Append("  Http3: ").Append(Http3).Append("\n");
            sb.Append("  SupportedCiphers: ").Append(SupportedCiphers).Append("\n");
            sb.Append("  ApplicationAcceleration: ").Append(ApplicationAcceleration).Append("\n");
            sb.Append("  Caching: ").Append(Caching).Append("\n");
            sb.Append("  DeviceDetection: ").Append(DeviceDetection).Append("\n");
            sb.Append("  EdgeFirewall: ").Append(EdgeFirewall).Append("\n");
            sb.Append("  EdgeFunctions: ").Append(EdgeFunctions).Append("\n");
            sb.Append("  ImageOptimization: ").Append(ImageOptimization).Append("\n");
            sb.Append("  L2Caching: ").Append(L2Caching).Append("\n");
            sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
            sb.Append("  RawLogs: ").Append(RawLogs).Append("\n");
            sb.Append("  WebApplicationFirewall: ").Append(WebApplicationFirewall).Append("\n");
            sb.Append("  Websocket: ").Append(Websocket).Append("\n");
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
            yield break;
        }
    }

}
