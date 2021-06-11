using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public class CooldownsSelection : UserSelectionBase
    {
        [JsonProperty(PropertyName = "cooldowns")]
        public Cooldowns Cooldowns { get; set; }
    }
}
