using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Stock
    {
        [JsonProperty(PropertyName = "stock_id")]
        public int StockID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "acronym")]
        public string Acronym { get; set; }

        [JsonProperty(PropertyName = "current_price")]
        public double CurrentPrice { get; set; }

        [JsonProperty(PropertyName = "market_cap")]
        public long MarketCap { get; set; }

        [JsonProperty(PropertyName = "total_shares")]
        public long TotalShares { get; set; }

        [JsonProperty(PropertyName = "benefit")]
        public StockBenefit Benefit { get; set; }
    }
}
