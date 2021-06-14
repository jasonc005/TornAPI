using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class MeritsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "merits")]
        public Dictionary<string, int> Merits { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Merits.ToString();
        }
    }
}
