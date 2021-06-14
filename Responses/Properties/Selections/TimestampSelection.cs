using Newtonsoft.Json;

namespace TornAPI.Responses.Properties.Selections
{
    public class TimestampSelection : IPropertySelection
    {
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.PropertySelections.Timestamp.ToString();
        }
    }
}
