using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class TerritoryWar
    {
        [JsonProperty(PropertyName = "assaulting_faction")]
        public int AssaultingFaction { get; set; }

        [JsonProperty(PropertyName = "defending_faction")]
        public int DefendingFaction { get; set; }

        [JsonProperty(PropertyName = "started")]
        public long Started { get; set; }

        [JsonProperty(PropertyName = "ends")]
        public long Ends { get; set; }
    }
}
