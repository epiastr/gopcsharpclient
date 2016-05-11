using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using gopclient.Client;
using gopclient.Model;

namespace gopclient.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMarketApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Market Result / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns market result by region
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>OptimizationResultServiceResponse</returns>
        OptimizationResultServiceResponse Marketfinalresults (ServiceQueryFinalResultRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Market Result / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns market result by region
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of OptimizationResultServiceResponse</returns>
        ApiResponse<OptimizationResultServiceResponse> MarketfinalresultsWithHttpInfo (ServiceQueryFinalResultRequest body, string gopServiceTicket);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Market Result / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns market result by region
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of OptimizationResultServiceResponse</returns>
        System.Threading.Tasks.Task<OptimizationResultServiceResponse> MarketfinalresultsAsync (ServiceQueryFinalResultRequest body, string gopServiceTicket);

        /// <summary>
        /// Market Result / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns market result by region
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (OptimizationResultServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptimizationResultServiceResponse>> MarketfinalresultsAsyncWithHttpInfo (ServiceQueryFinalResultRequest body, string gopServiceTicket);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MarketApi : IMarketApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MarketApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MarketApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Market Result / Region / List Service This service returns market result by region
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>OptimizationResultServiceResponse</returns>
        public OptimizationResultServiceResponse Marketfinalresults (ServiceQueryFinalResultRequest body, string gopServiceTicket)
        {
             ApiResponse<OptimizationResultServiceResponse> localVarResponse = MarketfinalresultsWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Market Result / Region / List Service This service returns market result by region
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of OptimizationResultServiceResponse</returns>
        public ApiResponse< OptimizationResultServiceResponse > MarketfinalresultsWithHttpInfo (ServiceQueryFinalResultRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MarketApi->Marketfinalresults");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling MarketApi->Marketfinalresults");
            
    
            var localVarPath = "/market/finalresults";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (gopServiceTicket != null) localVarHeaderParams.Add("gop-service-ticket", Configuration.ApiClient.ParameterToString(gopServiceTicket)); // header parameter
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Marketfinalresults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Marketfinalresults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OptimizationResultServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptimizationResultServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptimizationResultServiceResponse)));
            
        }

        
        /// <summary>
        /// Market Result / Region / List Service This service returns market result by region
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of OptimizationResultServiceResponse</returns>
        public async System.Threading.Tasks.Task<OptimizationResultServiceResponse> MarketfinalresultsAsync (ServiceQueryFinalResultRequest body, string gopServiceTicket)
        {
             ApiResponse<OptimizationResultServiceResponse> localVarResponse = await MarketfinalresultsAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Market Result / Region / List Service This service returns market result by region
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Region Market Result List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (OptimizationResultServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptimizationResultServiceResponse>> MarketfinalresultsAsyncWithHttpInfo (ServiceQueryFinalResultRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Marketfinalresults");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Marketfinalresults");
            
    
            var localVarPath = "/market/finalresults";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            if (gopServiceTicket != null) localVarHeaderParams.Add("gop-service-ticket", Configuration.ApiClient.ParameterToString(gopServiceTicket)); // header parameter
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Marketfinalresults: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Marketfinalresults: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OptimizationResultServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OptimizationResultServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptimizationResultServiceResponse)));
            
        }
        
    }
    
}
