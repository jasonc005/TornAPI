using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class LogSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "log")]
        public Dictionary<string, LogEntry> Log { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Log.ToString();
        }
    }
}
