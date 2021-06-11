using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Event
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "event")]
        public string EventText { get; set; }

        [JsonProperty(PropertyName = "seen")]
        public bool Seen { get; set; }
    }
}
