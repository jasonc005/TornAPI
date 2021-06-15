using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class RaidsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "raids")]
        public Dictionary<int, Raid> Raids { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Raids.ToString();
        }
    }
}
