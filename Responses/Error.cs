using Newtonsoft.Json;

namespace TornAPI.Responses
{
    public class Error
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string ErrorMessage { get; set; }
    }
}
