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
    public interface IOfferApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Offer / Advance Service
        /// </summary>
        /// <remarks>
        /// This service returns required advances for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>AdvanceResultServiceResponse</returns>
        AdvanceResultServiceResponse Offeradvance (ServiceAdvanceResultRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Advance Service
        /// </summary>
        /// <remarks>
        /// This service returns required advances for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of AdvanceResultServiceResponse</returns>
        ApiResponse<AdvanceResultServiceResponse> OfferadvanceWithHttpInfo (ServiceAdvanceResultRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Create / Block Service
        /// </summary>
        /// <remarks>
        /// This service creates block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offercreateblock (ServiceOfferRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Create / Block Service
        /// </summary>
        /// <remarks>
        /// This service creates block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OffercreateblockWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Create / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service creates flexible offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offercreateflexible (ServiceOfferRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Create / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service creates flexible offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OffercreateflexibleWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Create / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service creates hourly offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offercreatehourly (ServiceOfferRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Create / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service creates hourly offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OffercreatehourlyWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Currency Service
        /// </summary>
        /// <remarks>
        /// This service returns available currencies for offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ParameterQueryServiceResponse</returns>
        ParameterQueryServiceResponse Offercurrencies (ServiceCurrencyRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Currency Service
        /// </summary>
        /// <remarks>
        /// This service returns available currencies for offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        ApiResponse<ParameterQueryServiceResponse> OffercurrenciesWithHttpInfo (ServiceCurrencyRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Cancel / Block Service
        /// </summary>
        /// <remarks>
        /// This service cancels given block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Block Offer Cancel Request (optional)</param>
        /// <returns>DeleteOfferServiceResponse</returns>
        DeleteOfferServiceResponse Offerdeleteblock (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
  
        /// <summary>
        /// Offer / Cancel / Block Service
        /// </summary>
        /// <remarks>
        /// This service cancels given block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Block Offer Cancel Request (optional)</param>
        /// <returns>ApiResponse of DeleteOfferServiceResponse</returns>
        ApiResponse<DeleteOfferServiceResponse> OfferdeleteblockWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
        
        /// <summary>
        /// Offer / Cancel / Flexible Service
        /// </summary>
        /// <remarks>
        /// Bu servis esnek teklifleri siler.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Flexible Offer Cancel Request (optional)</param>
        /// <returns>DeleteOfferServiceResponse</returns>
        DeleteOfferServiceResponse Offerdeleteflexible (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
  
        /// <summary>
        /// Offer / Cancel / Flexible Service
        /// </summary>
        /// <remarks>
        /// Bu servis esnek teklifleri siler.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Flexible Offer Cancel Request (optional)</param>
        /// <returns>ApiResponse of DeleteOfferServiceResponse</returns>
        ApiResponse<DeleteOfferServiceResponse> OfferdeleteflexibleWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
        
        /// <summary>
        /// Offer / Cancel / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service cancels given hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Hourly Offer Cancel Request (optional)</param>
        /// <returns>DeleteOfferServiceResponse</returns>
        DeleteOfferServiceResponse Offerdeletehourly (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
  
        /// <summary>
        /// Offer / Cancel / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service cancels given hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Hourly Offer Cancel Request (optional)</param>
        /// <returns>ApiResponse of DeleteOfferServiceResponse</returns>
        ApiResponse<DeleteOfferServiceResponse> OfferdeletehourlyWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
        
        /// <summary>
        /// Offer / List / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offerlistblock (ServiceQueryOfferRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / List / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OfferlistblockWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists flexible offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offerlistflexible (ServiceQueryOfferRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / List / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists flexible offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OfferlistflexibleWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / History / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists history of block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offerlisthistoryblock (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / List / History / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists history of block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OfferlisthistoryblockWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / History / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists history of flexible offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offerlisthistoryflexible (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / List / History / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists history of flexible offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OfferlisthistoryflexibleWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / History / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists history of hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offerlisthistoryhourly (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / List / History / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists history of hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OfferlisthistoryhourlyWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Period Hours List Service
        /// </summary>
        /// <remarks>
        /// This service returns periods for deliveryday and offer type.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferHourBlockServiceResponse</returns>
        QueryOfferHourBlockServiceResponse Offerlisthourblocks (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Period Hours List Service
        /// </summary>
        /// <remarks>
        /// This service returns periods for deliveryday and offer type.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferHourBlockServiceResponse</returns>
        ApiResponse<QueryOfferHourBlockServiceResponse> OfferlisthourblocksWithHttpInfo (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists hourly offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferServiceResponse</returns>
        QueryOfferServiceResponse Offerlisthourly (ServiceQueryOfferRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / List / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists hourly offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        ApiResponse<QueryOfferServiceResponse> OfferlisthourlyWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Market Result Service
        /// </summary>
        /// <remarks>
        /// This service returns market results , market clearing price vs.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>QueryOfferResultServiceResponse</returns>
        QueryOfferResultServiceResponse Offerofferresult (ServiceOfferResultRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Market Result Service
        /// </summary>
        /// <remarks>
        /// This service returns market results , market clearing price vs.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of QueryOfferResultServiceResponse</returns>
        ApiResponse<QueryOfferResultServiceResponse> OfferofferresultWithHttpInfo (ServiceOfferResultRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Region Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions for offer
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ParameterQueryServiceResponse</returns>
        ParameterQueryServiceResponse Offerregions (ServiceRegionRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Region Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions for offer
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        ApiResponse<ParameterQueryServiceResponse> OfferregionsWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Delivery Day Val?dation Service
        /// </summary>
        /// <remarks>
        /// Validates given delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>BooleanServiceResponse</returns>
        BooleanServiceResponse Offervalidatedeliveryday (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);
  
        /// <summary>
        /// Offer / Delivery Day Val?dation Service
        /// </summary>
        /// <remarks>
        /// Validates given delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>ApiResponse of BooleanServiceResponse</returns>
        ApiResponse<BooleanServiceResponse> OffervalidatedeliverydayWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Offer / Advance Service
        /// </summary>
        /// <remarks>
        /// This service returns required advances for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of AdvanceResultServiceResponse</returns>
        System.Threading.Tasks.Task<AdvanceResultServiceResponse> OfferadvanceAsync (ServiceAdvanceResultRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Advance Service
        /// </summary>
        /// <remarks>
        /// This service returns required advances for delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (AdvanceResultServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdvanceResultServiceResponse>> OfferadvanceAsyncWithHttpInfo (ServiceAdvanceResultRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Create / Block Service
        /// </summary>
        /// <remarks>
        /// This service creates block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OffercreateblockAsync (ServiceOfferRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Create / Block Service
        /// </summary>
        /// <remarks>
        /// This service creates block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OffercreateblockAsyncWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Create / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service creates flexible offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OffercreateflexibleAsync (ServiceOfferRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Create / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service creates flexible offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OffercreateflexibleAsyncWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Create / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service creates hourly offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OffercreatehourlyAsync (ServiceOfferRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Create / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service creates hourly offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OffercreatehourlyAsyncWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Currency Service
        /// </summary>
        /// <remarks>
        /// This service returns available currencies for offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        System.Threading.Tasks.Task<ParameterQueryServiceResponse> OffercurrenciesAsync (ServiceCurrencyRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Currency Service
        /// </summary>
        /// <remarks>
        /// This service returns available currencies for offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> OffercurrenciesAsyncWithHttpInfo (ServiceCurrencyRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Cancel / Block Service
        /// </summary>
        /// <remarks>
        /// This service cancels given block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Block Offer Cancel Request (optional)</param>
        /// <returns>Task of DeleteOfferServiceResponse</returns>
        System.Threading.Tasks.Task<DeleteOfferServiceResponse> OfferdeleteblockAsync (string gopServiceTicket, ServiceDeleteOfferRequest body = null);

        /// <summary>
        /// Offer / Cancel / Block Service
        /// </summary>
        /// <remarks>
        /// This service cancels given block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Block Offer Cancel Request (optional)</param>
        /// <returns>Task of ApiResponse (DeleteOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteOfferServiceResponse>> OfferdeleteblockAsyncWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
        
        /// <summary>
        /// Offer / Cancel / Flexible Service
        /// </summary>
        /// <remarks>
        /// Bu servis esnek teklifleri siler.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Flexible Offer Cancel Request (optional)</param>
        /// <returns>Task of DeleteOfferServiceResponse</returns>
        System.Threading.Tasks.Task<DeleteOfferServiceResponse> OfferdeleteflexibleAsync (string gopServiceTicket, ServiceDeleteOfferRequest body = null);

        /// <summary>
        /// Offer / Cancel / Flexible Service
        /// </summary>
        /// <remarks>
        /// Bu servis esnek teklifleri siler.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Flexible Offer Cancel Request (optional)</param>
        /// <returns>Task of ApiResponse (DeleteOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteOfferServiceResponse>> OfferdeleteflexibleAsyncWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
        
        /// <summary>
        /// Offer / Cancel / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service cancels given hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Hourly Offer Cancel Request (optional)</param>
        /// <returns>Task of DeleteOfferServiceResponse</returns>
        System.Threading.Tasks.Task<DeleteOfferServiceResponse> OfferdeletehourlyAsync (string gopServiceTicket, ServiceDeleteOfferRequest body = null);

        /// <summary>
        /// Offer / Cancel / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service cancels given hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Hourly Offer Cancel Request (optional)</param>
        /// <returns>Task of ApiResponse (DeleteOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DeleteOfferServiceResponse>> OfferdeletehourlyAsyncWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null);
        
        /// <summary>
        /// Offer / List / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlistblockAsync (ServiceQueryOfferRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / List / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists block offers.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlistblockAsyncWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists flexible offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlistflexibleAsync (ServiceQueryOfferRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / List / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists flexible offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlistflexibleAsyncWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / History / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists history of block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthistoryblockAsync (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / List / History / Block Service
        /// </summary>
        /// <remarks>
        /// This service lists history of block offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthistoryblockAsyncWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / History / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists history of flexible offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthistoryflexibleAsync (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / List / History / Flexible Service
        /// </summary>
        /// <remarks>
        /// This service lists history of flexible offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthistoryflexibleAsyncWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / History / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists history of hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthistoryhourlyAsync (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / List / History / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists history of hourly offer.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthistoryhourlyAsyncWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Period Hours List Service
        /// </summary>
        /// <remarks>
        /// This service returns periods for deliveryday and offer type.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferHourBlockServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferHourBlockServiceResponse> OfferlisthourblocksAsync (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Period Hours List Service
        /// </summary>
        /// <remarks>
        /// This service returns periods for deliveryday and offer type.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferHourBlockServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferHourBlockServiceResponse>> OfferlisthourblocksAsyncWithHttpInfo (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / List / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists hourly offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthourlyAsync (ServiceQueryOfferRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / List / Hourly Service
        /// </summary>
        /// <remarks>
        /// This service lists hourly offers
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthourlyAsyncWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Market Result Service
        /// </summary>
        /// <remarks>
        /// This service returns market results , market clearing price vs.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferResultServiceResponse</returns>
        System.Threading.Tasks.Task<QueryOfferResultServiceResponse> OfferofferresultAsync (ServiceOfferResultRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Market Result Service
        /// </summary>
        /// <remarks>
        /// This service returns market results , market clearing price vs.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferResultServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryOfferResultServiceResponse>> OfferofferresultAsyncWithHttpInfo (ServiceOfferResultRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Region Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions for offer
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        System.Threading.Tasks.Task<ParameterQueryServiceResponse> OfferregionsAsync (ServiceRegionRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Region Service
        /// </summary>
        /// <remarks>
        /// This service returns available regions for offer
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> OfferregionsAsyncWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket);
        
        /// <summary>
        /// Offer / Delivery Day Val?dation Service
        /// </summary>
        /// <remarks>
        /// Validates given delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of BooleanServiceResponse</returns>
        System.Threading.Tasks.Task<BooleanServiceResponse> OffervalidatedeliverydayAsync (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);

        /// <summary>
        /// Offer / Delivery Day Val?dation Service
        /// </summary>
        /// <remarks>
        /// Validates given delivery day.
        /// </remarks>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (BooleanServiceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanServiceResponse>> OffervalidatedeliverydayAsyncWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OfferApi : IOfferApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OfferApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OfferApi(Configuration configuration = null)
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
        /// Offer / Advance Service This service returns required advances for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>AdvanceResultServiceResponse</returns>
        public AdvanceResultServiceResponse Offeradvance (ServiceAdvanceResultRequest body, string gopServiceTicket)
        {
             ApiResponse<AdvanceResultServiceResponse> localVarResponse = OfferadvanceWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Advance Service This service returns required advances for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of AdvanceResultServiceResponse</returns>
        public ApiResponse< AdvanceResultServiceResponse > OfferadvanceWithHttpInfo (ServiceAdvanceResultRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offeradvance");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offeradvance");
            
    
            var localVarPath = "/offer/advance";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offeradvance: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offeradvance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdvanceResultServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdvanceResultServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdvanceResultServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Advance Service This service returns required advances for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of AdvanceResultServiceResponse</returns>
        public async System.Threading.Tasks.Task<AdvanceResultServiceResponse> OfferadvanceAsync (ServiceAdvanceResultRequest body, string gopServiceTicket)
        {
             ApiResponse<AdvanceResultServiceResponse> localVarResponse = await OfferadvanceAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Advance Service This service returns required advances for delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Advance List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (AdvanceResultServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdvanceResultServiceResponse>> OfferadvanceAsyncWithHttpInfo (ServiceAdvanceResultRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offeradvance");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offeradvance");
            
    
            var localVarPath = "/offer/advance";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offeradvance: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offeradvance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdvanceResultServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdvanceResultServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdvanceResultServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Create / Block Service This service creates block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offercreateblock (ServiceOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OffercreateblockWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Create / Block Service This service creates block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OffercreateblockWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offercreateblock");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offercreateblock");
            
    
            var localVarPath = "/offer/create/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercreateblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercreateblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Create / Block Service This service creates block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OffercreateblockAsync (ServiceOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OffercreateblockAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Create / Block Service This service creates block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Block Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OffercreateblockAsyncWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offercreateblock");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offercreateblock");
            
    
            var localVarPath = "/offer/create/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercreateblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercreateblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Create / Flexible Service This service creates flexible offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offercreateflexible (ServiceOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OffercreateflexibleWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Create / Flexible Service This service creates flexible offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OffercreateflexibleWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offercreateflexible");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offercreateflexible");
            
    
            var localVarPath = "/offer/create/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercreateflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercreateflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Create / Flexible Service This service creates flexible offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OffercreateflexibleAsync (ServiceOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OffercreateflexibleAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Create / Flexible Service This service creates flexible offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Flexible Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OffercreateflexibleAsyncWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offercreateflexible");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offercreateflexible");
            
    
            var localVarPath = "/offer/create/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercreateflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercreateflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Create / Hourly Service This service creates hourly offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offercreatehourly (ServiceOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OffercreatehourlyWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Create / Hourly Service This service creates hourly offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OffercreatehourlyWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offercreatehourly");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offercreatehourly");
            
    
            var localVarPath = "/offer/create/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercreatehourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercreatehourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Create / Hourly Service This service creates hourly offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OffercreatehourlyAsync (ServiceOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OffercreatehourlyAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Create / Hourly Service This service creates hourly offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Create Hourly Offer Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OffercreatehourlyAsyncWithHttpInfo (ServiceOfferRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offercreatehourly");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offercreatehourly");
            
    
            var localVarPath = "/offer/create/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercreatehourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercreatehourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Currency Service This service returns available currencies for offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ParameterQueryServiceResponse</returns>
        public ParameterQueryServiceResponse Offercurrencies (ServiceCurrencyRequest body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = OffercurrenciesWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Currency Service This service returns available currencies for offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        public ApiResponse< ParameterQueryServiceResponse > OffercurrenciesWithHttpInfo (ServiceCurrencyRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offercurrencies");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offercurrencies");
            
    
            var localVarPath = "/offer/currencies";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercurrencies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercurrencies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Currency Service This service returns available currencies for offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        public async System.Threading.Tasks.Task<ParameterQueryServiceResponse> OffercurrenciesAsync (ServiceCurrencyRequest body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = await OffercurrenciesAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Currency Service This service returns available currencies for offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Currency List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> OffercurrenciesAsyncWithHttpInfo (ServiceCurrencyRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offercurrencies");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offercurrencies");
            
    
            var localVarPath = "/offer/currencies";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offercurrencies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offercurrencies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Cancel / Block Service This service cancels given block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <param name="body">Block Offer Cancel Request (optional)</param> 
        /// <returns>DeleteOfferServiceResponse</returns>
        public DeleteOfferServiceResponse Offerdeleteblock (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
             ApiResponse<DeleteOfferServiceResponse> localVarResponse = OfferdeleteblockWithHttpInfo(gopServiceTicket, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Cancel / Block Service This service cancels given block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <param name="body">Block Offer Cancel Request (optional)</param> 
        /// <returns>ApiResponse of DeleteOfferServiceResponse</returns>
        public ApiResponse< DeleteOfferServiceResponse > OfferdeleteblockWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerdeleteblock");
            
    
            var localVarPath = "/offer/delete/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeleteOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Cancel / Block Service This service cancels given block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Block Offer Cancel Request (optional)</param>
        /// <returns>Task of DeleteOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<DeleteOfferServiceResponse> OfferdeleteblockAsync (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
             ApiResponse<DeleteOfferServiceResponse> localVarResponse = await OfferdeleteblockAsyncWithHttpInfo(gopServiceTicket, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Cancel / Block Service This service cancels given block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Block Offer Cancel Request (optional)</param>
        /// <returns>Task of ApiResponse (DeleteOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeleteOfferServiceResponse>> OfferdeleteblockAsyncWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerdeleteblock");
            
    
            var localVarPath = "/offer/delete/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Cancel / Flexible Service Bu servis esnek teklifleri siler.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <param name="body">Flexible Offer Cancel Request (optional)</param> 
        /// <returns>DeleteOfferServiceResponse</returns>
        public DeleteOfferServiceResponse Offerdeleteflexible (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
             ApiResponse<DeleteOfferServiceResponse> localVarResponse = OfferdeleteflexibleWithHttpInfo(gopServiceTicket, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Cancel / Flexible Service Bu servis esnek teklifleri siler.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <param name="body">Flexible Offer Cancel Request (optional)</param> 
        /// <returns>ApiResponse of DeleteOfferServiceResponse</returns>
        public ApiResponse< DeleteOfferServiceResponse > OfferdeleteflexibleWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerdeleteflexible");
            
    
            var localVarPath = "/offer/delete/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeleteOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Cancel / Flexible Service Bu servis esnek teklifleri siler.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Flexible Offer Cancel Request (optional)</param>
        /// <returns>Task of DeleteOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<DeleteOfferServiceResponse> OfferdeleteflexibleAsync (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
             ApiResponse<DeleteOfferServiceResponse> localVarResponse = await OfferdeleteflexibleAsyncWithHttpInfo(gopServiceTicket, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Cancel / Flexible Service Bu servis esnek teklifleri siler.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Flexible Offer Cancel Request (optional)</param>
        /// <returns>Task of ApiResponse (DeleteOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeleteOfferServiceResponse>> OfferdeleteflexibleAsyncWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerdeleteflexible");
            
    
            var localVarPath = "/offer/delete/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerdeleteflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Cancel / Hourly Service This service cancels given hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <param name="body">Hourly Offer Cancel Request (optional)</param> 
        /// <returns>DeleteOfferServiceResponse</returns>
        public DeleteOfferServiceResponse Offerdeletehourly (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
             ApiResponse<DeleteOfferServiceResponse> localVarResponse = OfferdeletehourlyWithHttpInfo(gopServiceTicket, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Cancel / Hourly Service This service cancels given hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <param name="body">Hourly Offer Cancel Request (optional)</param> 
        /// <returns>ApiResponse of DeleteOfferServiceResponse</returns>
        public ApiResponse< DeleteOfferServiceResponse > OfferdeletehourlyWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerdeletehourly");
            
    
            var localVarPath = "/offer/delete/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerdeletehourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerdeletehourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<DeleteOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Cancel / Hourly Service This service cancels given hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Hourly Offer Cancel Request (optional)</param>
        /// <returns>Task of DeleteOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<DeleteOfferServiceResponse> OfferdeletehourlyAsync (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
             ApiResponse<DeleteOfferServiceResponse> localVarResponse = await OfferdeletehourlyAsyncWithHttpInfo(gopServiceTicket, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Cancel / Hourly Service This service cancels given hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <param name="body">Hourly Offer Cancel Request (optional)</param>
        /// <returns>Task of ApiResponse (DeleteOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DeleteOfferServiceResponse>> OfferdeletehourlyAsyncWithHttpInfo (string gopServiceTicket, ServiceDeleteOfferRequest body = null)
        {
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerdeletehourly");
            
    
            var localVarPath = "/offer/delete/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerdeletehourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerdeletehourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<DeleteOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DeleteOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / List / Block Service This service lists block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offerlistblock (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OfferlistblockWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / List / Block Service This service lists block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OfferlistblockWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlistblock");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlistblock");
            
    
            var localVarPath = "/offer/list/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlistblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlistblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / List / Block Service This service lists block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlistblockAsync (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OfferlistblockAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / List / Block Service This service lists block offers.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlistblockAsyncWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlistblock");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlistblock");
            
    
            var localVarPath = "/offer/list/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlistblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlistblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / List / Flexible Service This service lists flexible offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offerlistflexible (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OfferlistflexibleWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / List / Flexible Service This service lists flexible offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OfferlistflexibleWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlistflexible");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlistflexible");
            
    
            var localVarPath = "/offer/list/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlistflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlistflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / List / Flexible Service This service lists flexible offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlistflexibleAsync (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OfferlistflexibleAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / List / Flexible Service This service lists flexible offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlistflexibleAsyncWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlistflexible");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlistflexible");
            
    
            var localVarPath = "/offer/list/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlistflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlistflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / List / History / Block Service This service lists history of block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offerlisthistoryblock (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OfferlisthistoryblockWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / List / History / Block Service This service lists history of block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OfferlisthistoryblockWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlisthistoryblock");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlisthistoryblock");
            
    
            var localVarPath = "/offer/list/history/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / List / History / Block Service This service lists history of block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthistoryblockAsync (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OfferlisthistoryblockAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / List / History / Block Service This service lists history of block offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Block Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthistoryblockAsyncWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlisthistoryblock");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlisthistoryblock");
            
    
            var localVarPath = "/offer/list/history/block";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryblock: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryblock: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / List / History / Flexible Service This service lists history of flexible offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offerlisthistoryflexible (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OfferlisthistoryflexibleWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / List / History / Flexible Service This service lists history of flexible offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OfferlisthistoryflexibleWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlisthistoryflexible");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlisthistoryflexible");
            
    
            var localVarPath = "/offer/list/history/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / List / History / Flexible Service This service lists history of flexible offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthistoryflexibleAsync (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OfferlisthistoryflexibleAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / List / History / Flexible Service This service lists history of flexible offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Flexible Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthistoryflexibleAsyncWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlisthistoryflexible");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlisthistoryflexible");
            
    
            var localVarPath = "/offer/list/history/flexible";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryflexible: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryflexible: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / List / History / Hourly Service This service lists history of hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offerlisthistoryhourly (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OfferlisthistoryhourlyWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / List / History / Hourly Service This service lists history of hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OfferlisthistoryhourlyWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlisthistoryhourly");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlisthistoryhourly");
            
    
            var localVarPath = "/offer/list/history/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryhourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryhourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / List / History / Hourly Service This service lists history of hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthistoryhourlyAsync (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OfferlisthistoryhourlyAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / List / History / Hourly Service This service lists history of hourly offer.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer History Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthistoryhourlyAsyncWithHttpInfo (ServiceQueryOfferHistoryRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlisthistoryhourly");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlisthistoryhourly");
            
    
            var localVarPath = "/offer/list/history/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryhourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthistoryhourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Period Hours List Service This service returns periods for deliveryday and offer type.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferHourBlockServiceResponse</returns>
        public QueryOfferHourBlockServiceResponse Offerlisthourblocks (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferHourBlockServiceResponse> localVarResponse = OfferlisthourblocksWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Period Hours List Service This service returns periods for deliveryday and offer type.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferHourBlockServiceResponse</returns>
        public ApiResponse< QueryOfferHourBlockServiceResponse > OfferlisthourblocksWithHttpInfo (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlisthourblocks");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlisthourblocks");
            
    
            var localVarPath = "/offer/listhourblocks";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourblocks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourblocks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferHourBlockServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferHourBlockServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferHourBlockServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Period Hours List Service This service returns periods for deliveryday and offer type.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferHourBlockServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferHourBlockServiceResponse> OfferlisthourblocksAsync (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferHourBlockServiceResponse> localVarResponse = await OfferlisthourblocksAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Period Hours List Service This service returns periods for deliveryday and offer type.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Period List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferHourBlockServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferHourBlockServiceResponse>> OfferlisthourblocksAsyncWithHttpInfo (ServiceQueryOfferHourBlockRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlisthourblocks");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlisthourblocks");
            
    
            var localVarPath = "/offer/listhourblocks";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourblocks: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourblocks: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferHourBlockServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferHourBlockServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferHourBlockServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / List / Hourly Service This service lists hourly offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferServiceResponse</returns>
        public QueryOfferServiceResponse Offerlisthourly (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = OfferlisthourlyWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / List / Hourly Service This service lists hourly offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferServiceResponse</returns>
        public ApiResponse< QueryOfferServiceResponse > OfferlisthourlyWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerlisthourly");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerlisthourly");
            
    
            var localVarPath = "/offer/list/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / List / Hourly Service This service lists hourly offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferServiceResponse> OfferlisthourlyAsync (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferServiceResponse> localVarResponse = await OfferlisthourlyAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / List / Hourly Service This service lists hourly offers
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Hourly Offer List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferServiceResponse>> OfferlisthourlyAsyncWithHttpInfo (ServiceQueryOfferRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerlisthourly");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerlisthourly");
            
    
            var localVarPath = "/offer/list/hourly";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourly: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerlisthourly: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Market Result Service This service returns market results , market clearing price vs.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>QueryOfferResultServiceResponse</returns>
        public QueryOfferResultServiceResponse Offerofferresult (ServiceOfferResultRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferResultServiceResponse> localVarResponse = OfferofferresultWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Market Result Service This service returns market results , market clearing price vs.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of QueryOfferResultServiceResponse</returns>
        public ApiResponse< QueryOfferResultServiceResponse > OfferofferresultWithHttpInfo (ServiceOfferResultRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerofferresult");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerofferresult");
            
    
            var localVarPath = "/offer/offerresult";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerofferresult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerofferresult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QueryOfferResultServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferResultServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferResultServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Market Result Service This service returns market results , market clearing price vs.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of QueryOfferResultServiceResponse</returns>
        public async System.Threading.Tasks.Task<QueryOfferResultServiceResponse> OfferofferresultAsync (ServiceOfferResultRequest body, string gopServiceTicket)
        {
             ApiResponse<QueryOfferResultServiceResponse> localVarResponse = await OfferofferresultAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Market Result Service This service returns market results , market clearing price vs.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Market Result Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (QueryOfferResultServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QueryOfferResultServiceResponse>> OfferofferresultAsyncWithHttpInfo (ServiceOfferResultRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerofferresult");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerofferresult");
            
    
            var localVarPath = "/offer/offerresult";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerofferresult: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerofferresult: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QueryOfferResultServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QueryOfferResultServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueryOfferResultServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Region Service This service returns available regions for offer
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ParameterQueryServiceResponse</returns>
        public ParameterQueryServiceResponse Offerregions (ServiceRegionRequest body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = OfferregionsWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Region Service This service returns available regions for offer
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of ParameterQueryServiceResponse</returns>
        public ApiResponse< ParameterQueryServiceResponse > OfferregionsWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offerregions");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offerregions");
            
    
            var localVarPath = "/offer/regions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerregions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Region Service This service returns available regions for offer
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ParameterQueryServiceResponse</returns>
        public async System.Threading.Tasks.Task<ParameterQueryServiceResponse> OfferregionsAsync (ServiceRegionRequest body, string gopServiceTicket)
        {
             ApiResponse<ParameterQueryServiceResponse> localVarResponse = await OfferregionsAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Region Service This service returns available regions for offer
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Offer Region List Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (ParameterQueryServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParameterQueryServiceResponse>> OfferregionsAsyncWithHttpInfo (ServiceRegionRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offerregions");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offerregions");
            
    
            var localVarPath = "/offer/regions";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offerregions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offerregions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParameterQueryServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParameterQueryServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParameterQueryServiceResponse)));
            
        }
        
        /// <summary>
        /// Offer / Delivery Day Val?dation Service Validates given delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>BooleanServiceResponse</returns>
        public BooleanServiceResponse Offervalidatedeliveryday (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
             ApiResponse<BooleanServiceResponse> localVarResponse = OffervalidatedeliverydayWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Offer / Delivery Day Val?dation Service Validates given delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param> 
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param> 
        /// <returns>ApiResponse of BooleanServiceResponse</returns>
        public ApiResponse< BooleanServiceResponse > OffervalidatedeliverydayWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OfferApi->Offervalidatedeliveryday");
            
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null)
                throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling OfferApi->Offervalidatedeliveryday");
            
    
            var localVarPath = "/offer/validatedeliveryday";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offervalidatedeliveryday: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offervalidatedeliveryday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BooleanServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BooleanServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BooleanServiceResponse)));
            
        }

        
        /// <summary>
        /// Offer / Delivery Day Val?dation Service Validates given delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of BooleanServiceResponse</returns>
        public async System.Threading.Tasks.Task<BooleanServiceResponse> OffervalidatedeliverydayAsync (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
             ApiResponse<BooleanServiceResponse> localVarResponse = await OffervalidatedeliverydayAsyncWithHttpInfo(body, gopServiceTicket);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Offer / Delivery Day Val?dation Service Validates given delivery day.
        /// </summary>
        /// <exception cref="gopclient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Validate Delivery Day Request</param>
        /// <param name="gopServiceTicket">CAS Service Token (ST)</param>
        /// <returns>Task of ApiResponse (BooleanServiceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanServiceResponse>> OffervalidatedeliverydayAsyncWithHttpInfo (ServiceQueryDeliveryDayRequest body, string gopServiceTicket)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Offervalidatedeliveryday");
            // verify the required parameter 'gopServiceTicket' is set
            if (gopServiceTicket == null) throw new ApiException(400, "Missing required parameter 'gopServiceTicket' when calling Offervalidatedeliveryday");
            
    
            var localVarPath = "/offer/validatedeliveryday";
    
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
                throw new ApiException (localVarStatusCode, "Error calling Offervalidatedeliveryday: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Offervalidatedeliveryday: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BooleanServiceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BooleanServiceResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BooleanServiceResponse)));
            
        }
        
    }
    
}
