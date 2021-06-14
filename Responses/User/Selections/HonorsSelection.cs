using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class HonorsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "honors_awarded")]
        public List<int> HonorsAwarded { get; set; }

        [JsonProperty(PropertyName = "honors_time")]
        public List<long> HonorsTime { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Honors.ToString();
        }
    }
}
