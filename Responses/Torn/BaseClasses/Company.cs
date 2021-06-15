using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Company
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public long Cost { get; set; }

        [JsonProperty(PropertyName = "default_employees")]
        public int DefaultEmployees { get; set; }

        [JsonProperty(PropertyName = "positions")]
        public Dictionary<string, CompanyPosition> Positions { get; set; }

        [JsonProperty(PropertyName = "stock")]
        public Dictionary<string, CompanyStock> Stock { get; set; }

        [JsonProperty(PropertyName = "specials")]
        public Dictionary<string, CompanySpecial> Specials { get; set; }
    }
}
