using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class RefillsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "refills")]
        public Refills Refills { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Refills.ToString();
        }
    }
}
