using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class States
    {
        [JsonProperty(PropertyName = "hospital_timestamp")]
        public long HospitalTimestamp { get; set; }

        [JsonProperty(PropertyName = "jail_timestamp")]
        public long JailTimestamp { get; set; }
    }
}
