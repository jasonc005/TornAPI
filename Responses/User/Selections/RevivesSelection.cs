using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class RevivesSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "revives")]
        public Dictionary<long, Revive> Revives { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Revives.ToString();
        }
    }
}
