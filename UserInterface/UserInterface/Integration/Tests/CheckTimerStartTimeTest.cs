using UserInterface.Integration.Pages;
using UserInterface.Integration.Pages.GamePage;

namespace Userinterface.Integration.Tests
{
    public class CheckTimerStartTimeTest : BaseTest
    {
        [Test]
        public void CheckTimerStartTime()
        {
            var homePage = new HomePage();
            homePage.GoToRegistrationPage();

            var gamePage = new GamePage();
            Assert.That(gamePage.GetValueTimer() == testData.CheckTimerStartTimeTest.StartTimerValue, 
                $"Время старта таймера не равно {testData.CheckTimerStartTimeTest.StartTimerValue}");
        }
    }
}
