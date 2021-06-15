using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class PawnShop
    {
        [JsonProperty(PropertyName = "points_value")]
        public int PointsValue { get; set; }

        [JsonProperty(PropertyName = "donatorpack_value")]
        public int DonatorPackValue { get; set; }
    }
}
