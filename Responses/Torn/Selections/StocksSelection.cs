using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class StocksSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "stocks")]
        public Dictionary<int, Stock> Stocks { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Stocks.ToString();
        }
    }
}
