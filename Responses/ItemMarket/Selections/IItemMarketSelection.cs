using Newtonsoft.Json;

namespace TornAPI.Responses.ItemMarket.Selections
{
    public interface IItemMarketSelection
    {
        [JsonProperty(PropertyName = "error")]
        Error Error { get; set; }

        string GetSelectionName();
    }
}
