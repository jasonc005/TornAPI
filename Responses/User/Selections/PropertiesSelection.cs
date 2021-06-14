using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class PropertiesSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "properties")]
        public Dictionary<long, Property> Properties { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Properties.ToString();
        }
    }
}
