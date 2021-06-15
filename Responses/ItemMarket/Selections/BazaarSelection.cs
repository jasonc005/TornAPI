using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.ItemMarket.BaseClasses;

namespace TornAPI.Responses.ItemMarket.Selections
{
    public class BazaarSelection : IItemMarketSelection
    {
        [JsonProperty(PropertyName = "bazaar")]
        public List<MarketItem> Bazaar { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.ItemMarketSelections.Bazaar.ToString();
        }
    }
}
