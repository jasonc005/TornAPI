using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.Selections
{
    public class LogTypesSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "logtypes")]
        public Dictionary<int, string> LogTypes { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.LogTypes.ToString();
        }
    }
}
