using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class CooldownsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "cooldowns")]
        public Cooldowns Cooldowns { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Cooldowns.ToString();
        }
    }
}
