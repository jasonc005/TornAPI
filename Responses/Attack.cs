using Newtonsoft.Json;

namespace TornAPI.Responses
{
    public class Attack
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "timestamp_started")]
        public long TimestampStarted { get; set; }

        [JsonProperty(PropertyName = "timestamp_ended")]
        public long TimestampEnded { get; set; }

        [JsonProperty(PropertyName = "attacker_id")]
        public long AttackerID { get; set; }

        [JsonProperty(PropertyName = "attacker_name")]
        public string AttackerName { get; set; }

        [JsonProperty(PropertyName = "attacker_faction")]
        public int AttackerFaction { get; set; }

        [JsonProperty(PropertyName = "attacker_factionname")]
        public string AttackerFactionName { get; set; }

        [JsonProperty(PropertyName = "defender_id")]
        public long DefenderID { get; set; }

        [JsonProperty(PropertyName = "defender_name")]
        public string DefenderName { get; set; }

        [JsonProperty(PropertyName = "defender_faction")]
        public int DefenderFaction { get; set; }

        [JsonProperty(PropertyName = "defender_factionname")]
        public string DefenderFactionName { get; set; }

        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        [JsonProperty(PropertyName = "stealthed")]
        public bool Stealthed { get; set; }

        [JsonProperty(PropertyName = "respect")]
        public double Respect { get; set; }

        [JsonProperty(PropertyName = "chain")]
        public int? Chain { get; set; }

        // TODO: Verify this is correct data type
        [JsonProperty(PropertyName = "raid")]
        public double? Raid { get; set; }

        [JsonProperty(PropertyName = "respect_gain")]
        public double? RespectGain { get; set; }

        [JsonProperty(PropertyName = "respect_loss")]
        public double? RespectLoss { get; set; }

        [JsonProperty(PropertyName = "modifiers")]
        public AttackModifiers Modifiers { get; set; }
    }
}
