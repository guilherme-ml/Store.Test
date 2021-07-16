using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Store.Test.Rest
{
    public class BaseRequest
    {
        protected string _uri;
        private readonly HttpClient _client = new HttpClient();
        public BaseRequest(string uri)
        {
            _uri = uri;
        }

        protected async Task<HttpResponseMessage> SendAsync(RequestMethod method, string endpoint, object parameters = null, string token="")
        {
            _client.BaseAddress = new Uri(_uri);
            _client.Timeout = TimeSpan.FromMinutes(30);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (!string.IsNullOrEmpty(token))
                _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            return method switch
            {
                RequestMethod.Get => await Get(endpoint),
                RequestMethod.Post => await Post(endpoint, parameters),
                RequestMethod.Put => await Put(endpoint, parameters),
                RequestMethod.Patch => await Patch(endpoint, parameters),
                RequestMethod.Delete => await Delete(endpoint),
                _ => null,
            };
        }
        private async Task<HttpResponseMessage> Get(string endpoint)
        {
            using (_client)
            {
                return await _client.GetAsync(endpoint);
            }
        }

        private async Task<HttpResponseMessage> Post(string endpoint, object parameters)
        {
            using (_client)
            {
                var json = JsonConvert.SerializeObject(parameters);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return await _client.PostAsync(endpoint, content);
            }
        }
        private async Task<HttpResponseMessage> Put(string endpoint, object parameters)
        {
            using (_client)
            {
                var json = JsonConvert.SerializeObject(parameters);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return await _client.PutAsync(endpoint, content);
            }
        }

        private async Task<HttpResponseMessage> Patch(string endpoint, object parameters)
        {
            using (_client)
            {
                var json = JsonConvert.SerializeObject(parameters);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                return await _client.PatchAsync(endpoint, content);
            }
        }

        private async Task<HttpResponseMessage> Delete(string endpoint)
        {
            using (_client)
            {
                return await _client.DeleteAsync(endpoint);
            }
        }
    }
}
