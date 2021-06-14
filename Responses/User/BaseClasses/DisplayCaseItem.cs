using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class DisplayCaseItem
    {
        [JsonProperty(PropertyName = "ID")]
        public int ItemID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "circulation")]
        public int Circulation { get; set; }

        [JsonProperty(PropertyName = "market_price")]
        public long MarketPrice { get; set; }
    }
}
