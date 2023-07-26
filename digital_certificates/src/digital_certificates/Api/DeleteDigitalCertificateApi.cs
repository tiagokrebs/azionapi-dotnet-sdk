/*
 * Digital Certificates API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using digital_certificates.Client;
using digital_certificates.Model;

namespace digital_certificates.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeleteDigitalCertificateApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Remove a digital certificate or CSR from your account
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void RemoveDigitalCertificates(int digitalCertificateId, int operationIndex = 0);

        /// <summary>
        /// Remove a digital certificate or CSR from your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveDigitalCertificatesWithHttpInfo(int digitalCertificateId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeleteDigitalCertificateApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Remove a digital certificate or CSR from your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveDigitalCertificatesAsync(int digitalCertificateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Remove a digital certificate or CSR from your account
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveDigitalCertificatesWithHttpInfoAsync(int digitalCertificateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeleteDigitalCertificateApi : IDeleteDigitalCertificateApiSync, IDeleteDigitalCertificateApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DeleteDigitalCertificateApi : IDeleteDigitalCertificateApi
    {
        private digital_certificates.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDigitalCertificateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeleteDigitalCertificateApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDigitalCertificateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeleteDigitalCertificateApi(string basePath)
        {
            this.Configuration = digital_certificates.Client.Configuration.MergeConfigurations(
                digital_certificates.Client.GlobalConfiguration.Instance,
                new digital_certificates.Client.Configuration { BasePath = basePath }
            );
            this.Client = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = digital_certificates.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDigitalCertificateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeleteDigitalCertificateApi(digital_certificates.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = digital_certificates.Client.Configuration.MergeConfigurations(
                digital_certificates.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new digital_certificates.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = digital_certificates.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDigitalCertificateApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DeleteDigitalCertificateApi(digital_certificates.Client.ISynchronousClient client, digital_certificates.Client.IAsynchronousClient asyncClient, digital_certificates.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = digital_certificates.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public digital_certificates.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public digital_certificates.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public digital_certificates.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public digital_certificates.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Remove a digital certificate or CSR from your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void RemoveDigitalCertificates(int digitalCertificateId, int operationIndex = 0)
        {
            RemoveDigitalCertificatesWithHttpInfo(digitalCertificateId);
        }

        /// <summary>
        /// Remove a digital certificate or CSR from your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public digital_certificates.Client.ApiResponse<Object> RemoveDigitalCertificatesWithHttpInfo(int digitalCertificateId, int operationIndex = 0)
        {
            digital_certificates.Client.RequestOptions localVarRequestOptions = new digital_certificates.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = digital_certificates.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = digital_certificates.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("digital_certificate_id", digital_certificates.Client.ClientUtils.ParameterToString(digitalCertificateId)); // path parameter

            localVarRequestOptions.Operation = "DeleteDigitalCertificateApi.RemoveDigitalCertificates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/digital_certificates/{digital_certificate_id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveDigitalCertificates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a digital certificate or CSR from your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveDigitalCertificatesAsync(int digitalCertificateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RemoveDigitalCertificatesWithHttpInfoAsync(digitalCertificateId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Remove a digital certificate or CSR from your account 
        /// </summary>
        /// <exception cref="digital_certificates.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="digitalCertificateId">ID of certificate to delete</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<digital_certificates.Client.ApiResponse<Object>> RemoveDigitalCertificatesWithHttpInfoAsync(int digitalCertificateId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            digital_certificates.Client.RequestOptions localVarRequestOptions = new digital_certificates.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = digital_certificates.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = digital_certificates.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("digital_certificate_id", digital_certificates.Client.ClientUtils.ParameterToString(digitalCertificateId)); // path parameter

            localVarRequestOptions.Operation = "DeleteDigitalCertificateApi.RemoveDigitalCertificates";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/digital_certificates/{digital_certificate_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveDigitalCertificates", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}