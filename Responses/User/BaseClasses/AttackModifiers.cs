using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class AttackModifiers
    {
        [JsonProperty(PropertyName = "fair_fight")]
        public double FairFight { get; set; }

        [JsonProperty(PropertyName = "war")]
        public double War { get; set; }

        [JsonProperty(PropertyName = "retaliation")]
        public double Retaliation { get; set; }

        [JsonProperty(PropertyName = "group_attack")]
        public double GroupAttack { get; set; }

        [JsonProperty(PropertyName = "overseas")]
        public double Overseas { get; set; }

        [JsonProperty(PropertyName = "chain_bonus")]
        public double ChainBonus { get; set; }
    }
}
