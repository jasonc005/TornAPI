using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class MedalsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "medals")]
        public Dictionary<int, Medal> Medals { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Medals.ToString();
        }
    }
}
