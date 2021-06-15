using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class TerritorySelection
    {
        [JsonProperty(PropertyName = "territory")]
        public Dictionary<string, Territory> Territories { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Territory.ToString();
        }
    }
}
