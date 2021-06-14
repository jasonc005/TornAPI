using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public interface IUserSelection
    {
        [JsonProperty(PropertyName = "error")]
        Error Error { get; set; }

        string GetSelectionName();
    }
}
