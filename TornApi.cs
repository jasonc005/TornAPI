using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public async Task<T> GetUserAsync<T>(
            string userId, 
            string apiKey) 
            where T : IUserSelection, new()
        {
            var response = new T();

            var apiEndpointUrl = $"{BASE_URL}/user/{userId}?selections={response.GetSelectionName()}&key={apiKey}";

            try
            {
                response = await GetAsync<T>(apiEndpointUrl);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetPropertyAsync<T>(
            string propertyId, 
            string apiKey) 
            where T : IPropertySelection, new()
        {
            var response = new T();

            var apiEndpointUrl = $"{BASE_URL}/property/{propertyId}?selections={response.GetSelectionName()}&key={apiKey}";

            try
            {
                response = await GetAsync<T>(apiEndpointUrl);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetFactionAsync<T>(
            string factionId, 
            string apiKey) 
            where T : IFactionSelection, new()
        {
            var response = new T();

            var apiEndpointUrl = $"{BASE_URL}/faction/{factionId}?selections={response.GetSelectionName()}&key={apiKey}";

            try
            {
                response = await GetAsync<T>(apiEndpointUrl);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetCompanyAsync<T>(
            string companyId, 
            string apiKey) 
            where T : ICompanySelection, new()
        {
            var response = new T();

            var apiEndpointUrl = $"{BASE_URL}/company/{companyId}?selections={response.GetSelectionName()}&key={apiKey}";

            try
            {
                response = await GetAsync<T>(apiEndpointUrl);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetItemMarketAsync<T>(
            string itemId, 
            string apiKey) 
            where T : IItemMarketSelection, new()
        {
            var response = new T();

            var apiEndpointUrl = $"{BASE_URL}/market/{itemId}?selections={response.GetSelectionName()}&key={apiKey}";

            try
            {
                response = await GetAsync<T>(apiEndpointUrl);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<T> GetTornAsync<T>(
            string id, 
            string apiKey) 
            where T : ITornSelection, new()
        {
            var response = new T();

            var apiEndpointUrl = $"{BASE_URL}/torn/{id}?selections={response.GetSelectionName()}&key={apiKey}";

            try
            {
                response = await GetAsync<T>(apiEndpointUrl);

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
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
