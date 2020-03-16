/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPluginsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>Object</returns>
        Object PluginsPluginsGet (string pluginCode);

        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> PluginsPluginsGetWithHttpInfo (string pluginCode);
        /// <summary>
        /// This call returns the server plugin list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ServerPluginDto&gt;</returns>
        List<ServerPluginDto> PluginsPluginsList ();

        /// <summary>
        /// This call returns the server plugin list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ServerPluginDto&gt;</returns>
        ApiResponse<List<ServerPluginDto>> PluginsPluginsListWithHttpInfo ();
        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Object</returns>
        Object PluginsPluginsPost (string pluginCode, List<KeyValuePairStringString> parameters);

        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> PluginsPluginsPostWithHttpInfo (string pluginCode, List<KeyValuePairStringString> parameters);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> PluginsPluginsGetAsync (string pluginCode);

        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PluginsPluginsGetAsyncWithHttpInfo (string pluginCode);
        /// <summary>
        /// This call returns the server plugin list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ServerPluginDto&gt;</returns>
        System.Threading.Tasks.Task<List<ServerPluginDto>> PluginsPluginsListAsync ();

        /// <summary>
        /// This call returns the server plugin list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ServerPluginDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ServerPluginDto>>> PluginsPluginsListAsyncWithHttpInfo ();
        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> PluginsPluginsPostAsync (string pluginCode, List<KeyValuePairStringString> parameters);

        /// <summary>
        /// This call invokes a server plugin
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PluginsPluginsPostAsyncWithHttpInfo (string pluginCode, List<KeyValuePairStringString> parameters);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PluginsApi : IPluginsApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PluginsApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PluginsApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>Object</returns>
        public Object PluginsPluginsGet (string pluginCode)
        {
             ApiResponse<Object> localVarResponse = PluginsPluginsGetWithHttpInfo(pluginCode);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > PluginsPluginsGetWithHttpInfo (string pluginCode)
        {
            // verify the required parameter 'pluginCode' is set
            if (pluginCode == null)
                throw new ApiException(400, "Missing required parameter 'pluginCode' when calling PluginsApi->PluginsPluginsGet");

            var localVarPath = "/api/Plugins/{pluginCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pluginCode != null) localVarPathParams.Add("pluginCode", this.Configuration.ApiClient.ParameterToString(pluginCode)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PluginsPluginsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> PluginsPluginsGetAsync (string pluginCode)
        {
             ApiResponse<Object> localVarResponse = await PluginsPluginsGetAsyncWithHttpInfo(pluginCode);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PluginsPluginsGetAsyncWithHttpInfo (string pluginCode)
        {
            // verify the required parameter 'pluginCode' is set
            if (pluginCode == null)
                throw new ApiException(400, "Missing required parameter 'pluginCode' when calling PluginsApi->PluginsPluginsGet");

            var localVarPath = "/api/Plugins/{pluginCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pluginCode != null) localVarPathParams.Add("pluginCode", this.Configuration.ApiClient.ParameterToString(pluginCode)); // path parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PluginsPluginsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call returns the server plugin list 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ServerPluginDto&gt;</returns>
        public List<ServerPluginDto> PluginsPluginsList ()
        {
             ApiResponse<List<ServerPluginDto>> localVarResponse = PluginsPluginsListWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call returns the server plugin list 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ServerPluginDto&gt;</returns>
        public ApiResponse< List<ServerPluginDto> > PluginsPluginsListWithHttpInfo ()
        {

            var localVarPath = "/api/Plugins/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PluginsPluginsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ServerPluginDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ServerPluginDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ServerPluginDto>)));
        }

        /// <summary>
        /// This call returns the server plugin list 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ServerPluginDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<ServerPluginDto>> PluginsPluginsListAsync ()
        {
             ApiResponse<List<ServerPluginDto>> localVarResponse = await PluginsPluginsListAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call returns the server plugin list 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ServerPluginDto&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ServerPluginDto>>> PluginsPluginsListAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/Plugins/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PluginsPluginsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ServerPluginDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ServerPluginDto>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ServerPluginDto>)));
        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Object</returns>
        public Object PluginsPluginsPost (string pluginCode, List<KeyValuePairStringString> parameters)
        {
             ApiResponse<Object> localVarResponse = PluginsPluginsPostWithHttpInfo(pluginCode, parameters);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > PluginsPluginsPostWithHttpInfo (string pluginCode, List<KeyValuePairStringString> parameters)
        {
            // verify the required parameter 'pluginCode' is set
            if (pluginCode == null)
                throw new ApiException(400, "Missing required parameter 'pluginCode' when calling PluginsApi->PluginsPluginsPost");
            // verify the required parameter 'parameters' is set
            if (parameters == null)
                throw new ApiException(400, "Missing required parameter 'parameters' when calling PluginsApi->PluginsPluginsPost");

            var localVarPath = "/api/Plugins/{pluginCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pluginCode != null) localVarPathParams.Add("pluginCode", this.Configuration.ApiClient.ParameterToString(pluginCode)); // path parameter
            if (parameters != null && parameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(parameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parameters; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PluginsPluginsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> PluginsPluginsPostAsync (string pluginCode, List<KeyValuePairStringString> parameters)
        {
             ApiResponse<Object> localVarResponse = await PluginsPluginsPostAsyncWithHttpInfo(pluginCode, parameters);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This call invokes a server plugin 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginCode">Identifier of plugin</param>
        /// <param name="parameters">Parameters</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PluginsPluginsPostAsyncWithHttpInfo (string pluginCode, List<KeyValuePairStringString> parameters)
        {
            // verify the required parameter 'pluginCode' is set
            if (pluginCode == null)
                throw new ApiException(400, "Missing required parameter 'pluginCode' when calling PluginsApi->PluginsPluginsPost");
            // verify the required parameter 'parameters' is set
            if (parameters == null)
                throw new ApiException(400, "Missing required parameter 'parameters' when calling PluginsApi->PluginsPluginsPost");

            var localVarPath = "/api/Plugins/{pluginCode}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (pluginCode != null) localVarPathParams.Add("pluginCode", this.Configuration.ApiClient.ParameterToString(pluginCode)); // path parameter
            if (parameters != null && parameters.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(parameters); // http body (model) parameter
            }
            else
            {
                localVarPostBody = parameters; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PluginsPluginsPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
