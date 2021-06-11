using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class AttacksSelection : UserSelectionBase
    {
        [JsonProperty(PropertyName = "attacks")]
        public Dictionary<string, Attack> Attacks { get; set; }
    }
}
