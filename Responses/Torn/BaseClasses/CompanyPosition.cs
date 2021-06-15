using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.BaseClasses
{
    public class CompanyPosition
    {
        [JsonProperty(PropertyName = "man_required")]
        public int ManRequired { get; set; }

        [JsonProperty(PropertyName = "int_required")]
        public int IntRequired { get; set; }

        [JsonProperty(PropertyName = "end_required")]
        public int EndRequired { get; set; }

        [JsonProperty(PropertyName = "man_gain")]
        public int ManGain { get; set; }

        [JsonProperty(PropertyName = "int_gain")]
        public int IntGain { get; set; }

        [JsonProperty(PropertyName = "end_gain")]
        public int EndGain { get; set; }

        [JsonProperty(PropertyName = "special_ability")]
        public string SpecialAbility { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
