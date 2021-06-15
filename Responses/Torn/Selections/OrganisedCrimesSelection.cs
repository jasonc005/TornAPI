using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class OrganisedCrimesSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "organisedcrimes")]
        public Dictionary<int, OrganisedCrime> OrganisedCrimes { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.OrganisedCrimes.ToString();
        }
    }
}
