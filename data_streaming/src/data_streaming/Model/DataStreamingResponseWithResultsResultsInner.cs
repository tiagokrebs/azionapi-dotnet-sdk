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
using System.Reflection;

namespace data_streaming.Model
{
    /// <summary>
    /// DataStreamingResponseWithResultsResultsInner
    /// </summary>
    [JsonConverter(typeof(DataStreamingResponseWithResultsResultsInnerJsonConverter))]
    [DataContract(Name = "DataStreamingResponseWithResults_results_inner")]
    public partial class DataStreamingResponseWithResultsResultsInner : AbstractOpenAPISchema, IEquatable<DataStreamingResponseWithResultsResultsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingResponseWithResultsResultsInner" /> class
        /// with the <see cref="DataStreamingResponseGetResultTypeDatadogDTS" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DataStreamingResponseGetResultTypeDatadogDTS.</param>
        public DataStreamingResponseWithResultsResultsInner(DataStreamingResponseGetResultTypeDatadogDTS actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingResponseWithResultsResultsInner" /> class
        /// with the <see cref="DataStreamingResponseGetResultTypeKafka" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DataStreamingResponseGetResultTypeKafka.</param>
        public DataStreamingResponseWithResultsResultsInner(DataStreamingResponseGetResultTypeKafka actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingResponseWithResultsResultsInner" /> class
        /// with the <see cref="DataStreamingResponseGetResultTypeStandard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DataStreamingResponseGetResultTypeStandard.</param>
        public DataStreamingResponseWithResultsResultsInner(DataStreamingResponseGetResultTypeStandard actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStreamingResponseWithResultsResultsInner" /> class
        /// with the <see cref="DataStreamingResponseGetResultTypeCustom" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DataStreamingResponseGetResultTypeCustom.</param>
        public DataStreamingResponseWithResultsResultsInner(DataStreamingResponseGetResultTypeCustom actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(DataStreamingResponseGetResultTypeCustom))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DataStreamingResponseGetResultTypeDatadogDTS))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DataStreamingResponseGetResultTypeKafka))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(DataStreamingResponseGetResultTypeStandard))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DataStreamingResponseGetResultTypeCustom, DataStreamingResponseGetResultTypeDatadogDTS, DataStreamingResponseGetResultTypeKafka, DataStreamingResponseGetResultTypeStandard");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DataStreamingResponseGetResultTypeDatadogDTS`. If the actual instance is not `DataStreamingResponseGetResultTypeDatadogDTS`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DataStreamingResponseGetResultTypeDatadogDTS</returns>
        public DataStreamingResponseGetResultTypeDatadogDTS GetDataStreamingResponseGetResultTypeDatadogDTS()
        {
            return (DataStreamingResponseGetResultTypeDatadogDTS)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DataStreamingResponseGetResultTypeKafka`. If the actual instance is not `DataStreamingResponseGetResultTypeKafka`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DataStreamingResponseGetResultTypeKafka</returns>
        public DataStreamingResponseGetResultTypeKafka GetDataStreamingResponseGetResultTypeKafka()
        {
            return (DataStreamingResponseGetResultTypeKafka)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DataStreamingResponseGetResultTypeStandard`. If the actual instance is not `DataStreamingResponseGetResultTypeStandard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DataStreamingResponseGetResultTypeStandard</returns>
        public DataStreamingResponseGetResultTypeStandard GetDataStreamingResponseGetResultTypeStandard()
        {
            return (DataStreamingResponseGetResultTypeStandard)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `DataStreamingResponseGetResultTypeCustom`. If the actual instance is not `DataStreamingResponseGetResultTypeCustom`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DataStreamingResponseGetResultTypeCustom</returns>
        public DataStreamingResponseGetResultTypeCustom GetDataStreamingResponseGetResultTypeCustom()
        {
            return (DataStreamingResponseGetResultTypeCustom)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataStreamingResponseWithResultsResultsInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, DataStreamingResponseWithResultsResultsInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DataStreamingResponseWithResultsResultsInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DataStreamingResponseWithResultsResultsInner</returns>
        public static DataStreamingResponseWithResultsResultsInner FromJson(string jsonString)
        {
            DataStreamingResponseWithResultsResultsInner newDataStreamingResponseWithResultsResultsInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDataStreamingResponseWithResultsResultsInner;
            }

            try
            {
                newDataStreamingResponseWithResultsResultsInner = new DataStreamingResponseWithResultsResultsInner(JsonConvert.DeserializeObject<DataStreamingResponseGetResultTypeCustom>(jsonString, DataStreamingResponseWithResultsResultsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDataStreamingResponseWithResultsResultsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DataStreamingResponseGetResultTypeCustom: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newDataStreamingResponseWithResultsResultsInner = new DataStreamingResponseWithResultsResultsInner(JsonConvert.DeserializeObject<DataStreamingResponseGetResultTypeDatadogDTS>(jsonString, DataStreamingResponseWithResultsResultsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDataStreamingResponseWithResultsResultsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DataStreamingResponseGetResultTypeDatadogDTS: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newDataStreamingResponseWithResultsResultsInner = new DataStreamingResponseWithResultsResultsInner(JsonConvert.DeserializeObject<DataStreamingResponseGetResultTypeKafka>(jsonString, DataStreamingResponseWithResultsResultsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDataStreamingResponseWithResultsResultsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DataStreamingResponseGetResultTypeKafka: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newDataStreamingResponseWithResultsResultsInner = new DataStreamingResponseWithResultsResultsInner(JsonConvert.DeserializeObject<DataStreamingResponseGetResultTypeStandard>(jsonString, DataStreamingResponseWithResultsResultsInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newDataStreamingResponseWithResultsResultsInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DataStreamingResponseGetResultTypeStandard: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataStreamingResponseWithResultsResultsInner);
        }

        /// <summary>
        /// Returns true if DataStreamingResponseWithResultsResultsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of DataStreamingResponseWithResultsResultsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataStreamingResponseWithResultsResultsInner input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for DataStreamingResponseWithResultsResultsInner
    /// </summary>
    public class DataStreamingResponseWithResultsResultsInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DataStreamingResponseWithResultsResultsInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return DataStreamingResponseWithResultsResultsInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
