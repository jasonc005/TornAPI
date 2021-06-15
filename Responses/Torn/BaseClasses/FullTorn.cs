using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class FullTorn
    {
        [JsonProperty(PropertyName = "bank")]
        public Bank Bank { get; set; }

        [JsonProperty(PropertyName = "cards")]
        public Dictionary<int, Card> Cards { get; set; }

        [JsonProperty(PropertyName = "companies")]
        public Dictionary<int, Company> Companies { get; set; }

        [JsonProperty(PropertyName = "education")]
        public Dictionary<int, EducationCourse> Education { get; set; }


    }
}
