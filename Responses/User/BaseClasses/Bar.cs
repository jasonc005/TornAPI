using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Bar
    {
        [JsonProperty(PropertyName = "current")]
        public int Current { get; set; }

        [JsonProperty(PropertyName = "maximum")]
        public int Maximum { get; set; }

        [JsonProperty(PropertyName = "increment")]
        public int Increment { get; set; }

        [JsonProperty(PropertyName = "interval")]
        public int Interval { get; set; }

        [JsonProperty(PropertyName = "ticktime")]
        public int TickTime { get; set; }

        [JsonProperty(PropertyName = "fulltime")]
        public int FullTime { get; set; }
    }

    public class HappyBar : Bar
    {
    }

    public class LifeBar : Bar
    {
    }

    public class EnergyBar : Bar
    {
    }

    public class NerveBar : Bar
    {
    }
}
