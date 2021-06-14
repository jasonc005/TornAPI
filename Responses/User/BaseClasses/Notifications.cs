using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Notifications
    {
        [JsonProperty(PropertyName = "messages")]
        public int Messages { get; set; }

        [JsonProperty(PropertyName = "events")]
        public int Events { get; set; }

        [JsonProperty(PropertyName = "awards")]
        public int Awards { get; set; }

        [JsonProperty(PropertyName = "competition")]
        public int Competition { get; set; }
    }
}
