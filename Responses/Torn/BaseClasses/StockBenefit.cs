using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class StockBenefit
    {
        [JsonProperty(PropertyName = "frequency")]
        public int Frequency { get; set; }

        [JsonProperty(PropertyName = "requirement")]
        public int Requirement { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
