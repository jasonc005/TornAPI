using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.ItemMarket.BaseClasses;

namespace TornAPI.Responses.ItemMarket.Selections
{
    public class ItemMarketSelection : IItemMarketSelection
    {
        [JsonProperty(PropertyName = "itemmarket")]
        public List<MarketItem> ItemMarket { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.ItemMarketSelections.ItemMarket.ToString();
        }
    }
}
