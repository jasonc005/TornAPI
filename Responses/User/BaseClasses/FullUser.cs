using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class FullUser
    {
        [JsonProperty(PropertyName = "server_time")]
        public long? ServerTime { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int? Level { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public long? PlayerID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }
        
        [JsonProperty(PropertyName = "ammo")]
        public List<Ammo> Ammo { get; set; }

        [JsonProperty(PropertyName = "attacks")]
        public Dictionary<string, Attack> Attacks { get; set; }

        [JsonProperty(PropertyName = "happy")]
        public HappyBar Happy { get; set; }

        [JsonProperty(PropertyName = "life")]
        public LifeBar Life { get; set; }

        [JsonProperty(PropertyName = "energy")]
        public EnergyBar Energy { get; set; }

        [JsonProperty(PropertyName = "nerve")]
        public NerveBar Nerve { get; set; }

        [JsonProperty(PropertyName = "chain")]
        public Chain Chain { get; set; }

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

        [JsonProperty(PropertyName = "bazaar")]
        public List<BazaarItem> Bazaar { get; set; }

        [JsonProperty(PropertyName = "cooldowns")]
        public Cooldowns Cooldowns { get; set; }




    }
}
