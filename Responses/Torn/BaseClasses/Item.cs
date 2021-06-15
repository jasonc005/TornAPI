using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Item
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        [JsonProperty(PropertyName = "requirement")]
        public string Requirement { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "weapon_type")]
        public string WeaponType { get; set; }

        [JsonProperty(PropertyName = "buy_price")]
        public long BuyPrice { get; set; }

        [JsonProperty(PropertyName = "sell_price")]
        public long SellPrice { get; set; }

        [JsonProperty(PropertyName = "market_value")]
        public long MarketValue { get; set; }

        [JsonProperty(PropertyName = "circulation")]
        public long Circulation { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        [JsonProperty(PropertyName = "coverage")]
        public Dictionary<string, double> Coverage { get; set; }
    }
}
