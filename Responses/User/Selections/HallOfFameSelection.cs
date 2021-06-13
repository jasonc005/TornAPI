using Newtonsoft.Json;
using System.Collections.Generic;
using TornAPI.Responses.User.BaseClasses;

namespace TornAPI.Responses.User.Selections
{
    public class HallOfFameSelection : IUserSelection
    {
        [JsonProperty(PropertyName = "halloffame")]
        public Dictionary<string, HallOfFameStat> HallOfFame { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.UserSelections.Hof.ToString();
        }
    }
}
