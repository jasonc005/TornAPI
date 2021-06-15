using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class EducationResult
    {
        [JsonProperty(PropertyName = "perk")]
        public List<string> Perk { get; set; }

        [JsonProperty(PropertyName = "manual_labor")]
        public List<string> ManualLabor { get; set; }

        [JsonProperty(PropertyName = "intelligence")]
        public List<string> Intelligence { get; set; }

        [JsonProperty(PropertyName = "endurance")]
        public List<string> Endurance { get; set; }
    }
}
