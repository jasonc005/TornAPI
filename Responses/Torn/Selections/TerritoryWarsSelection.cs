using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class TerritoryWarsSelection
    {
        [JsonProperty(PropertyName = "territorywars")]
        public Dictionary<string, TerritoryWar> TerritoryWars { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.TerritoryWars.ToString();
        }
    }
}
