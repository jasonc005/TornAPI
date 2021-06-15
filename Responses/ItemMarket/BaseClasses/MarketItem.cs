using Newtonsoft.Json;

namespace TornAPI.Responses.ItemMarket.BaseClasses
{
    public class MarketItem
    {
        [JsonProperty(PropertyName = "ID")]
        public long ID { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public long Cost { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }
    }
}
