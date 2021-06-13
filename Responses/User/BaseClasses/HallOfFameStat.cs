using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class HallOfFameStat
    {
        [JsonProperty(PropertyName = "value")]
        public long Value { get; set; }

        [JsonProperty(PropertyName = "rank")]
        public int Rank { get; set; }
    }
}
