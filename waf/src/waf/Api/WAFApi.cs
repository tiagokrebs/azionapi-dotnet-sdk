/*
 * Web Application Firewall API
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
using waf.Client;
using waf.Model;

namespace waf.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWAFApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Find domains attached to a WAF
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WAFDomains200</returns>
        WAFDomains200 GetWAFDomains(long wafId, string name = default(string), int operationIndex = 0);

        /// <summary>
        /// Find domains attached to a WAF
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WAFDomains200</returns>
        ApiResponse<WAFDomains200> GetWAFDomainsWithHttpInfo(long wafId, string name = default(string), int operationIndex = 0);
        /// <summary>
        /// Find WAF log events
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WAFEvents200</returns>
        WAFEvents200 GetWAFEvents(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0);

        /// <summary>
        /// Find WAF log events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WAFEvents200</returns>
        ApiResponse<WAFEvents200> GetWAFEventsWithHttpInfo(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWAFApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Find domains attached to a WAF
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WAFDomains200</returns>
        System.Threading.Tasks.Task<WAFDomains200> GetWAFDomainsAsync(long wafId, string name = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Find domains attached to a WAF
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WAFDomains200)</returns>
        System.Threading.Tasks.Task<ApiResponse<WAFDomains200>> GetWAFDomainsWithHttpInfoAsync(long wafId, string name = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Find WAF log events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WAFEvents200</returns>
        System.Threading.Tasks.Task<WAFEvents200> GetWAFEventsAsync(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Find WAF log events
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WAFEvents200)</returns>
        System.Threading.Tasks.Task<ApiResponse<WAFEvents200>> GetWAFEventsWithHttpInfoAsync(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWAFApi : IWAFApiSync, IWAFApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WAFApi : IWAFApi
    {
        private waf.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WAFApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WAFApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WAFApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WAFApi(string basePath)
        {
            this.Configuration = waf.Client.Configuration.MergeConfigurations(
                waf.Client.GlobalConfiguration.Instance,
                new waf.Client.Configuration { BasePath = basePath }
            );
            this.Client = new waf.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new waf.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = waf.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WAFApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WAFApi(waf.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = waf.Client.Configuration.MergeConfigurations(
                waf.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new waf.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new waf.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = waf.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WAFApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WAFApi(waf.Client.ISynchronousClient client, waf.Client.IAsynchronousClient asyncClient, waf.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = waf.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public waf.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public waf.Client.ISynchronousClient Client { get; set; }

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
        public waf.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public waf.Client.ExceptionFactory ExceptionFactory
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
        /// Find domains attached to a WAF 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WAFDomains200</returns>
        public WAFDomains200 GetWAFDomains(long wafId, string name = default(string), int operationIndex = 0)
        {
            waf.Client.ApiResponse<WAFDomains200> localVarResponse = GetWAFDomainsWithHttpInfo(wafId, name);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Find domains attached to a WAF 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WAFDomains200</returns>
        public waf.Client.ApiResponse<WAFDomains200> GetWAFDomainsWithHttpInfo(long wafId, string name = default(string), int operationIndex = 0)
        {
            waf.Client.RequestOptions localVarRequestOptions = new waf.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = waf.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = waf.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("wafId", waf.Client.ClientUtils.ParameterToString(wafId)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "name", name));
            }

            localVarRequestOptions.Operation = "WAFApi.GetWAFDomains";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<WAFDomains200>("/waf/{wafId}/domains", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWAFDomains", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Find domains attached to a WAF 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WAFDomains200</returns>
        public async System.Threading.Tasks.Task<WAFDomains200> GetWAFDomainsAsync(long wafId, string name = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            waf.Client.ApiResponse<WAFDomains200> localVarResponse = await GetWAFDomainsWithHttpInfoAsync(wafId, name, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Find domains attached to a WAF 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="name">searches WAF for name (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WAFDomains200)</returns>
        public async System.Threading.Tasks.Task<waf.Client.ApiResponse<WAFDomains200>> GetWAFDomainsWithHttpInfoAsync(long wafId, string name = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            waf.Client.RequestOptions localVarRequestOptions = new waf.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = waf.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = waf.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("wafId", waf.Client.ClientUtils.ParameterToString(wafId)); // path parameter
            if (name != null)
            {
                localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "name", name));
            }

            localVarRequestOptions.Operation = "WAFApi.GetWAFDomains";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<WAFDomains200>("/waf/{wafId}/domains", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWAFDomains", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Find WAF log events 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WAFEvents200</returns>
        public WAFEvents200 GetWAFEvents(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0)
        {
            waf.Client.ApiResponse<WAFEvents200> localVarResponse = GetWAFEventsWithHttpInfo(wafId, hourRange, domainsIds, networkListId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Find WAF log events 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WAFEvents200</returns>
        public waf.Client.ApiResponse<WAFEvents200> GetWAFEventsWithHttpInfo(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0)
        {
            // verify the required parameter 'domainsIds' is set
            if (domainsIds == null)
            {
                throw new waf.Client.ApiException(400, "Missing required parameter 'domainsIds' when calling WAFApi->GetWAFEvents");
            }

            waf.Client.RequestOptions localVarRequestOptions = new waf.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = waf.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = waf.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("wafId", waf.Client.ClientUtils.ParameterToString(wafId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "hour_range", hourRange));
            if (networkListId != null)
            {
                localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "network_list_id", networkListId));
            }
            localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "domains_ids", domainsIds));

            localVarRequestOptions.Operation = "WAFApi.GetWAFEvents";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<WAFEvents200>("/waf/{wafId}/waf_events", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWAFEvents", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Find WAF log events 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WAFEvents200</returns>
        public async System.Threading.Tasks.Task<WAFEvents200> GetWAFEventsAsync(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            waf.Client.ApiResponse<WAFEvents200> localVarResponse = await GetWAFEventsWithHttpInfoAsync(wafId, hourRange, domainsIds, networkListId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Find WAF log events 
        /// </summary>
        /// <exception cref="waf.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="wafId">ID of WAF to return</param>
        /// <param name="hourRange">Last log hours since now (it must be a integer number ranging between 1 and 72)</param>
        /// <param name="domainsIds">Multiple domain&#39;s id (they must be separated by comma like 1233,1234)</param>
        /// <param name="networkListId">Id of a network list (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WAFEvents200)</returns>
        public async System.Threading.Tasks.Task<waf.Client.ApiResponse<WAFEvents200>> GetWAFEventsWithHttpInfoAsync(long wafId, long hourRange, string domainsIds, long? networkListId = default(long?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'domainsIds' is set
            if (domainsIds == null)
            {
                throw new waf.Client.ApiException(400, "Missing required parameter 'domainsIds' when calling WAFApi->GetWAFEvents");
            }


            waf.Client.RequestOptions localVarRequestOptions = new waf.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json; version=3"
            };

            var localVarContentType = waf.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = waf.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("wafId", waf.Client.ClientUtils.ParameterToString(wafId)); // path parameter
            localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "hour_range", hourRange));
            if (networkListId != null)
            {
                localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "network_list_id", networkListId));
            }
            localVarRequestOptions.QueryParameters.Add(waf.Client.ClientUtils.ParameterToMultiMap("", "domains_ids", domainsIds));

            localVarRequestOptions.Operation = "WAFApi.GetWAFEvents";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (tokenAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<WAFEvents200>("/waf/{wafId}/waf_events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWAFEvents", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
