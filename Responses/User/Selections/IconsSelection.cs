using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class IconsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "icons")]
        public Dictionary<string, string> Icons { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Icons.ToString();
        }
    }
}
