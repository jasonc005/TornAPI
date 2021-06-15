using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class FactionTreeSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "factiontree")]
        public Dictionary<int, Dictionary<int, FactionPerk>> FactionTree { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.FactionTree.ToString();
        }
    }
}
