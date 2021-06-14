using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class PropertyStaff
    {
        [JsonProperty(PropertyName = "maid")]
        public int Maid { get; set; }

        [JsonProperty(PropertyName = "guard")]
        public int Guard { get; set; }

        [JsonProperty(PropertyName = "pilot")]
        public int Pilot { get; set; }

        [JsonProperty(PropertyName = "butler")]
        public int Butler { get; set; }

        [JsonProperty(PropertyName = "doctor")]
        public int Doctor { get; set; }
    }
}
