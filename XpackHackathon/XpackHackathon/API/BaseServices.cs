using System.Net.Http.Headers;
using System.Threading.Tasks;
using XpackHackathon.Utils;
using System.Net.Http;
using XpackHackathon.Tests;
using AventStack.ExtentReports;

namespace XpackHackathon.API
{
    public class BaseServices
    {
        public string BaseUri;
        public string AccessToken;
        private readonly HttpClient _httpClient = new HttpClient();
        public BaseServices()
        {
            this.BaseUri = ApiTestBase.BaseUrl;
            //this.AccessToken = Resources.Token.access_Token;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
        }

        protected async Task<HttpResponseMessage> Post(string requestUrl, HttpContent content, string apiDescription)
        {

            Resources.Report.LogInfo($"Calling POST : {apiDescription}");
            Resources.Report.LogInfo($"Request URL : {requestUrl} Request Body : {await content.ReadAsStringAsync()}");
            var responseMessage = await _httpClient.PostAsync(requestUrl, content);
            Resources.Report.Log(Status.Pass,
                $"Response Body : {await responseMessage.Content.ReadAsStringAsync()} " +
                $"Response Code : {responseMessage.StatusCode}");
            return responseMessage;
        }

        protected async Task<HttpResponseMessage> Get(string requestUrl, string apiDescription)
        {
            Resources.Report.LogInfo($"Calling GET : {apiDescription}");
            Resources.Report.LogInfo($"Request URL : {requestUrl}");
            var responseMessage = await _httpClient.GetAsync(requestUrl);
            Resources.Report.Log(Status.Pass,
                $"Response Body : {await responseMessage.Content.ReadAsStringAsync()} " +
                $"Response Code : {responseMessage.StatusCode}");
            return responseMessage;
        }

        protected async Task<HttpResponseMessage> Put(string requestUrl, HttpContent content, string apiDescription)
        {
            Resources.Report.LogInfo($"Calling PUT : {apiDescription}");
            Resources.Report.LogInfo($"Request URL : {requestUrl}  Request Body : {await content.ReadAsStringAsync()}");
            var responseMessage = await _httpClient.PutAsync(requestUrl, content);
            Resources.Report.Log(Status.Pass,
                $"Response Body : {await responseMessage.Content.ReadAsStringAsync()} " +
                $"Response Code : {responseMessage.StatusCode}");
            return responseMessage;
        }

        protected async Task<HttpResponseMessage> Delete(string requestUrl, string apiDescription)
        {
            Resources.Report.LogInfo($"Calling DELETE : {apiDescription}");
            Resources.Report.LogInfo($"Request URL : {requestUrl}");
            var responseMessage = await _httpClient.DeleteAsync(requestUrl);
            Resources.Report.Log(Status.Pass,
                $"Response Body : {await responseMessage.Content.ReadAsStringAsync()} " +
                $"Response Code : {responseMessage.StatusCode}");
            return responseMessage;
        }
    }
}
