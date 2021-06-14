using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Job
    {
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "company_id")]
        public int CompanyID { get; set; }

        [JsonProperty(PropertyName = "company_name")]
        public string CompanyName { get; set; }

        [JsonProperty(PropertyName = "company_type")]
        public int CompanyType { get; set; }
    }
}
