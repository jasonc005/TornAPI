using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.Torn.BaseClasses;

namespace TornAPI.Responses.Torn.Selections
{
    public class CardsSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "cards")]
        public Dictionary<int, Card> Cards { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Cards.ToString();
        }
    }
}
