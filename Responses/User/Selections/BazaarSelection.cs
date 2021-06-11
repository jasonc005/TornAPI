using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class BazaarSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "bazaar")]
        public List<BazaarItem> Bazaar { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Bazaar.ToString();
        }
    }
}
