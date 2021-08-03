using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SportsDataIONFL
{
    class SportsDataClient
    {
        private SportsDataHttpClient httpClient;

        public SportsDataClient(string apiKey)
        {
            this.httpClient = new SportsDataHttpClient(apiKey);
        }

        public async Task<HttpResponseMessage> GetPlayerDetails()
        {
            return await this.httpClient.Get("scores/json/players");
        }
    }
}
