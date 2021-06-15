using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Honor
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }

        [JsonProperty(PropertyName = "circulation")]
        public int Circulation { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }
    }
}
