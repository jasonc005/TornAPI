using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class CompanySpecial
    {
        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public int Cost { get; set; }

        [JsonProperty(PropertyName = "rating_required")]
        public int RatingRequired { get; set; }
    }
}
