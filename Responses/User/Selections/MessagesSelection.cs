using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class MessagesSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "messages")]
        public Dictionary<long, Message> Messages { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Messages.ToString();
        }
    }
}
