using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Revive
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        [JsonProperty(PropertyName = "chance")]
        public double Chance { get; set; }

        [JsonProperty(PropertyName = "reviver_id")]
        public long ReviverID { get; set; }

        [JsonProperty(PropertyName = "reviver_name")]
        public string ReviverName { get; set; }

        [JsonProperty(PropertyName = "reviver_faction")]
        public int ReviverFaction { get; set; }

        [JsonProperty(PropertyName = "reviver_factionname")]
        public string ReviverFactionName { get; set; }

        [JsonProperty(PropertyName = "target_id")]
        public long TargetID { get; set; }

        [JsonProperty(PropertyName = "target_name")]
        public string TargetName { get; set; }

        [JsonProperty(PropertyName = "target_faction")]
        public int TargetFaction { get; set; }

        [JsonProperty(PropertyName = "target_factionname")]
        public string TargetFactionName { get; set; }

        [JsonProperty(PropertyName = "target_hospital_reason")]
        public string TargetHospitalReason { get; set; }

        // TODO: Check type
        [JsonProperty(PropertyName = "target_early_discharge")]
        public double TargetEarlyDischarge { get; set; }

        [JsonProperty(PropertyName = "target_last_action")]
        public LastAction TargetLastAction { get; set; }
    }
}
