using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class TravelSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "travel")]
        public Travel Travel { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Travel.ToString();
        }
    }
}
