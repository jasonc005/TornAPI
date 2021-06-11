using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class Discord
    {
        [JsonProperty(PropertyName = "userID")]
        public long UserID { get; set; }

        [JsonProperty(PropertyName = "discordID")]
        public string DiscordID { get; set; }
    }
}
