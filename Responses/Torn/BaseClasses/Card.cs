using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Card
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        [JsonProperty(PropertyName = "short")]
        public int Short { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "suit")]
        public string Suit { get; set; }
    }
}
