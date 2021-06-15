using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class CompanyStock
    {
        [JsonProperty(PropertyName = "cost")]
        public int? Cost { get; set; }

        [JsonProperty(PropertyName = "rrp")]
        public int RRP { get; set; }
    }
}
