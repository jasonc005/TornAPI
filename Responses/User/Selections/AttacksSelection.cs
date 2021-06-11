using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class AttacksSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "attacks")]
        public Dictionary<string, Attack> Attacks { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Attacks.ToString();
        }
    }
}
