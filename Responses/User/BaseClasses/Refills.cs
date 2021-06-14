using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Refills
    {
        [JsonProperty(PropertyName = "energy_refill_used")]
        public bool EnergyRefillUsed { get; set; }

        [JsonProperty(PropertyName = "nerve_refill_used")]
        public bool NerveRefillUsed { get; set; }

        [JsonProperty(PropertyName = "token_refill_used")]
        public bool TokenRefillUsed { get; set; }

        [JsonProperty(PropertyName = "special_refills_available")]
        public int SpecialRefillsAvailable { get; set; }
    }
}
