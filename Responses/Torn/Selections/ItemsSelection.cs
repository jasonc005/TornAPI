using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class ItemsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "items")]
        public Dictionary<int, Item> Items { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Items.ToString();
        }
    }
}
