using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class WeaponExperience
    {
        [JsonProperty(PropertyName = "itemID")]
        public int ItemID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "exp")]
        public int Experience { get; set; }
    }
}
