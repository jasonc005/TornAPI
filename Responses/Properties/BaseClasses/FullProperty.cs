using Newtonsoft.Json;

namespace TornAPI.Responses.Properties.BaseClasses
{
    public class FullProperty
    {
        [JsonProperty(PropertyName = "property")]
        public Property Property { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
    }
}
