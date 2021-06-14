using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class BazaarItem
    {
        [JsonProperty(PropertyName = "ID")]
        public int ItemID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "price")]
        public long Price { get; set; }

        [JsonProperty(PropertyName = "market_price")]
        public long MarketPrice { get; set; }
    }
}
