using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class DisplayCaseSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "display")]
        public List<DisplayCaseItem> DisplayCase { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Display.ToString();
        }
    }
}
