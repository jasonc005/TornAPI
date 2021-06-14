using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Travel
    {
        [JsonProperty(PropertyName = "destination")]
        public string Destination { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "departed")]
        public long Departed { get; set; }

        [JsonProperty(PropertyName = "time_left")]
        public long TimeLeft { get; set; }
    }
}
