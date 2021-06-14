using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Property
    {
        [JsonProperty(PropertyName = "owner_id")]
        public long OwnerID { get; set; }

        [JsonProperty(PropertyName = "property_type")]
        public int PropertyType { get; set; }

        [JsonProperty(PropertyName = "property")]
        public string PropertyName { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "happy")]
        public int Happy { get; set; }

        [JsonProperty(PropertyName = "upkeep")]
        public int Upkeep { get; set; }

        [JsonProperty(PropertyName = "staff_cost")]
        public int StaffCost { get; set; }

        [JsonProperty(PropertyName = "cost")]
        public long Cost { get; set; }

        [JsonProperty(PropertyName = "marketprice")]
        public long MarketPrice { get; set; }

        [JsonProperty(PropertyName = "modifications")]
        public PropertyModifications Modifications { get; set; }

        [JsonProperty(PropertyName = "staff")]
        public PropertyStaff Staff { get; set; }
    }
}
