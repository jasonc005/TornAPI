using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.Selections
{
    public class StatsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "stats")]
        public Dictionary<string, string> Stats { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Stats.ToString();
        }
    }
}
