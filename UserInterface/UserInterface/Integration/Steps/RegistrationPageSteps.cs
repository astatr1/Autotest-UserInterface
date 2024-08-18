using UserInterface.Integration.Pages;
using UserInterface.Integration.Utils;

namespace UserInterface.Integration.Steps
{
    public static class RegistrationPageSteps
    {
        private static readonly RegistrationPage RegistrationPage = new();

        public static void FillCredentialEmailAndPass(int passwordLength, int nameEmailLength, int domainNameLength, string[] topLevelDomain)
        {
            RandomUtility.GeneratorRandomEmailAndPass(passwordLength, nameEmailLength, domainNameLength, topLevelDomain,
                out string password, out string nameEmail, out string domainName, out string domain);

            RegistrationPage.FillPassword(password);
            RegistrationPage.FillNameEmail(nameEmail);
            RegistrationPage.FillDomain(domainName);
            RegistrationPage.ClickTopLevelDomainCheckBox();
            RegistrationPage.SelectTopLevelDomain(domain);
        }
    }
}
