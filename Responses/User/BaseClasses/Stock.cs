using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Stock
    {
        [JsonProperty(PropertyName = "stock_id")]
        public int StockID { get; set; }

        [JsonProperty(PropertyName = "total_shares")]
        public long TotalShares { get; set; }

        [JsonProperty(PropertyName = "dividend")]
        public StockDividend Dividend { get; set; }

        [JsonProperty(PropertyName = "transactions")]
        public Dictionary<long, StockTransaction> Transactions { get; set; }
    }
}
