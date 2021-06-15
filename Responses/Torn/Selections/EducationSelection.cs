using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class EducationSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "education")]
        public Dictionary<int, EducationCourse> Education { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Education.ToString();
        }
    }
}
