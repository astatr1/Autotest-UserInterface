using UserInterface.Integration.Pages;
using UserInterface.Integration.Pages.GamePage;
using UserInterface.Integration.Steps;

namespace Userinterface.Integration.Tests
{
    public class HiddenHelpFormTest : BaseTest
    {
        [Test]
        public void HiddenHelpForm()
        {
            var homePage = new HomePage();
            Assert.That(homePage.State.WaitForDisplayed(), "Home Page не открыта");

            homePage.GoToRegistrationPage();

            var gamePage = new GamePage();
            gamePage.HelpForm.ClickButtonSendToBottom();

            Assert.True(HelpFormSteps.WaitHelpFormToHidden(
                testData.HiddenHelpFormTest.UnitMeasure.ToString(),
                testData.HiddenHelpFormTest.MinHeightHelpForm),
                "Форма помощи не скрыта");
        }
    }
}
