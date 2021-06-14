using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class MedalsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "medals_awarded")]
        public List<int> MedalsAwarded { get; set; }

        [JsonProperty(PropertyName = "medals_time")]
        public List<long> MedalsTime { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Medals.ToString();
        }
    }
}
