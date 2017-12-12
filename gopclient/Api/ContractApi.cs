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
    public interface IContractApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Bilateral Agreements / Create Service
        /// </summary>
        /// <remarks>
        /// This service creates billateral agreements.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ContractServiceResponse</returns>
        ContractServiceResponse Contractcreate (ServiceContractRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / Create Service
        /// </summary>
        /// <remarks>
        /// This service creates billateral agreements.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        ApiResponse<ContractServiceResponse> ContractcreateWithHttpInfo (ServiceContractRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Cancel Service
        /// </summary>
        /// <remarks>
        /// This service cancels billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ContractServiceResponse</returns>
        ContractServiceResponse Contractdelete (ServiceQueryContractListRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / Cancel Service
        /// </summary>
        /// <remarks>
        /// This service cancels billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        ApiResponse<ContractServiceResponse> ContractdeleteWithHttpInfo (ServiceQueryContractListRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / List Service
        /// </summary>
        /// <remarks>
        /// This service lists billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ContractServiceResponse</returns>
        ContractServiceResponse Contractlist (ServiceQueryContractRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / List Service
        /// </summary>
        /// <remarks>
        /// This service lists billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        ApiResponse<ContractServiceResponse> ContractlistWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Status / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available statuses.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>List&lt;QueryContractStatusResponse&gt;</returns>
        List<QueryContractStatusResponse> Contractlistcontractstatuses (Service body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / Status / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available statuses.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of List&lt;QueryContractStatusResponse&gt;</returns>
        ApiResponse<List<QueryContractStatusResponse>> ContractlistcontractstatusesWithHttpInfo (Service body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / History / List Service
        /// </summary>
        /// <remarks>
        /// This service lists history of given billateral agreement.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ContractServiceResponse</returns>
        ContractServiceResponse Contractlisthistory (ServiceQueryContractRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / History / List Service
        /// </summary>
        /// <remarks>
        /// This service lists history of given billateral agreement.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        ApiResponse<ContractServiceResponse> ContractlisthistoryWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Period List Service
        /// </summary>
        /// <remarks>
        /// This service lists periods given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryContractPeriodServiceResponse</returns>
        QueryContractPeriodServiceResponse Contractlisthourblocks (ServiceQueryContractPeriodRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / Period List Service
        /// </summary>
        /// <remarks>
        /// This service lists periods given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryContractPeriodServiceResponse</returns>
        ApiResponse<QueryContractPeriodServiceResponse> ContractlisthourblocksWithHttpInfo (ServiceQueryContractPeriodRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Organization / List Service
        /// </summary>
        /// <remarks>
        /// This service returns billateral agreement organization list.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param>
        /// <returns>OrganizationServiceResponse</returns>
        OrganizationServiceResponse Contractorganizationlist (ServiceContractOrganizationRequest body, string ticket);
  
        /// <summary>
        /// Bilateral Agreements / Organization / List Service
        /// </summary>
        /// <remarks>
        /// This service returns billateral agreement organization list.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param>
        /// <returns>ApiResponse of OrganizationServiceResponse</returns>
        ApiResponse<OrganizationServiceResponse> ContractorganizationlistWithHttpInfo (ServiceContractOrganizationRequest body, string ticket);
        
        /// <summary>
        /// Bilateral Agreements / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ParameterQueryServiceResponse</returns>
        ParameterQueryServiceResponse Contractregions (ServiceRegionRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        ApiResponse<ParameterQueryServiceResponse> ContractregionsWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service
        /// </summary>
        /// <remarks>
        /// Validates given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>BooleanServiceResponse</returns>
        BooleanServiceResponse Contractvalidatedeliveryday (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service
        /// </summary>
        /// <remarks>
        /// Validates given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of BooleanServiceResponse</returns>
        ApiResponse<BooleanServiceResponse> ContractvalidatedeliverydayWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Bilateral Agreements / Create Service
        /// </summary>
        /// <remarks>
        /// This service creates billateral agreements.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        System.Threading.Tasks.Task<ContractServiceResponse> ContractcreateAsync (ServiceContractRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / Create Service
        /// </summary>
        /// <remarks>
        /// This service creates billateral agreements.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractcreateAsyncWithHttpInfo (ServiceContractRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Cancel Service
        /// </summary>
        /// <remarks>
        /// This service cancels billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        System.Threading.Tasks.Task<ContractServiceResponse> ContractdeleteAsync (ServiceQueryContractListRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / Cancel Service
        /// </summary>
        /// <remarks>
        /// This service cancels billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractdeleteAsyncWithHttpInfo (ServiceQueryContractListRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / List Service
        /// </summary>
        /// <remarks>
        /// This service lists billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        System.Threading.Tasks.Task<ContractServiceResponse> ContractlistAsync (ServiceQueryContractRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / List Service
        /// </summary>
        /// <remarks>
        /// This service lists billateral agreements
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractlistAsyncWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Status / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available statuses.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of List&lt;QueryContractStatusResponse&gt;</returns>
        System.Threading.Tasks.Task<List<QueryContractStatusResponse>> ContractlistcontractstatusesAsync (Service body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / Status / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available statuses.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (List&lt;QueryContractStatusResponse&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<QueryContractStatusResponse>>> ContractlistcontractstatusesAsyncWithHttpInfo (Service body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / History / List Service
        /// </summary>
        /// <remarks>
        /// This service lists history of given billateral agreement.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        System.Threading.Tasks.Task<ContractServiceResponse> ContractlisthistoryAsync (ServiceQueryContractRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / History / List Service
        /// </summary>
        /// <remarks>
        /// This service lists history of given billateral agreement.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractlisthistoryAsyncWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Period List Service
        /// </summary>
        /// <remarks>
        /// This service lists periods given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryContractPeriodServiceResponse</returns>
        System.Threading.Tasks.Task<QueryContractPeriodServiceResponse> ContractlisthourblocksAsync (ServiceQueryContractPeriodRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / Period List Service
        /// </summary>
        /// <remarks>
        /// This service lists periods given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryContractPeriodServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryContractPeriodServiceResponse>> ContractlisthourblocksAsyncWithHttpInfo (ServiceQueryContractPeriodRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Organization / List Service
        /// </summary>
        /// <remarks>
        /// This service returns billateral agreement organization list.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param>
        /// <returns>Task of OrganizationServiceResponse</returns>
        System.Threading.Tasks.Task<OrganizationServiceResponse> ContractorganizationlistAsync (ServiceContractOrganizationRequest body);

        /// <summary>
        /// Bilateral Agreements / Organization / List Service
        /// </summary>
        /// <remarks>
        /// This service returns billateral agreement organization list.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param>
        /// <returns>Task of ApiResponse (OrganizationServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrganizationServiceResponse>> ContractorganizationlistAsyncWithHttpInfo (ServiceContractOrganizationRequest body);
        
        /// <summary>
        /// Bilateral Agreements / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        System.Threading.Tasks.Task<ParameterQueryServiceResponse> ContractregionsAsync (ServiceRegionRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / Region / List Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> ContractregionsAsyncWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service
        /// </summary>
        /// <remarks>
        /// Validates given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of BooleanServiceResponse</returns>
        System.Threading.Tasks.Task<BooleanServiceResponse> ContractvalidatedeliverydayAsync (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);

        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service
        /// </summary>
        /// <remarks>
        /// Validates given date.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (BooleanServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanServiceResponse>> ContractvalidatedeliverydayAsyncWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);
        
        #endregion Asynchronous Operations
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContractApi : IContractApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContractApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ContractApi(Configuration configuration = null)
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
        /// Bilateral Agreements / Create Service This service creates billateral agreements.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ContractServiceResponse</returns>
        public ContractServiceResponse Contractcreate (ServiceContractRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = ContractcreateWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Create Service This service creates billateral agreements.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        public ApiResponse< ContractServiceResponse > ContractcreateWithHttpInfo (ServiceContractRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractcreate");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractcreate");
            
    
            var localVarPath = "/contract/create";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractcreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractcreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Create Service This service creates billateral agreements.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        public async System.Threading.Tasks.Task<ContractServiceResponse> ContractcreateAsync (ServiceContractRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = await ContractcreateAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Create Service This service creates billateral agreements.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Create Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractcreateAsyncWithHttpInfo (ServiceContractRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractcreate");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractcreate");
            
    
            var localVarPath = "/contract/create";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractcreate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractcreate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / Cancel Service This service cancels billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ContractServiceResponse</returns>
        public ContractServiceResponse Contractdelete (ServiceQueryContractListRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = ContractdeleteWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Cancel Service This service cancels billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        public ApiResponse< ContractServiceResponse > ContractdeleteWithHttpInfo (ServiceQueryContractListRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractdelete");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractdelete");
            
    
            var localVarPath = "/contract/delete";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractdelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractdelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Cancel Service This service cancels billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        public async System.Threading.Tasks.Task<ContractServiceResponse> ContractdeleteAsync (ServiceQueryContractListRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = await ContractdeleteAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Cancel Service This service cancels billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Cancel Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractdeleteAsyncWithHttpInfo (ServiceQueryContractListRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractdelete");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractdelete");
            
    
            var localVarPath = "/contract/delete";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractdelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractdelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / List Service This service lists billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ContractServiceResponse</returns>
        public ContractServiceResponse Contractlist (ServiceQueryContractRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = ContractlistWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / List Service This service lists billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        public ApiResponse< ContractServiceResponse > ContractlistWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractlist");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractlist");
            
    
            var localVarPath = "/contract/list";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / List Service This service lists billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        public async System.Threading.Tasks.Task<ContractServiceResponse> ContractlistAsync (ServiceQueryContractRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = await ContractlistAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / List Service This service lists billateral agreements
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractlistAsyncWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractlist");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractlist");
            
    
            var localVarPath = "/contract/list";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / Status / List Service This service returns available statuses.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>List&lt;QueryContractStatusResponse&gt;</returns>
        public List<QueryContractStatusResponse> Contractlistcontractstatuses (Service body, string gopServiceTicket)
        {
             ApiResponse<List<QueryContractStatusResponse>> localVarResponse = ContractlistcontractstatusesWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Status / List Service This service returns available statuses.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of List&lt;QueryContractStatusResponse&gt;</returns>
        public ApiResponse< List<QueryContractStatusResponse> > ContractlistcontractstatusesWithHttpInfo (Service body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractlistcontractstatuses");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractlistcontractstatuses");
            
    
            var localVarPath = "/contract/listcontractstatuses";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlistcontractstatuses: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlistcontractstatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<QueryContractStatusResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<QueryContractStatusResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<QueryContractStatusResponse>)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Status / List Service This service returns available statuses.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of List&lt;QueryContractStatusResponse&gt;</returns>
        public async System.Threading.Tasks.Task<List<QueryContractStatusResponse>> ContractlistcontractstatusesAsync (Service body, string gopServiceTicket)
        {
             ApiResponse<List<QueryContractStatusResponse>> localVarResponse = await ContractlistcontractstatusesAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Status / List Service This service returns available statuses.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Status List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (List&lt;QueryContractStatusResponse&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<QueryContractStatusResponse>>> ContractlistcontractstatusesAsyncWithHttpInfo (Service body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractlistcontractstatuses");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractlistcontractstatuses");
            
    
            var localVarPath = "/contract/listcontractstatuses";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlistcontractstatuses: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlistcontractstatuses: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<QueryContractStatusResponse>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<QueryContractStatusResponse>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<QueryContractStatusResponse>)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / History / List Service This service lists history of given billateral agreement.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ContractServiceResponse</returns>
        public ContractServiceResponse Contractlisthistory (ServiceQueryContractRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = ContractlisthistoryWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / History / List Service This service lists history of given billateral agreement.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ContractServiceResponse</returns>
        public ApiResponse< ContractServiceResponse > ContractlisthistoryWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractlisthistory");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractlisthistory");
            
    
            var localVarPath = "/contract/list/history";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / History / List Service This service lists history of given billateral agreement.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ContractServiceResponse</returns>
        public async System.Threading.Tasks.Task<ContractServiceResponse> ContractlisthistoryAsync (ServiceQueryContractRequest body, string gopServiceTicket)
        {
             ApiResponse<ContractServiceResponse> localVarResponse = await ContractlisthistoryAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / History / List Service This service lists history of given billateral agreement.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements History List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ContractServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ContractServiceResponse>> ContractlisthistoryAsyncWithHttpInfo (ServiceQueryContractRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractlisthistory");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractlisthistory");
            
    
            var localVarPath = "/contract/list/history";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthistory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthistory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ContractServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ContractServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ContractServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / Period List Service This service lists periods given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryContractPeriodServiceResponse</returns>
        public QueryContractPeriodServiceResponse Contractlisthourblocks (ServiceQueryContractPeriodRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryContractPeriodServiceResponse> localVarResponse = ContractlisthourblocksWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Period List Service This service lists periods given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryContractPeriodServiceResponse</returns>
        public ApiResponse< QueryContractPeriodServiceResponse > ContractlisthourblocksWithHttpInfo (ServiceQueryContractPeriodRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractlisthourblocks");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractlisthourblocks");
            
    
            var localVarPath = "/contract/listhourblocks";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthourblocks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthourblocks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryContractPeriodServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryContractPeriodServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryContractPeriodServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Period List Service This service lists periods given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryContractPeriodServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryContractPeriodServiceResponse> ContractlisthourblocksAsync (ServiceQueryContractPeriodRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryContractPeriodServiceResponse> localVarResponse = await ContractlisthourblocksAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Period List Service This service lists periods given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryContractPeriodServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryContractPeriodServiceResponse>> ContractlisthourblocksAsyncWithHttpInfo (ServiceQueryContractPeriodRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractlisthourblocks");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractlisthourblocks");
            
    
            var localVarPath = "/contract/listhourblocks";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthourblocks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractlisthourblocks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryContractPeriodServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryContractPeriodServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryContractPeriodServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / Organization / List Service This service returns billateral agreement organization list.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param> 
        /// <returns>OrganizationServiceResponse</returns>
        public OrganizationServiceResponse Contractorganizationlist (ServiceContractOrganizationRequest body, string gopServiceTicket)
        {
             ApiResponse<OrganizationServiceResponse> localVarResponse = ContractorganizationlistWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Organization / List Service This service returns billateral agreement organization list.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param> 
        /// <returns>ApiResponse of OrganizationServiceResponse</returns>
        public ApiResponse<OrganizationServiceResponse> ContractorganizationlistWithHttpInfo(ServiceContractOrganizationRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractorganizationlistWithHttpInfo");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractorganizationlist");
            
    
            var localVarPath = "/contract/organization/list";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractorganizationlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractorganizationlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrganizationServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Organization / List Service This service returns billateral agreement organization list.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param>
        /// <returns>Task of OrganizationServiceResponse</returns>
        public async System.Threading.Tasks.Task<OrganizationServiceResponse> ContractorganizationlistAsync (ServiceContractOrganizationRequest body)
        {
             ApiResponse<OrganizationServiceResponse> localVarResponse = await ContractorganizationlistAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Organization / List Service This service returns billateral agreement organization list.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Organization List Request</param>
        /// <returns>Task of ApiResponse (OrganizationServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrganizationServiceResponse>> ContractorganizationlistAsyncWithHttpInfo (ServiceContractOrganizationRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractorganizationlist");
            
    
            var localVarPath = "/contract/organization/list";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractorganizationlist: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractorganizationlist: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrganizationServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrganizationServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrganizationServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / Region / List Service This service returns available regions.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ParameterQueryServiceResponse</returns>
        public ParameterQueryServiceResponse Contractregions (ServiceRegionRequest body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = ContractregionsWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Region / List Service This service returns available regions.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        public ApiResponse< ParameterQueryServiceResponse > ContractregionsWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractregions");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractregions");
            
    
            var localVarPath = "/contract/regions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractregions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Region / List Service This service returns available regions.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        public async System.Threading.Tasks.Task<ParameterQueryServiceResponse> ContractregionsAsync (ServiceRegionRequest body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = await ContractregionsAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Region / List Service This service returns available regions.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> ContractregionsAsyncWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractregions");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractregions");
            
    
            var localVarPath = "/contract/regions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractregions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }
        
        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service Validates given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>BooleanServiceResponse</returns>
        public BooleanServiceResponse Contractvalidatedeliveryday (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
             ApiResponse<BooleanServiceResponse> localVarResponse = ContractvalidatedeliverydayWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service Validates given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of BooleanServiceResponse</returns>
        public ApiResponse< BooleanServiceResponse > ContractvalidatedeliverydayWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ContractApi->Contractvalidatedeliveryday");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling ContractApi->Contractvalidatedeliveryday");
            
    
            var localVarPath = "/contract/validatedeliveryday";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractvalidatedeliveryday: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractvalidatedeliveryday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BooleanServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BooleanServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BooleanServiceResponse)));
            
        }

        
        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service Validates given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of BooleanServiceResponse</returns>
        public async System.Threading.Tasks.Task<BooleanServiceResponse> ContractvalidatedeliverydayAsync (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
             ApiResponse<BooleanServiceResponse> localVarResponse = await ContractvalidatedeliverydayAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Bilateral Agreements / Delivery Day Validation Service Validates given date.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Bilateral Agreements Delivery Day Validation Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (BooleanServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanServiceResponse>> ContractvalidatedeliverydayAsyncWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Contractvalidatedeliveryday");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Contractvalidatedeliveryday");
            
    
            var localVarPath = "/contract/validatedeliveryday";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Contractvalidatedeliveryday: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Contractvalidatedeliveryday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BooleanServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BooleanServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BooleanServiceResponse)));
            
        }
        
    }
    
}
