using Newtonsoft.Json;

namespace TornAPI.Responses.User.Selections
{
    public class SkillsSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "hunting")]
        public string Hunting { get; set; }

        [JsonProperty(PropertyName = "racing")]
        public string Racing { get; set; }

        [JsonProperty(PropertyName = "reviving")]
        public string Reviving { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public long PlayerID { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Skills.ToString();
        }
    }
}
