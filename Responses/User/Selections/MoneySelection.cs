using Newtonsoft.Json;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class MoneySelection : IUserSelection
    {
        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }

        [JsonProperty(PropertyName = "cayman_bank")]
        public long CaymanBank { get; set; }

        [JsonProperty(PropertyName = "vault_amount")]
        public long VaultAmount { get; set; }

        [JsonProperty(PropertyName = "daily_networth")]
        public long DailyNetWorth { get; set; }

        [JsonProperty(PropertyName = "money_onhand")]
        public long MoneyOnHand { get; set; }

        [JsonProperty(PropertyName = "city_bank")]
        public CityBank CityBank { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Money.ToString();
        }
    }
}
