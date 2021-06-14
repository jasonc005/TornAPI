using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class ReceivedEvent
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "event")]
        public string EventText { get; set; }

        [JsonProperty(PropertyName = "owner")]
        public long OwnerID { get; set; }
    }
}
