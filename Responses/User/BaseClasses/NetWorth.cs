using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class NetWorth
    {
        [JsonProperty(PropertyName = "pending")]
        public long Pending { get; set; }

        [JsonProperty(PropertyName = "wallet")]
        public long Wallet { get; set; }

        [JsonProperty(PropertyName = "bank")]
        public long Bank { get; set; }

        [JsonProperty(PropertyName = "points")]
        public long Points { get; set; }

        [JsonProperty(PropertyName = "cayman")]
        public long Cayman { get; set; }

        [JsonProperty(PropertyName = "vault")]
        public long Vault { get; set; }

        [JsonProperty(PropertyName = "piggybank")]
        public long PiggyBank { get; set; }

        [JsonProperty(PropertyName = "items")]
        public long Items { get; set; }

        [JsonProperty(PropertyName = "displaycase")]
        public long DisplayCase { get; set; }

        [JsonProperty(PropertyName = "bazaar")]
        public long Bazaar { get; set; }

        [JsonProperty(PropertyName = "itemmarket")]
        public long ItemMarket { get; set; }

        [JsonProperty(PropertyName = "properties")]
        public long Properties { get; set; }

        [JsonProperty(PropertyName = "stockmarket")]
        public long StockMarket { get; set; }

        [JsonProperty(PropertyName = "auctionhouse")]
        public long AuctionHouse { get; set; }

        [JsonProperty(PropertyName = "company")]
        public long Company { get; set; }

        [JsonProperty(PropertyName = "bookie")]
        public long Bookie { get; set; }

        [JsonProperty(PropertyName = "enlistedcars")]
        public long EnlistedCars { get; set; }

        [JsonProperty(PropertyName = "loan")]
        public long Loan { get; set; }

        [JsonProperty(PropertyName = "unpaidfees")]
        public long UnpaidFees { get; set; }

        [JsonProperty(PropertyName = "total")]
        public long Total { get; set; }

        [JsonProperty(PropertyName = "parsetime")]
        public float ParseTime { get; set; }
    }
}
