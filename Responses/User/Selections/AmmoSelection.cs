using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class AmmoSelection : UserSelectionBase
    {
        [JsonProperty(PropertyName = "ammo")]
        public List<Ammo> Ammo { get; set; }
    }
}
