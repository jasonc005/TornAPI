using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class JobPointsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "jobpoints")]
        public JobPoints JobPoints { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.JobPoints.ToString();
        }
    }
}
