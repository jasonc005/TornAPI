using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class PersonalStatsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "personalstats")]
        public Dictionary<string, long> PersonalStats { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.PersonalStats.ToString();
        }
    }
}
