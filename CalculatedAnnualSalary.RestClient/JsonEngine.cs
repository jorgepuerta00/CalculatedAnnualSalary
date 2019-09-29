using Newtonsoft.Json;
using RestSharp;
using System;

namespace CalculatedAnnualSalary.Common
{
    public class JsonEngine
    {
        public string ServiceUrl { get; set; }

        public int Timeout { get; set; }

        public JsonEngine(string serviceUrl, int timeOut)
        {
            this.ServiceUrl = serviceUrl;
            this.Timeout = timeOut;
        }

        public T ExecuteGetOperation<T>() where T : new()
        {
            var request = new RestRequest();
            request.Method = Method.GET;

            var client = new RestClient
            {
                BaseUrl = new Uri(this.ServiceUrl),
                Timeout = this.Timeout
            };

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error!";
                var ServiceException = new ApplicationException(message, response.ErrorException);
                throw ServiceException;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public T ExecutePostOperation<T>(object requestClass) where T : new()
        {
            var request = new RestRequest();
            JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            var myContentJson = JsonConvert.SerializeObject(requestClass, settings);
            request.AddParameter("application/json", myContentJson, ParameterType.RequestBody);
            request.Method = RestSharp.Method.POST;

            var client = new RestClient
            {
                BaseUrl = new Uri(this.ServiceUrl),
                Timeout = this.Timeout
            };

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error";
                var ServiceException = new ApplicationException(message, response.ErrorException);
                throw ServiceException;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
