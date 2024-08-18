using UserInterface.Integration.Pages;
using UserInterface.Integration.Pages.GamePage;

namespace Userinterface.Integration.Tests
{
    public class AcceptingCookiesTest : BaseTest
    {
        [Test]
        public void AcceptingCookies()
        {
            var homePage = new HomePage();
            Assert.That(homePage.State.WaitForDisplayed(), "Home Page не открыта");

            homePage.GoToRegistrationPage();

            var gamePage = new GamePage();
            gamePage.CookiesForm.AcceptCookies();
            Assert.That(gamePage.CookiesForm.State.WaitForNotDisplayed(), "Форма принятия cookies не закрыта");
        }
    }
}