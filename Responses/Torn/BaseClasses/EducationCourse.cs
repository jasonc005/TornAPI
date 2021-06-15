using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class EducationCourse
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "money_cost")]
        public int MoneyCost { get; set; }

        [JsonProperty(PropertyName = "tier")]
        public int Tier { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "results")]
        public EducationResult Results { get; set; }

        [JsonProperty(PropertyName = "prerequisites")]
        public List<int> Prerequisites { get; set; }
    }
}
