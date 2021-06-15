using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.ItemMarket.BaseClasses;

namespace TornAPI.Responses.ItemMarket.Selections
{
    public class PointsMarketSelection : IItemMarketSelection
    {
        [JsonProperty(PropertyName = "pointsmarket")]
        public Dictionary<long, PointsListing> PointsMarket { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.ItemMarketSelections.PointsMarket.ToString();
        }
    }
}
