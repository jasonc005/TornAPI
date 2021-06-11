using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class DiscordSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "discord")]
        public Discord Discord { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Discord.ToString();
        }
    }
}
