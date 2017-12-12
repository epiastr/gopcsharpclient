using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using gopclient.Client;
using gopclient.Model;
using Model;

namespace gopclient.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationhistoryApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Operation History / Operation History List Service
        /// </summary>
        /// <remarks>
        /// This service lists operation history records.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>List&lt;OperationHistoryResponseServiceResponse&gt;</returns>
        OperationHistoryResponseServiceResponse Operationhistorylist (ServiceOperationHistorySearchRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Operation History / Operation History List Service
        /// </summary>
        /// <remarks>
        /// This service lists operation history records.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of List&lt;OperationHistoryResponseServiceResponse&gt;</returns>
        ApiResponse<OperationHistoryResponseServiceResponse> OperationhistorylistWithHttpInfo (ServiceOperationHistorySearchRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Operation History / Operation Code List Service
        /// </summary>
        /// <remarks>
        /// This service returns available operations for query.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param>
        /// <returns>ParameterQueryServiceResponse</returns>
        ParameterQueryServiceResponse Operationhistoryoperationcodes(ServiceObject body, string casticket);
  
        /// <summary>
        /// Operation History / Operation Code List Service
        /// </summary>
        /// <remarks>
        /// This service returns available operations for query.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param>
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        ApiResponse<ParameterQueryServiceResponse> OperationhistoryoperationcodesWithHttpInfo(ServiceObject body, string casticket);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Operation History / Operation History List Service
        /// </summary>
        /// <remarks>
        /// This service lists operation history records.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of List&lt;OperationHistoryResponseServiceResponse&gt;</returns>
        System.Threading.Tasks.Task<List<OperationHistoryResponseServiceResponse>> OperationhistorylistAsync (ServiceOperationHistorySearchRequest body, string gopServiceTicket);

        /// <summary>
        /// Operation History / Operation History List Service
        /// </summary>
        /// <remarks>
        /// This service lists operation history records.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (List&lt;OperationHistoryResponseServiceResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OperationHistoryResponseServiceResponse>>> OperationhistorylistAsyncWithHttpInfo (ServiceOperationHistorySearchRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Operation History / Operation Code List Service
        /// </summary>
        /// <remarks>
        /// This service returns available operations for query.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        System.Threading.Tasks.Task<ParameterQueryServiceResponse> OperationhistoryoperationcodesAsync (ServiceObject body = null);

        /// <summary>
        /// Operation History / Operation Code List Service
        /// </summary>
        /// <remarks>
        /// This service returns available operations for query.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> OperationhistoryoperationcodesAsyncWithHttpInfo (ServiceObject body = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OperationhistoryApi : IOperationhistoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationhistoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationhistoryApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationhistoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperationhistoryApi(Configuration configuration = null)
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
        /// Operation History / Operation History List Service This service lists operation history records.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>List&lt;OperationHistoryResponseServiceResponse&gt;</returns>
        public OperationHistoryResponseServiceResponse Operationhistorylist (ServiceOperationHistorySearchRequest body, string gopServiceTicket)
        {
             ApiResponse<OperationHistoryResponseServiceResponse> localVarResponse = OperationhistorylistWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Operation History / Operation History List Service This service lists operation history records.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of List&lt;OperationHistoryResponseServiceResponse&gt;</returns>
        public ApiResponse<OperationHistoryResponseServiceResponse> OperationhistorylistWithHttpInfo (ServiceOperationHistorySearchRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OperationhistoryApi->Operationhistorylist");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OperationhistoryApi->Operationhistorylist");

            var localVarPath = "/operationhistory/list";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] { };

            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[]
            {
                "application/json", "application/xml"
            };

            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (gopServiceTicket != null)
                localVarHeaderParams.Add("gop-service-ticket", Configuration.ApiClient.ParameterToString(gopServiceTicket)); // header parameter
                        
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(
                localVarPath, 
                Method.POST, 
                localVarQueryParams, 
                localVarPostBody, 
                localVarHeaderParams, 
                localVarFormParams, 
                localVarFileParams,
                localVarPathParams, 
                localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Operationhistorylist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Operationhistorylist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            var headers = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());
            var queryResponse = (OperationHistoryResponseServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperationHistoryResponseServiceResponse));

            return new ApiResponse<OperationHistoryResponseServiceResponse>(localVarStatusCode, headers, queryResponse);
        }

        
        /// <summary>
        /// Operation History / Operation History List Service This service lists operation history records.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of List&lt;OperationHistoryResponseServiceResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<OperationHistoryResponseServiceResponse>> OperationhistorylistAsync (ServiceOperationHistorySearchRequest body, string gopServiceTicket)
        {
             ApiResponse<List<OperationHistoryResponseServiceResponse>> localVarResponse = await OperationhistorylistAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Operation History / Operation History List Service This service lists operation history records.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation History Query Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (List&lt;OperationHistoryResponseServiceResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OperationHistoryResponseServiceResponse>>> OperationhistorylistAsyncWithHttpInfo (ServiceOperationHistorySearchRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Operationhistorylist");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Operationhistorylist");
            
    
            var localVarPath = "/operationhistory/list";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Operationhistorylist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Operationhistorylist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OperationHistoryResponseServiceResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OperationHistoryResponseServiceResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OperationHistoryResponseServiceResponse>)));
            
        }
        
        /// <summary>
        /// Operation History / Operation Code List Service This service returns available operations for query.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param> 
        /// <returns>ParameterQueryServiceResponse</returns>
        public ParameterQueryServiceResponse Operationhistoryoperationcodes(ServiceObject body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = OperationhistoryoperationcodesWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Operation History / Operation Code List Service This service returns available operations for query.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param> 
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        public ApiResponse<ParameterQueryServiceResponse> OperationhistoryoperationcodesWithHttpInfo(ServiceObject body, string gopServiceTicket)
        {
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlisthistoryflexible");

            var localVarPath = "/operationhistory/operationcodes";
    
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

            if (gopServiceTicket != null)
                localVarHeaderParams.Add("gop-service-ticket", Configuration.ApiClient.ParameterToString(gopServiceTicket)); // header parameter


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
                throw new ApiException (localVarStatusCode, "Error calling Operationhistoryoperationcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Operationhistoryoperationcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }

        
        /// <summary>
        /// Operation History / Operation Code List Service This service returns available operations for query.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        public async System.Threading.Tasks.Task<ParameterQueryServiceResponse> OperationhistoryoperationcodesAsync (ServiceObject body = null)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = await OperationhistoryoperationcodesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Operation History / Operation Code List Service This service returns available operations for query.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Operation Code List Request (optional)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> OperationhistoryoperationcodesAsyncWithHttpInfo (ServiceObject body = null)
        {
            
    
            var localVarPath = "/operationhistory/operationcodes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Operationhistoryoperationcodes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Operationhistoryoperationcodes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }

        public GateOperationServiceResponse ListGateOperations(ServiceGateOperationRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OperationHistoryApi->ListGateOperations");

            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OperationHistoryApi->ListGateOperations");
            
            var localVarPath = "/gate/operation/active";

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
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling ListGateOperations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling ListGateOperations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            var apiResponse = new ApiResponse<GateOperationServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GateOperationServiceResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(GateOperationServiceResponse)));


            return apiResponse.Data;
        }
    }
    
}
