using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TornAPI.Responses.User.Selections
{
    public class ReportsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "reports")]
        public JObject Reports { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Reports.ToString();
        }
    }
}
