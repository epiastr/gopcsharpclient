using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;
using gopclient.Api;
using gopclient.Model;
using gopclient.Client;
using Newtonsoft.Json;
/**
 * this application depends on 
 * Newtonsoft.Json
 * RestSharp
 * */
namespace ConsoleApp
{
    class Program
    {
        /**
         * 
         * ileriki guncellemeleri alabilmek icin gopclient projesinin icerisine mudehale etmeyiniz.
         * 
         * please do not modify contents of gopclient project to get updates.
         * 
         * example for hourly bidding
         * */
        readonly static string username = "USERNAME";//uppercase
        readonly static string password = "PASSWORD";
        readonly static string casurl = "https://cas.epias.com.tr/cas/v1/tickets?format=text";
        readonly static string casservicename = "https://goptest.epias.com.tr";
        readonly static string cassturl = "https://cas.epias.com.tr/cas/v1/tickets";
        readonly static string basepath = "https://goptest.epias.com.tr/gop-servis/rest";
        static void Main(string[] args)
        {
            String tgt = getCasTGT();
            ApiClient client = new ApiClient(basepath);
            Configuration config = new Configuration(new ApiClient(basepath));
            config.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";

            OfferApi api = new OfferApi(config);
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                DateFormatString = "yyyy-MM-dd'T'HH:mm:ss.fffzz'00'"
            };

            ServiceOfferRequest scr = new ServiceOfferRequest();
    
            scr.Header = getHeaders();
            var dateTime = DateTime.Now.AddDays(2);

            validateDeliveryDay(dateTime,tgt);//check whether deliveryday is open for bidding

            scr.Body = new OfferRequest();
            OfferRequest rq = new OfferRequest();
            
            rq.DeliveryDay = dateTime; // set deliveryday current day plus 2
            rq.CurrencyCode = getCurrencyCode(rq.DeliveryDay, tgt);
            rq.OfferType = OfferRequest.OfferTypeEnum.Hourly;
            rq.RegionCode = getRegionCode(rq.DeliveryDay, tgt);
            rq.OfferDetails = new List<OfferDetail>();

            var periods = getPeriods(dateTime, tgt);
            foreach (OfferBlockHour period in periods)
            {
                OfferDetail model = new OfferDetail();
                model.StartPeriod = period.Period;
                model.Duration = 1;//default for hourly bid
                model.OfferPrices = new List<OfferPrice>();
                MinMaxPriceResponse minmax = getMinMaxPrice(rq.DeliveryDay, tgt);
                OfferPrice priceMin = new OfferPrice();
                var dummyData = 100+(period.Period * 10);
                priceMin.Amount = dummyData;
                priceMin.Price = minmax.MinimumPrice;

                OfferPrice priceMax = new OfferPrice();
                priceMax.Amount = dummyData;
                priceMax.Price = minmax.MaximumPrice;

                model.OfferPrices.Add(priceMin);
                model.OfferPrices.Add(priceMax);

                rq.OfferDetails.Add(model);

            }


            scr.Body = rq;

            string ticket = getCasSt(tgt);

            QueryOfferServiceResponse resp = api.Offercreatehourly(scr, ticket);
            if (resp.ResultType != QueryOfferServiceResponse.ResultTypeEnum.Success)
            {
                throw new Exception(resp.ResultDescription);
            }
            Console.WriteLine(resp.ResultCode+"-"+resp.ResultDescription+"-"+resp.ResultType);
            //read offer details save it to some where


            Thread.Sleep(20000);
        }

        private static List<OfferBlockHour> getPeriods(DateTime deliveryDay,string tgt)
        {
            ApiClient client = new ApiClient(basepath);
            Configuration config = new Configuration(new ApiClient(basepath));
            config.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";
            OfferApi api = new OfferApi(config);
            ServiceQueryOfferHourBlockRequest req = new ServiceQueryOfferHourBlockRequest();
            req.Header = getHeaders();
            req.Body = new QueryOfferHourBlockRequest(deliveryDay,QueryOfferHourBlockRequest.OfferTypeEnum.Hourly);
            string ticket = getCasSt(tgt);
            QueryOfferHourBlockServiceResponse resp = api.Offerlisthourblocks(req, ticket);
            if (resp.ResultType != QueryOfferHourBlockServiceResponse.ResultTypeEnum.Success)
            {
                throw new Exception(resp.ResultDescription);
            }
            return resp.Body.OfferBlockHours;
        }

        private static void validateDeliveryDay(DateTime dateTime,String tgt)
        {
            ApiClient client = new ApiClient(basepath);
            Configuration config = new Configuration(new ApiClient(basepath));
            config.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";
            OfferApi api = new OfferApi(config);
            ServiceQueryDeliveryDayRequest req = new ServiceQueryDeliveryDayRequest();
            req.Header = getHeaders();
            req.Body = new QueryDeliveryDayRequest(dateTime);
            string ticket = getCasSt(tgt);
            BooleanServiceResponse resp = api.Offervalidatedeliveryday(req, ticket);
            if (resp.ResultType != BooleanServiceResponse.ResultTypeEnum.Success)
            {
                throw new Exception(resp.ResultDescription);
            }
            if (!resp.Body.Value)
            {
                throw new Exception("Delivery day is not valid");
            }
        }

        private static string getCurrencyCode(DateTime? deliveryday,string tgt)
        {
            ApiClient client = new ApiClient(basepath);
            Configuration config = new Configuration(new ApiClient(basepath));
            config.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";
            OfferApi api = new OfferApi(config);
            ServiceCurrencyRequest req = new ServiceCurrencyRequest();
            req.Header = getHeaders();
            req.Body = new CurrencyRequest(deliveryday);

            string ticket = getCasSt(tgt);

            ParameterQueryServiceResponse resp = api.Offercurrencies(req,ticket);
            if(resp.ResultType != ParameterQueryServiceResponse.ResultTypeEnum.Success)
            {
                throw new Exception(resp.ResultDescription);
            }
            //There may be more than one currency so it should be handled with care and love
            return resp.Body.Parameters[0].Value;
        }

        private static string getRegionCode(DateTime? deliveryday, string tgt)
        {
            ApiClient client = new ApiClient(basepath);
            Configuration config = new Configuration(new ApiClient(basepath));
            config.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";
            OfferApi api = new OfferApi(config);
            ServiceRegionRequest req = new ServiceRegionRequest();
            req.Header = getHeaders();
            req.Body = new RegionRequest(deliveryday);

            string ticket = getCasSt(tgt);

            ParameterQueryServiceResponse resp = api.Offerregions(req, ticket);
            if (resp.ResultType != ParameterQueryServiceResponse.ResultTypeEnum.Success)
            {
                throw new Exception(resp.ResultDescription);
            }
            //There may be more than one region so it should be handled with care and love
            return resp.Body.Parameters[0].Value;
        }



        static MinMaxPriceResponse getMinMaxPrice(DateTime? deliveryday,string tgt)
        {
            ApiClient client = new ApiClient(basepath);
            Configuration config = new Configuration(new ApiClient(basepath));
            config.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.fffzzz";
            MinmaxpriceApi api = new MinmaxpriceApi(config);
            ServiceMinMaxPriceListRequest req = new ServiceMinMaxPriceListRequest();
            req.Body = new MinMaxPriceListRequest();
            req.Body.EffectiveDate = deliveryday;
            req.Header = getHeaders();
            MinMaxPriceServiceResponse resp = api.Minmaxpricelisteffective(req, getCasSt(tgt));
            if (resp.ResultType != MinMaxPriceServiceResponse.ResultTypeEnum.Success)
            {
                throw new Exception(resp.ResultDescription);
            }
            return resp.Body;
        }

        static string getCasSt(String tgt)
        {
            var request = (HttpWebRequest)WebRequest.Create(cassturl + "/"+tgt);
            var postData = "service=" + casservicename;
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
        static string getCasTGT()
        {
            var request = (HttpWebRequest)WebRequest.Create(casurl);
            var postData = "username=" + username;
            postData += "&password=" + password;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        private static List<Header> getHeaders()
        {
            List<Header> headers = new List<Header>();
            headers.Add(getApp());
            headers.Add(getTxId());
            return headers;
        }

        private static Header getTxId()
        {
            return new Header("transactionId", Guid.NewGuid().ToString());
        }

        private static Header getApp()
        {
            return new Header("application", "Demo Elk Urt");
        }
    }
}
