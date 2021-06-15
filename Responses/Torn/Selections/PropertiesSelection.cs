using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class PropertiesSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "properties")]
        public Dictionary<int, Property> Properties { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Properties.ToString();
        }
    }
}
