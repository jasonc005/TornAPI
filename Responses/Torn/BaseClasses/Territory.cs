using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class Territory
    {
        [JsonProperty(PropertyName = "sector")]
        public int Sector { get; set; }

        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }

        [JsonProperty(PropertyName = "density")]
        public int Density { get; set; }

        [JsonProperty(PropertyName = "daily_respect")]
        public int DailyRespect { get; set; }

        [JsonProperty(PropertyName = "faction")]
        public int Faction { get; set; }

        [JsonProperty(PropertyName = "coordinate_x")]
        public string CoordinateX { get; set; }

        [JsonProperty(PropertyName = "coordinate_y")]
        public string CoordinateY { get; set; }
    }
}
