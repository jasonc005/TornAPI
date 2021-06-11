using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class BarsSelection : IUserSelection
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

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Bars.ToString();
        }
    }
}
