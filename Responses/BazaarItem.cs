﻿using Newtonsoft.Json;

namespace TornAPI.Responses
{
    public class BazaarItem
    {
        [JsonProperty(PropertyName = "ID")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        [JsonProperty(PropertyName = "market_price")]
        public int MarketPrice { get; set; }
    }
}
