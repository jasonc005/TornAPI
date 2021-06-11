using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class EducationSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "education_current")]
        public int CurrentEducationID { get; set; }

        [JsonProperty(PropertyName = "education_timeleft")]
        public int EducationTimeLeft { get; set; }

        [JsonProperty(PropertyName = "education_completed")]
        public List<int> CompletedEducations { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Education.ToString();
        }
    }
}
