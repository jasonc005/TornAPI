using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TornAPI.Responses.User.BaseClasses
{
    public class LogEntry
    {
        [JsonProperty(PropertyName = "log")]
        public int LogType { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "data")]
        public JObject Data { get; set; }
    }
}
