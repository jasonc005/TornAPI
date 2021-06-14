using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        [JsonProperty(PropertyName = "criminalrecord")]
        public CriminalRecord CriminalRecord { get; set; }

        [JsonProperty(PropertyName = "discord")]
        public Discord Discord { get; set; }

        [JsonProperty(PropertyName = "display")]
        public List<DisplayCaseItem> DisplayCase { get; set; }

        [JsonProperty(PropertyName = "education_current")]
        public int? CurrentEducationID { get; set; }

        [JsonProperty(PropertyName = "education_timeleft")]
        public int? EducationTimeLeft { get; set; }

        [JsonProperty(PropertyName = "education_completed")]
        public List<int> CompletedEducations { get; set; }

        [JsonProperty(PropertyName = "events")]
        public Dictionary<long, Event> Events { get; set; }

        [JsonProperty(PropertyName = "active_gym")]
        public int? ActiveGym { get; set; }

        [JsonProperty(PropertyName = "halloffame")]
        public Dictionary<string, HallOfFameStat> HallOfFame { get; set; }

        [JsonProperty(PropertyName = "honors_awarded")]
        public List<int> HonorsAwarded { get; set; }

        [JsonProperty(PropertyName = "honors_time")]
        public List<long> HonorsTime { get; set; }

        [JsonProperty(PropertyName = "icons")]
        public Dictionary<string, string> Icons { get; set; }

        [JsonProperty(PropertyName = "inventory")]
        public List<InventoryItem> Inventory { get; set; }

        [JsonProperty(PropertyName = "jobpoints")]
        public JobPoints JobPoints { get; set; }

        [JsonProperty(PropertyName = "log")]
        public Dictionary<string, LogEntry> Log { get; set; }

        [JsonProperty(PropertyName = "medals_awarded")]
        public List<int> MedalsAwarded { get; set; }

        [JsonProperty(PropertyName = "medals_time")]
        public List<long> MedalsTime { get; set; }

        [JsonProperty(PropertyName = "merits")]
        public Dictionary<string, int> Merits { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public Dictionary<long, Message> Messages { get; set; }

        [JsonProperty(PropertyName = "points")]
        public int? Points { get; set; }

        [JsonProperty(PropertyName = "cayman_bank")]
        public long? CaymanBank { get; set; }

        [JsonProperty(PropertyName = "vault_amount")]
        public long? VaultAmount { get; set; }

        [JsonProperty(PropertyName = "daily_networth")]
        public long? DailyNetWorth { get; set; }

        [JsonProperty(PropertyName = "money_onhand")]
        public long? MoneyOnHand { get; set; }

        [JsonProperty(PropertyName = "city_bank")]
        public CityBank CityBank { get; set; }

        [JsonProperty(PropertyName = "networth")]
        public NetWorth NetWorth { get; set; }

        [JsonProperty(PropertyName = "notifications")]
        public Notifications Notifications { get; set; }

        [JsonProperty(PropertyName = "job_perks")]
        public List<string> JobPerks { get; set; }

        [JsonProperty(PropertyName = "property_perks")]
        public List<string> PropertyPerks { get; set; }

        [JsonProperty(PropertyName = "stock_perks")]
        public List<string> StockPerks { get; set; }

        [JsonProperty(PropertyName = "merit_perks")]
        public List<string> MeritPerks { get; set; }

        [JsonProperty(PropertyName = "education_perks")]
        public List<string> EducationPerks { get; set; }

        [JsonProperty(PropertyName = "enhancer_perks")]
        public List<string> EnhancerPerks { get; set; }

        [JsonProperty(PropertyName = "company_perks")]
        public List<string> CompanyPerks { get; set; }

        [JsonProperty(PropertyName = "faction_perks")]
        public List<string> FactionPerks { get; set; }

        [JsonProperty(PropertyName = "book_perks")]
        public List<string> BookPerks { get; set; }

        [JsonProperty(PropertyName = "personalstats")]
        public Dictionary<string, long> PersonalStats { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "property")]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "signup")]
        public string SignUpDate { get; set; }

        [JsonProperty(PropertyName = "awards")]
        public int? Awards { get; set; }

        [JsonProperty(PropertyName = "friends")]
        public int? Friends { get; set; }

        [JsonProperty(PropertyName = "enemies")]
        public int? Enemies { get; set; }

        [JsonProperty(PropertyName = "forum_posts")]
        public int? ForumPosts { get; set; }

        [JsonProperty(PropertyName = "karma")]
        public int? Karma { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int? Age { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "donator")]
        public bool? Donator { get; set; }
        
        [JsonProperty(PropertyName = "property_id")]
        public long? PropertyID { get; set; }

        [JsonProperty(PropertyName = "competition")]
        public JObject Competition { get; set; }
        
        [JsonProperty(PropertyName = "job")]
        public Job Job { get; set; }

        [JsonProperty(PropertyName = "faction")]
        public Faction Faction { get; set; }

        [JsonProperty(PropertyName = "married")]
        public Married Married { get; set; }

        [JsonProperty(PropertyName = "basicicons")]
        public Dictionary<string, string> BasicIcons { get; set; }

        [JsonProperty(PropertyName = "states")]
        public States States { get; set; }

        [JsonProperty(PropertyName = "last_action")]
        public LastAction LastAction { get; set; }
    }
}
