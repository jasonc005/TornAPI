using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Bank
    {
        [JsonProperty(PropertyName = "1w")]
        public string Interest1Week { get; set; }

        [JsonProperty(PropertyName = "2w")]
        public string Interest2Week { get; set; }

        [JsonProperty(PropertyName = "1m")]
        public string Interest1Month { get; set; }

        [JsonProperty(PropertyName = "2m")]
        public string Interest2Month { get; set; }

        [JsonProperty(PropertyName = "3m")]
        public string Interest3Month { get; set; }
    }
}
