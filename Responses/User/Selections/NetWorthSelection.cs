using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class NetWorthSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "networth")]
        public NetWorth NetWorth { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.NetWorth.ToString();
        }
    }
}
