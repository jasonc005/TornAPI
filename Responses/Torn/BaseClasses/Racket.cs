using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Racket
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "reward")]
        public string Reward { get; set; }

        [JsonProperty(PropertyName = "created")]
        public long Created { get; set; }

        [JsonProperty(PropertyName = "changed")]
        public long Changed { get; set; }

        [JsonProperty(PropertyName = "faction")]
        public int Faction { get; set; }
    }
}
