using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class BazaarSelection : UserSelectionBase
    {
        [JsonProperty(PropertyName = "bazaar")]
        public List<BazaarItem> Bazaar { get; set; }
    }
}
