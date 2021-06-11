using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class BattleStatsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "strength")]
        public long? Strength { get; set; }

        [JsonProperty(PropertyName = "defense")]
        public long? Defense { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public long? Speed { get; set; }

        [JsonProperty(PropertyName = "dexterity")]
        public long? Dexterity { get; set; }

        [JsonProperty(PropertyName = "total")]
        public long? TotalBattleStats { get; set; }

        [JsonProperty(PropertyName = "strength_modifier")]
        public int? StrengthModifier { get; set; }

        [JsonProperty(PropertyName = "defense_modifier")]
        public int? DefenseModifier { get; set; }

        [JsonProperty(PropertyName = "speed_modifier")]
        public int? SpeedModifier { get; set; }

        [JsonProperty(PropertyName = "dexterity_modifier")]
        public int? DexterityModifier { get; set; }

        [JsonProperty(PropertyName = "strength_info")]
        public List<string> StrengthInfo { get; set; }

        [JsonProperty(PropertyName = "defense_info")]
        public List<string> DefenseInfo { get; set; }

        [JsonProperty(PropertyName = "speed_info")]
        public List<string> SpeedInfo { get; set; }

        [JsonProperty(PropertyName = "dexterity_info")]
        public List<string> DexterityInfo { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.BattleStats.ToString();
        }
    }
}
