using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class AmmoSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "ammo")]
        public List<Ammo> Ammo { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Ammo.ToString();
        }
    }
}
