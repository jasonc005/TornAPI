using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class CrimesSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "criminalrecord")]
        public CriminalRecord CriminalRecord { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Crimes.ToString();
        }
    }
}
