using Newtonsoft.Json;
using TornAPI.Responses.Properties.BaseClasses;

namespace TornAPI.Responses.Properties.Selections
{
    public class PropertySelection : IPropertySelection
    {
        [JsonProperty(PropertyName = "property")]
        public Property Property { get; set; }

        public string GetSelectionName()
        {
            return SelectionEnums.PropertySelections.Property.ToString();
        }
    }
}
