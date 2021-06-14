using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class ReceivedEventsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "receivedevents")]
        public Dictionary<long, ReceivedEvent> ReceivedEvents { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.ReceivedEvents.ToString();
        }
    }
}
