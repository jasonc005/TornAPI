using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Property
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public int Cost { get; set; }

        [JsonProperty(PropertyName = "happy")]
        public int Happy { get; set; }

        [JsonProperty(PropertyName = "upkeep")]
        public int Upkeep { get; set; }

        [JsonProperty(PropertyName = "upgrades_available")]
        public List<string> UpgradesAvailable { get; set; }

        [JsonProperty(PropertyName = "staff_available")]
        public List<string> StaffAvailable { get; set; }
    }
}
