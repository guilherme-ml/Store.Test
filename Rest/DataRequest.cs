using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Store.Test.Rest
{
    public class DataRequest<T> : BaseRequest
    {
        public DataRequest(string uri) : base(uri)
        {

        }
        public async Task<T> Get(string endpoint)
        {
            var response = await SendAsync(RequestMethod.Get, endpoint);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> Patch(string endpoint, object parameters, string token = "")
        {
            var response = await SendAsync(RequestMethod.Patch, endpoint, parameters, token: token);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> Put(string endpoint, object parameters, string token = "")
        {
            var response = await SendAsync(RequestMethod.Put, endpoint, parameters, token: token);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> Post(string endpoint, object parameters, string token = "")
        {
            var response = await SendAsync(RequestMethod.Post, endpoint, parameters, token: token);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> Delete(string endpoint, string token = "")
        {
            var response = await SendAsync(RequestMethod.Delete, endpoint, token: token);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
