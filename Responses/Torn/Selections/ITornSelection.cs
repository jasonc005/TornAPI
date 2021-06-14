using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.Selections
{
    public interface ITornSelection
    {
        [JsonProperty(PropertyName = "error")]
        Error Error { get; set; }

        string GetSelectionName();
    }
}
