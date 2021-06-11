using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Chain
    {
        [JsonProperty(PropertyName = "current")]
        public int Current { get; set; }

        [JsonProperty(PropertyName = "maximum")]
        public int Maximum { get; set; }

        [JsonProperty(PropertyName = "timeout")]
        public long Timeout { get; set; }

        [JsonProperty(PropertyName = "modifier")]
        public double Modifier { get; set; }

        [JsonProperty(PropertyName = "cooldown")]
        public long Cooldown { get; set; }
    }
}
