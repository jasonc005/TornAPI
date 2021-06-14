using Newtonsoft.Json;

namespace TornAPI.Responses.Properties.Selections
{
    public interface IPropertySelection
    {
        [JsonProperty(PropertyName = "error")]
        Error Error { get; set; }

        string GetSelectionName();
    }
}
