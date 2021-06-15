using Newtonsoft.Json;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class BankSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "bank")]
        public Bank Bank { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Bank.ToString();
        }
    }
}
