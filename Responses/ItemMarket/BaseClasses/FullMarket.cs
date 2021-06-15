using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.ItemMarket.BaseClasses
{
    public class FullMarket
    {
        [JsonProperty(PropertyName = "bazaar")]
        public List<MarketItem> Bazaar { get; set; }

        [JsonProperty(PropertyName = "itemmarket")]
        public List<MarketItem> ItemMarket { get; set; }

        [JsonProperty(PropertyName = "pointsmarket")]
        public Dictionary<long, PointsListing> PointsMarket { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
    }
}
