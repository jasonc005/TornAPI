using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class StocksSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "stocks")]
        public Dictionary<int, Stock> Stocks { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Stocks.ToString();
        }
    }
}
