using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class CompanyJobPoints
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "jobpoints")]
        public int JobPoints { get; set; }
    }
}
