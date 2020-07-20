using FIAP.Core.Infra.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Core.Infra
{
    public class ApiCaller : IApiCaller
    {
        public async Task<object> Delete<T>(string baseUri, string method)
        {
            using var client = new HttpClient();

            var response = await client.DeleteAsync(baseUri + method);

            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<T> GetAsync<T>(string baseUri, string method)
        {
            using var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(baseUri + method);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(resp);
        }

        public async Task<object> Post<T>(object payload, string baseUri, string method)
        {
            var json = JsonConvert.SerializeObject(payload);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();
            
            var response = await client.PostAsync(baseUri + method, data);

            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<object> Put<T>(object payload, string baseUri, string method)
        {
            var json = JsonConvert.SerializeObject(payload);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            var response = await client.PutAsync(baseUri + method, data);

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
