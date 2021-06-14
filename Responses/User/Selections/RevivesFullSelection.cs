using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class RevivesFullSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "revives")]
        public Dictionary<long, ReviveFull> Revives { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.RevivesFull.ToString();
        }
    }
}
