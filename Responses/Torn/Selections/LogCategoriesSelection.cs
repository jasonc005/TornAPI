using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.Selections
{
    public class LogCategoriesSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "logcategories")]
        public Dictionary<int, string> LogCategories { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.LogCategories.ToString();
        }
    }
}
