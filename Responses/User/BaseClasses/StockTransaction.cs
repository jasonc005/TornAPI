using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class StockTransaction
    {
        [JsonProperty(PropertyName = "shares")]
        public long Shares { get; set; }

        [JsonProperty(PropertyName = "bought_price")]
        public double BoughtPrice { get; set; }

        [JsonProperty(PropertyName = "time_bought")]
        public long TimeBought { get; set; }
    }
}
