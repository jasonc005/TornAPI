using Newtonsoft.Json;

namespace TornAPI.Responses.Properties.BaseClasses
{
    public class Rented
    {
        [JsonProperty(PropertyName = "user_id")]
        public long UserID { get; set; }

        [JsonProperty(PropertyName = "days_left")]
        public int DaysLeft { get; set; }

        [JsonProperty(PropertyName = "total_cost")]
        public long TotalCost { get; set; }

        [JsonProperty(PropertyName = "cost_per_day")]
        public int CostPerDay { get; set; }
    }
}
