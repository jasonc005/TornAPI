using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Status
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "until")]
        public double Until { get; set; }
    }
}
