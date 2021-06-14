using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Message
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "ID")]
        public long SenderID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string SenderName { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "seen")]
        public bool Seen { get; set; }

        [JsonProperty(PropertyName = "read")]
        public bool Read { get; set; }
    }
}
