using Newtonsoft.Json;

namespace TornAPI.Responses.User.BaseClasses
{
    public class CriminalRecord
    {
        [JsonProperty(PropertyName = "selling_illegal_products")]
        public int SellingIllegalProducts { get; set; }

        [JsonProperty(PropertyName = "theft")]
        public int Theft { get; set; }

        [JsonProperty(PropertyName = "auto_theft")]
        public int AutoTheft { get; set; }

        [JsonProperty(PropertyName = "drug_deals")]
        public int DrugDeals { get; set; }

        [JsonProperty(PropertyName = "computer_crimes")]
        public int ComputerCrimes { get; set; }

        [JsonProperty(PropertyName = "murder")]
        public int Murder { get; set; }

        [JsonProperty(PropertyName = "fraud_crimes")]
        public int FraudCrimes { get; set; }

        [JsonProperty(PropertyName = "other")]
        public int Other { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
    }
}
