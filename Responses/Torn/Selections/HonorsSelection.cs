using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class HonorsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "honors")]
        public Dictionary<int, Honor> Honors { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Honors.ToString();
        }
    }
}
