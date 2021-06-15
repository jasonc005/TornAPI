using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class GymsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "gyms")]
        public Dictionary<int, Gym> Gyms { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Gyms.ToString();
        }
    }
}
