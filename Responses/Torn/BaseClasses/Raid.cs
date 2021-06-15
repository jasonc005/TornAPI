using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Raid
    {
        [JsonProperty(PropertyName = "assaulting_faction")]
        public int AssaultingFaction { get; set; }

        [JsonProperty(PropertyName = "defending_faction")]
        public int DefendingFaction { get; set; }

        [JsonProperty(PropertyName = "assaulting_score")]
        public double AssaultingScore { get; set; }

        [JsonProperty(PropertyName = "defending_score")]
        public double DefendingScore { get; set; }

        [JsonProperty(PropertyName = "started")]
        public long Started { get; set; }
    }
}
