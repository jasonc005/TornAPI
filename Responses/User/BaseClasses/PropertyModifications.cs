using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class PropertyModifications
    {
        [JsonProperty(PropertyName = "interior")]
        public int Interior { get; set; }

        [JsonProperty(PropertyName = "hot_tub")]
        public int HotTub { get; set; }

        [JsonProperty(PropertyName = "sauna")]
        public int Sauna { get; set; }

        [JsonProperty(PropertyName = "pool")]
        public int Pool { get; set; }

        [JsonProperty(PropertyName = "open_bar")]
        public int OpenBar { get; set; }

        [JsonProperty(PropertyName = "shooting_range")]
        public int ShootingRange { get; set; }

        [JsonProperty(PropertyName = "vault")]
        public int Vault { get; set; }

        [JsonProperty(PropertyName = "medical_facility")]
        public int MedicalFacility { get; set; }

        [JsonProperty(PropertyName = "airstrip")]
        public int Airstrip { get; set; }

        [JsonProperty(PropertyName = "yacht")]
        public int Yacht { get; set; }
    }
}
