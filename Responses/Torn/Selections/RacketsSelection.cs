using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class RacketsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "rackets")]
        public Dictionary<string, Racket> Rackets { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Rackets.ToString();
        }
    }
}
