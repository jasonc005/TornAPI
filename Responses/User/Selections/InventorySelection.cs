using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class InventorySelection : IUserSelection
    {
        [JsonProperty(PropertyName = "inventory")]
        public List<InventoryItem> Inventory { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Inventory.ToString();
        }
    }
}
