using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Newtonsoft.Json.Linq;

namespace Services
{
    public class Service
    {
        public async Task<List<MarketItenDto>> GetMarketData(string url)
        {

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                
                if (!response.IsSuccessStatusCode) throw new Exception(response.RequestMessage.ToString());
                
                var content = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(content);
                var itenList = json["data"].ToObject<List<MarketItenDto>>();

                return itenList;
            }
        }
    }
}