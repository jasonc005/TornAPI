using Newtonsoft.Json;

namespace TornAPI.Responses.Torn.Selections
{
    public class TimestampSelection : ITornSelection
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Timestamp.ToString();
        }
    }
}
