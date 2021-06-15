using Newtonsoft.Json;

namespace TornAPI.Responses.ItemMarket.Selections
{
    public class TimestampSelection : IItemMarketSelection
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.ItemMarketSelections.Timestamp.ToString();
        }
    }
}
