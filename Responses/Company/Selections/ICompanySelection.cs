using Newtonsoft.Json;

namespace TornAPI.Responses.Company.Selections
{
    public interface ICompanySelection
    {
        [JsonProperty(PropertyName = "error")]
        Error Error { get; set; }

        string GetSelectionName();
    }
}
