using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public class WorkStatsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "manual_labor")]
        public int ManualLabor { get; set; }

        [JsonProperty(PropertyName = "intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty(PropertyName = "endurance")]
        public int Endurance { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.WorkStats.ToString();
        }
    }
}
