using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.Torn.Selections
{
    public class CompaniesSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "companies")]
        public Dictionary<int, BaseClasses.Company> Companies { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Companies.ToString();
        }
    }
}
