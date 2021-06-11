using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class EventsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "events")]
        public Dictionary<long,Event> Events { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Events.ToString();
        }
    }
}
