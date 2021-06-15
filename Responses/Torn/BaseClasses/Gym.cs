using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Gym
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "stage")]
        public int Stage { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public long Cost { get; set; }

        [JsonProperty(PropertyName = "energy")]
        public int Energy { get; set; }

        [JsonProperty(PropertyName = "strength")]
        public int Strength { get; set; }

        [JsonProperty(PropertyName = "speed")]
        public int Speed { get; set; }

        [JsonProperty(PropertyName = "defense")]
        public int Defense { get; set; }

        [JsonProperty(PropertyName = "dexterity")]
        public int Dexterity { get; set; }

        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }
    }
}
