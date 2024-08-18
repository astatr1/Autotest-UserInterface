using Aquality.Selenium.Browsers;
using UserInterface.Integration.Pages.GamePage.Forms;

namespace UserInterface.Integration.Steps
{
    public static class HelpFormSteps
    {
        private static readonly HelpForm HelpForm = new();

        public static bool WaitHelpFormToHidden(string unitMeasure, int minHeightHelpForm)
        {
            return AqualityServices.ConditionalWait.WaitFor(() =>
            {
                var currentHeight = HelpForm.GetCurrentHeightForm(unitMeasure);
                return currentHeight <= minHeightHelpForm;
            });
        }
    }
}
