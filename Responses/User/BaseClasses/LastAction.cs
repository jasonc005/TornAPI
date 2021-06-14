using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class LastAction
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "relative")]
        public string Relative { get; set; }
    }
}
