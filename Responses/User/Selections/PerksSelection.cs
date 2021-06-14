using Newtonsoft.Json;
using System.Collections.Generic;

namespace TornAPI.Responses.User.Selections
{
    public class PerksSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "job_perks")]
        public List<string> JobPerks { get; set; }

        [JsonProperty(PropertyName = "property_perks")]
        public List<string> PropertyPerks { get; set; }

        [JsonProperty(PropertyName = "stock_perks")]
        public List<string> StockPerks { get; set; }

        [JsonProperty(PropertyName = "merit_perks")]
        public List<string> MeritPerks { get; set; }

        [JsonProperty(PropertyName = "education_perks")]
        public List<string> EducationPerks { get; set; }

        [JsonProperty(PropertyName = "enhancer_perks")]
        public List<string> EnhancerPerks { get; set; }

        [JsonProperty(PropertyName = "company_perks")]
        public List<string> CompanyPerks { get; set; }

        [JsonProperty(PropertyName = "faction_perks")]
        public List<string> FactionPerks { get; set; }

        [JsonProperty(PropertyName = "book_perks")]
        public List<string> BookPerks { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Perks.ToString();
        }
    }
}
