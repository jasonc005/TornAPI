using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Married
    {
        [JsonProperty(PropertyName = "spouse_id")]
        public long SpouseID { get; set; }

        [JsonProperty(PropertyName = "spouse_name")]
        public string SpouseName { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }
    }
}
