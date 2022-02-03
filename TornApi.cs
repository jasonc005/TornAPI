using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TornAPI.Responses;
using TornAPI.Responses.Company.Selections;
using TornAPI.Responses.Faction.Selections;
using TornAPI.Responses.ItemMarket.Selections;
using TornAPI.Responses.Properties.Selections;
using TornAPI.Responses.Torn.Selections;
using TornAPI.Responses.User.Selections;


namespace TornAPI
{
    public class TornApi
    {
        private static readonly string BASE_URL = "https://api.torn.com";
        private readonly HttpClient _client;

        public TornApi()
        {
            _client = new HttpClient();
        }

        public async Task<T> GetUserAsync<T>(string userId, string apiKey, long? from = null, long? to = null)
            where T : IUserSelection, new()
        => await GetGenericAsync<T>(userId, apiKey, from, to);

        public async Task<T> GetPropertyAsync<T>(string propertyId, string apiKey, long? from = null, long? to = null) 
            where T : IPropertySelection, new()
        => await GetGenericAsync<T>(propertyId, apiKey, from, to);

        public async Task<T> GetFactionAsync<T>(string factionId, string apiKey, long? from = null, long? to = null) 
            where T : IFactionSelection, new()
        => await GetGenericAsync<T>(factionId, apiKey, from, to);

        public async Task<T> GetCompanyAsync<T>(string companyId, string apiKey, long? from = null, long? to = null) 
            where T : ICompanySelection, new()
        => await GetGenericAsync<T>(companyId, apiKey, from, to);

        public async Task<T> GetItemMarketAsync<T>(string itemId, string apiKey, long? from = null, long? to = null) 
            where T : IItemMarketSelection, new()
        => await GetGenericAsync<T>(itemId, apiKey, from, to);

        public async Task<T> GetTornAsync<T>(string id, string apiKey, long? from = null, long? to = null) 
            where T : ITornSelection, new()
        => await GetGenericAsync<T>(id, apiKey, from, to);

        private async Task<T> GetGenericAsync<T>(
            string id,
            string apiKey,
            long? from,
            long? to)
            where T : ISelection, new()
        {
            string sectionName = null;
            T responseObj = new T();
            if (responseObj is IUserSelection) sectionName = "user";
            else if (responseObj is IPropertySelection) sectionName = "property";
            else if (responseObj is IFactionSelection) sectionName = "faction";
            else if (responseObj is ICompanySelection) sectionName = "company";
            else if (responseObj is IItemMarketSelection) sectionName = "market";
            else if (responseObj is ITornSelection) sectionName = "torn";

            var endpointUrl = $"{BASE_URL}/{sectionName}/{id}?selections={responseObj.GetSelectionName()}&key={apiKey}";
            if (from != null) endpointUrl += $"&from={from}";
            if (to != null) endpointUrl += $"&to={to}";

            return await GetAsync<T>(endpointUrl);
        }

        private async Task<T> GetAsync<T>(string url)
        {
            var response = await _client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"{response.StatusCode}: {response.ReasonPhrase}");

            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
    }
}
