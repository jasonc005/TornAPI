using Newtonsoft.Json;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class PawnShopSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "pawnshop")]
        public PawnShop PawnShop { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.PawnShop.ToString();
        }
    }
}
