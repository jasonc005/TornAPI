using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class FactionPerk
    {
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ability")]
        public string Ability { get; set; }

        [JsonProperty(PropertyName = "challenge")]
        public string Challenge { get; set; }

        [JsonProperty(PropertyName = "base_cost")]
        public int BaseCost { get; set; }
    }
}
