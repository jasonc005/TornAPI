using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Ammo
    {
        [JsonProperty(PropertyName = "ammoID")]
        public int AmmoID { get; set; }
        
        [JsonProperty(PropertyName = "typeID")]
        public int TypeID { get; set; }
        
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }
        
        [JsonProperty(PropertyName = "equipped")]
        public bool Equipped { get; set; }
    }
}
