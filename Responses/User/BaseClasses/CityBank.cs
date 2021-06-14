using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class CityBank
    {
        [JsonProperty(PropertyName = "amount")]
        public long Amount { get; set; }

        [JsonProperty(PropertyName = "time_left")]
        public long TimeLeft { get; set; }
    }
}
