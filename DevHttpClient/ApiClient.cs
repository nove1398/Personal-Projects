using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DevHttpClient
{
    public class ApiClient 
    {
        
        public ApiClient()
        {

        }

        public async Task<T> PostAsync<T>(string url,object model)
        {
           using(var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(model);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(url, content);
                var responseAsString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(responseAsString);
            }
            
           
        }

        public async Task<byte[]> DownloadFile(string url)
        {
            using(var client = new HttpClient())
            {
                byte[] fileBytes = await client.GetByteArrayAsync(url);
                return fileBytes;
            }
        }


        public void SetClientHeaders(HttpClient client, string userName,string passwd)
        {
            var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
        }


    }
}
