using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public class GymSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "active_gym")]
        public int ActiveGym { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Gym.ToString();
        }
    }
}
