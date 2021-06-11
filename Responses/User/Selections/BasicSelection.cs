using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class BasicSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "level")]
        public int? Level { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public long? PlayerID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Basic.ToString();
        }
    }
}
