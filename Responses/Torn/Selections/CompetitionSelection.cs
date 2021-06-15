namespace TornAPI.Responses.Torn.Selections
{
    public class CompetitionSelection : ITornSelection
    {
        // TODO: Figure out what response looks like when we actually have one

        public string GetSelectionName()
        {
            return SelectionEnums.TornSelections.Competition.ToString();
        }
    }
}
