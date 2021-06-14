using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.BaseClasses
{
    public class JobPoints
    {
        [JsonProperty(PropertyName = "jobs")]
        public Dictionary<string, int> Jobs { get; set; }

        [JsonProperty(PropertyName = "companies")]
        public Dictionary<int, CompanyJobPoints> Companies { get; set; }
    }
}
