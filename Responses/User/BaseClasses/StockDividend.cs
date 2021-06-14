using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class StockDividend
    {
        [JsonProperty(PropertyName = "ready")]
        public bool Ready { get; set; }

        [JsonProperty(PropertyName = "increment")]
        public int Increment { get; set; }

        [JsonProperty(PropertyName = "progress")]
        public int Progress { get; set; }

        [JsonProperty(PropertyName = "frequency")]
        public int Frequency { get; set; }
    }
}
