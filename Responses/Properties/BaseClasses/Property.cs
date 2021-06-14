using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Properties.BaseClasses
{
    public class Property
    {
        [JsonProperty(PropertyName = "owner_id")]
        public long OwnerID { get; set; }

        [JsonProperty(PropertyName = "property_type")]
        public int PropertyType { get; set; }

        [JsonProperty(PropertyName = "happy")]
        public int Happy { get; set; }

        [JsonProperty(PropertyName = "upkeep")]
        public int Upkeep { get; set; }

        [JsonProperty(PropertyName = "upgrades")]
        public List<string> Upgrades { get; set; }

        [JsonProperty(PropertyName = "staff")]
        public List<string> Staff { get; set; }

        [JsonProperty(PropertyName = "rented")]
        public Rented Rented { get; set; }

        [JsonProperty(PropertyName = "users_living")]
        public string UsersLiving { get; set; }
    }
}
