using Newtonsoft.Json;

namespace TornAPI.Responses.ItemMarket.BaseClasses
{
    public class PointsListing
    {
        [JsonProperty(PropertyName = "cost")]
        public int Cost { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "total_cost")]
        public long TotalCost { get; set; }
    }
}
