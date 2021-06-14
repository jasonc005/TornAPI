using Newtonsoft.Json;

namespace TornAPI.Responses.Faction.Selections
{
    public interface IFactionSelection
    {
        [JsonProperty(PropertyName = "error")]
        Error Error { get; set; }

        string GetSelectionName();
    }
}
