using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class FullTorn
    {
        [JsonProperty(PropertyName = "bank")]
        public Bank Bank { get; set; }

        [JsonProperty(PropertyName = "cards")]
        public Dictionary<int, Card> Cards { get; set; }

        [JsonProperty(PropertyName = "companies")]
        public Dictionary<int, Company> Companies { get; set; }

        [JsonProperty(PropertyName = "education")]
        public Dictionary<int, EducationCourse> Education { get; set; }

        [JsonProperty(PropertyName = "factiontree")]
        public Dictionary<int, Dictionary<int, FactionPerk>> FactionTree { get; set; }

        [JsonProperty(PropertyName = "gyms")]
        public Dictionary<int, Gym> Gyms { get; set; }

        [JsonProperty(PropertyName = "honors")]
        public Dictionary<int, Honor> Honors { get; set; }

        [JsonProperty(PropertyName = "items")]
        public Dictionary<int, Item> Items { get; set; }

        [JsonProperty(PropertyName = "logcategories")]
        public Dictionary<int, string> LogCategories { get; set; }

        [JsonProperty(PropertyName = "logtypes")]
        public Dictionary<int, string> LogTypes { get; set; }

        [JsonProperty(PropertyName = "medals")]
        public Dictionary<int, Medal> Medals { get; set; }

        [JsonProperty(PropertyName = "organisedcrimes")]
        public Dictionary<int, OrganisedCrime> OrganisedCrimes { get; set; }

        [JsonProperty(PropertyName = "pawnshop")]
        public PawnShop PawnShop { get; set; }

        [JsonProperty(PropertyName = "properties")]
        public Dictionary<int, Property> Properties { get; set; }

        [JsonProperty(PropertyName = "rackets")]
        public Dictionary<string, Racket> Rackets { get; set; }

        [JsonProperty(PropertyName = "raids")]
        public Dictionary<int, Raid> Raids { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public Dictionary<string, string> Stats { get; set; }

        [JsonProperty(PropertyName = "stocks")]
        public Dictionary<int, Stock> Stocks { get; set; }

        [JsonProperty(PropertyName = "territory")]
        public Dictionary<string, Territory> Territories { get; set; }

        [JsonProperty(PropertyName = "territorywars")]
        public Dictionary<string, TerritoryWar> TerritoryWars { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
    }
}
