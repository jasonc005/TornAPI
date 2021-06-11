using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public class BarsSelection : UserSelectionBase
    {
        [JsonProperty(PropertyName = "server_time")]
        public long? ServerTime { get; set; }

        [JsonProperty(PropertyName = "happy")]
        public HappyBar Happy { get; set; }

        [JsonProperty(PropertyName = "life")]
        public LifeBar Life { get; set; }

        [JsonProperty(PropertyName = "energy")]
        public EnergyBar Energy { get; set; }

        [JsonProperty(PropertyName = "nerve")]
        public NerveBar Nerve { get; set; }

        [JsonProperty(PropertyName = "chain")]
        public Chain Chain { get; set; }
    }
}
