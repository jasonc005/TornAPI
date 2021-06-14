using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public class TimestampSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Timestamp.ToString();
        }
    }
}
