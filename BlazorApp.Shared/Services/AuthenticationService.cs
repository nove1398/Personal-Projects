
using BlazorApp.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace BlazorApp.Shared.Services
{
    public class AuthenticationService
    {

        private string _baseUrl = "";
        private HttpClient _client;

        public AuthenticationService(string url)
        {
            _baseUrl = url;
            _client = new HttpClient();
        }

        public async Task<UserManagerResponse> RegisterUserASync(RegisterRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync($"{_baseUrl}/api/auth/register", content);
            var responseAsString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UserManagerResponse>(responseAsString);
        }
    }
}
