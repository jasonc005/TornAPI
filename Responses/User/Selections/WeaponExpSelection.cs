using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class WeaponExpSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "weaponexp")]
        public List<WeaponExperience> WeaponExperiences { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.WeaponExp.ToString();
        }
    }
}
