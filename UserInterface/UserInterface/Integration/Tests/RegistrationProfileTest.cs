using UserInterface.Integration.Pages;
using UserInterface.Integration.Pages.GamePage;
using UserInterface.Integration.Steps;

namespace Userinterface.Integration.Tests
{
    public class RegistrationProfileTest : BaseTest
    {
        [Test]
        public void RegistrationProfile()
        {
            var homePage = new HomePage();
            Assert.That(homePage.State.WaitForDisplayed(), "Home Page не открыта");

            homePage.GoToRegistrationPage();
            var gamePage = new GamePage();
            var registrationPage = new RegistrationPage();
            Assert.That(registrationPage.State.WaitForDisplayed(), "Страница регистрации не открыта");

            RegistrationPageSteps.FillCredentialEmailAndPass(
                testData.RegistrationProfileTest.PasswordLength,
                testData.RegistrationProfileTest.NameEmailLength,
                testData.RegistrationProfileTest.DomainNameLength,
                registrationPage.topLevelDomain);

            registrationPage.UncheckAcceptTermConditions();
            registrationPage.ClickNextRegistrationPageButton();

            var profileInterestsPage = new ProfileInterestsPage();
            Assert.That(profileInterestsPage.State.WaitForDisplayed(), "Страница редактирования интересов не открыта");

            profileInterestsPage.UnselectAllCheckbox();

            ProfileInterestsPageSteps.SelectRandomChooseInterests(testData.RegistrationProfileTest.CountSelectedInterests);

            profileInterestsPage.ClickUploadProfileImage();
            profileInterestsPage.UploadProfileImage(testData.RegistrationProfileTest.PathAvatarFile);
            profileInterestsPage.ClickNextRegistrationPageButton();

            var profilePersonalDetailsPage = new ProfilePersonalDetailsPage();
            Assert.That(profilePersonalDetailsPage.State.WaitForDisplayed(), "Страница редактирования личных данных не открыта");
        }
    }
}