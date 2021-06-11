using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Cooldowns
    {
        [JsonProperty(PropertyName = "drug")]
        public int Drug { get; set; }

        [JsonProperty(PropertyName = "medical")]
        public int Medical { get; set; }

        [JsonProperty(PropertyName = "booster")]
        public int Booster { get; set; }
    }
}
