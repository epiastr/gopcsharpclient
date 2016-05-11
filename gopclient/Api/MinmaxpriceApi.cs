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
    public interface IMinmaxpriceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List
        /// </summary>
        /// <remarks>
        /// This service returns all minimum and maximum price information.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>MinMaxPriceListServiceResponse</returns>
        MinMaxPriceListServiceResponse Minmaxpricelistall (string gopServiceTicket);
  
        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List
        /// </summary>
        /// <remarks>
        /// This service returns all minimum and maximum price information.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of MinMaxPriceListServiceResponse</returns>
        ApiResponse<MinMaxPriceListServiceResponse> MinmaxpricelistallWithHttpInfo (string gopServiceTicket);
        
        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service
        /// </summary>
        /// <remarks>
        /// This service returns minimum and maximum prices for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>MinMaxPriceServiceResponse</returns>
        MinMaxPriceServiceResponse Minmaxpricelisteffective (ServiceMinMaxPriceListRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service
        /// </summary>
        /// <remarks>
        /// This service returns minimum and maximum prices for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of MinMaxPriceServiceResponse</returns>
        ApiResponse<MinMaxPriceServiceResponse> MinmaxpricelisteffectiveWithHttpInfo (ServiceMinMaxPriceListRequest body, string gopServiceTicket);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List
        /// </summary>
        /// <remarks>
        /// This service returns all minimum and maximum price information.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of MinMaxPriceListServiceResponse</returns>
        System.Threading.Tasks.Task<MinMaxPriceListServiceResponse> MinmaxpricelistallAsync (string gopServiceTicket);

        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List
        /// </summary>
        /// <remarks>
        /// This service returns all minimum and maximum price information.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (MinMaxPriceListServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MinMaxPriceListServiceResponse>> MinmaxpricelistallAsyncWithHttpInfo (string gopServiceTicket);
        
        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service
        /// </summary>
        /// <remarks>
        /// This service returns minimum and maximum prices for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of MinMaxPriceServiceResponse</returns>
        System.Threading.Tasks.Task<MinMaxPriceServiceResponse> MinmaxpricelisteffectiveAsync (ServiceMinMaxPriceListRequest body, string gopServiceTicket);

        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service
        /// </summary>
        /// <remarks>
        /// This service returns minimum and maximum prices for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (MinMaxPriceServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MinMaxPriceServiceResponse>> MinmaxpricelisteffectiveAsyncWithHttpInfo (ServiceMinMaxPriceListRequest body, string gopServiceTicket);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MinmaxpriceApi : IMinmaxpriceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinmaxpriceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MinmaxpriceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MinmaxpriceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MinmaxpriceApi(Configuration configuration = null)
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
        /// Mininimum Maximum / Offer Price / All / List This service returns all minimum and maximum price information.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>MinMaxPriceListServiceResponse</returns>
        public MinMaxPriceListServiceResponse Minmaxpricelistall (string gopServiceTicket)
        {
             ApiResponse<MinMaxPriceListServiceResponse> localVarResponse = MinmaxpricelistallWithHttpInfo(gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List This service returns all minimum and maximum price information.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of MinMaxPriceListServiceResponse</returns>
        public ApiResponse< MinMaxPriceListServiceResponse > MinmaxpricelistallWithHttpInfo (string gopServiceTicket)
        {
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling MinmaxpriceApi->Minmaxpricelistall");
            
    
            var localVarPath = "/minmaxprice/list/all";
    
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
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelistall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelistall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MinMaxPriceListServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MinMaxPriceListServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinMaxPriceListServiceResponse)));
            
        }

        
        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List This service returns all minimum and maximum price information.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of MinMaxPriceListServiceResponse</returns>
        public async System.Threading.Tasks.Task<MinMaxPriceListServiceResponse> MinmaxpricelistallAsync (string gopServiceTicket)
        {
             ApiResponse<MinMaxPriceListServiceResponse> localVarResponse = await MinmaxpricelistallAsyncWithHttpInfo(gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mininimum Maximum / Offer Price / All / List This service returns all minimum and maximum price information.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (MinMaxPriceListServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MinMaxPriceListServiceResponse>> MinmaxpricelistallAsyncWithHttpInfo (string gopServiceTicket)
        {
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Minmaxpricelistall");
            
    
            var localVarPath = "/minmaxprice/list/all";
    
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
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelistall: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelistall: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinMaxPriceListServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MinMaxPriceListServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinMaxPriceListServiceResponse)));
            
        }
        
        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service This service returns minimum and maximum prices for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>MinMaxPriceServiceResponse</returns>
        public MinMaxPriceServiceResponse Minmaxpricelisteffective (ServiceMinMaxPriceListRequest body, string gopServiceTicket)
        {
             ApiResponse<MinMaxPriceServiceResponse> localVarResponse = MinmaxpricelisteffectiveWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service This service returns minimum and maximum prices for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of MinMaxPriceServiceResponse</returns>
        public ApiResponse< MinMaxPriceServiceResponse > MinmaxpricelisteffectiveWithHttpInfo (ServiceMinMaxPriceListRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MinmaxpriceApi->Minmaxpricelisteffective");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling MinmaxpriceApi->Minmaxpricelisteffective");
            
    
            var localVarPath = "/minmaxprice/list/effective";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelisteffective: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelisteffective: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MinMaxPriceServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MinMaxPriceServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinMaxPriceServiceResponse)));
            
        }

        
        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service This service returns minimum and maximum prices for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of MinMaxPriceServiceResponse</returns>
        public async System.Threading.Tasks.Task<MinMaxPriceServiceResponse> MinmaxpricelisteffectiveAsync (ServiceMinMaxPriceListRequest body, string gopServiceTicket)
        {
             ApiResponse<MinMaxPriceServiceResponse> localVarResponse = await MinmaxpricelisteffectiveAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mininimum Maximum / Offer Price / Delivery Day / List Service This service returns minimum and maximum prices for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">MinMax Price List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (MinMaxPriceServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MinMaxPriceServiceResponse>> MinmaxpricelisteffectiveAsyncWithHttpInfo (ServiceMinMaxPriceListRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Minmaxpricelisteffective");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Minmaxpricelisteffective");
            
    
            var localVarPath = "/minmaxprice/list/effective";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelisteffective: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Minmaxpricelisteffective: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MinMaxPriceServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MinMaxPriceServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MinMaxPriceServiceResponse)));
            
        }
        
    }
    
}
