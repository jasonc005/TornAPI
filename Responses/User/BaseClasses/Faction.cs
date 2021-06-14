using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Faction
    {
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "faction_id")]
        public int FactionID { get; set; }

        [JsonProperty(PropertyName = "days_in_faction")]
        public int DaysInFaction { get; set; }

        [JsonProperty(PropertyName = "faction_name")]
        public string FactionName { get; set; }

        [JsonProperty(PropertyName = "faction_tag")]
        public string FactionTag { get; set; }
    }
}
