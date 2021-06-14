using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class ProfileSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "rank")]
        public string Rank { get; set; }

        [JsonProperty(PropertyName = "level")]
        public int Level { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "property")]
        public string Property { get; set; }

        [JsonProperty(PropertyName = "signup")]
        public string SignUpDate { get; set; }

        [JsonProperty(PropertyName = "awards")]
        public int Awards { get; set; }

        [JsonProperty(PropertyName = "friends")]
        public int Friends { get; set; }

        [JsonProperty(PropertyName = "enemies")]
        public int Enemies { get; set; }

        [JsonProperty(PropertyName = "forum_posts")]
        public int ForumPosts { get; set; }

        [JsonProperty(PropertyName = "karma")]
        public int Karma { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "donator")]
        public bool Donator { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public long PlayerID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "property_id")]
        public long PropertyID { get; set; }

        [JsonProperty(PropertyName = "competition")]
        public JObject Competition { get; set; }

        [JsonProperty(PropertyName = "life")]
        public LifeBar Life { get; set; }

        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }

        [JsonProperty(PropertyName = "job")]
        public Job Job { get; set; }

        [JsonProperty(PropertyName = "faction")]
        public Faction Faction { get; set; }

        [JsonProperty(PropertyName = "married")]
        public Married Married { get; set; }

        [JsonProperty(PropertyName = "basicicons")]
        public Dictionary<string, string> BasicIcons { get; set; }

        [JsonProperty(PropertyName = "states")]
        public States States { get; set; }

        [JsonProperty(PropertyName = "last_action")]
        public LastAction LastAction { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Profile.ToString();
        }
    }
}
