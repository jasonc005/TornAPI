using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class NotificationsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "notifications")]
        public Notifications Notifications { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Notifications.ToString();
        }
    }
}
