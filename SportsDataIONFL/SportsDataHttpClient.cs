using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SportsDataIONFL
{
    public class SportsDataHttpClient
    {
        private string apiKey;
        private HttpClient httpClient;

        public SportsDataHttpClient(string apiKey)
        {
            this.apiKey = apiKey;
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri("https://sportsdata.io/v3/nfl");
        }

        public async Task<HttpResponseMessage> Get(string url)
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
                Headers =
                {
                    { "Ocp-Apim-Subscription-Key", this.apiKey }
                }
            };

            return await this.httpClient.SendAsync(request);
        }
    }
}
