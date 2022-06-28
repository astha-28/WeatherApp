using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NewTemperatureApp3.Helper
{
    public class ApiCaller
    {

        public static async Task<ApiResponse> Get(string url)
        {
            var client = new HttpClient();
            var request = await client.GetAsync(url);
            if (request.IsSuccessStatusCode)
            {
                return new ApiResponse { Response = await request.Content.ReadAsStringAsync() };
            }
            else
                return new ApiResponse { ErrorMessage = request.ReasonPhrase };

        }
    }
    public class ApiResponse
    {
        public string ErrorMessage { get; set; }
        public string Response { get; set; }
    }

}
//string authId = null
//string url
//if (!string.IsNullOrWhiteSpace(authId))
//client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authorization");