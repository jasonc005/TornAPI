using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class OrganisedCrime
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int Members { get; set; }

        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }

        [JsonProperty(PropertyName = "min_cash")]
        public int MinCash { get; set; }

        [JsonProperty(PropertyName = "max_cash")]
        public int MaxCash { get; set; }

        [JsonProperty(PropertyName = "min_respect")]
        public int MinRespect { get; set; }

        [JsonProperty(PropertyName = "max_respect")]
        public int MaxRespect { get; set; }
    }
}
