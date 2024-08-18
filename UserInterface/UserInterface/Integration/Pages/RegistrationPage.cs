using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterface.Integration.Pages
{
    public class RegistrationPage : Form
    {
        private ICheckBox AcceptTermConditionCheckBox => ElementFactory.GetCheckBox(By.XPath("//*[contains(@class,'checkbox__box')]"), "Inversion of acceptance of conditions");
        private IButton NextRegistrationPageButton => ElementFactory.GetButton(By.XPath($"//*[contains(@class,'button--secondary') and contains(text(),'Next')]"), "Next page login form");
        private IComboBox TopLevelDomainComboBox => ElementFactory.GetComboBox(By.XPath("//*[contains(@class,'dropdown__field')]"), "Dropdown top level domain");
        private ITextBox GetTextBoxLocator(string value) => ElementFactory.GetTextBox(By.XPath($"//input[contains(@placeholder,'{value}')]"), $"{value}");
        private ITextBox PasswordTextBox => GetTextBoxLocator("Password");
        private ITextBox NameEmailTextBox => GetTextBoxLocator("email");
        private ITextBox DomainTextBox => GetTextBoxLocator("Domain");
        private IComboBox GetTopLevelDomainNameComboBox(string domain) => ElementFactory.GetComboBox(By.XPath($"//*[contains(@class,'dropdown__list-item') and contains(text(),'{domain}')]"), "Dropdown top level domain name");
        public readonly string[] topLevelDomain = { ".org", ".co.uk", ".net", ".gov", ".de", ".fr", ".nl", ".com", ".be", ".jpg" };

        public RegistrationPage() : base(By.XPath("//*[contains(@class,'page-indicator') and contains(text(),'1')]"), "Registration page") { }

        public void UncheckAcceptTermConditions()
        {
            AcceptTermConditionCheckBox.Check();
        }

        public void ClickNextRegistrationPageButton()
        {
            NextRegistrationPageButton.Click();
        }
        public void FillPassword(string password)
        {
            PasswordTextBox.ClearAndType(password);
        }

        public void FillNameEmail(string nameEmail)
        {
            NameEmailTextBox.ClearAndType(nameEmail);
        }

        public void FillDomain(string domain)
        {
            DomainTextBox.ClearAndType(domain);
        }

        public void ClickTopLevelDomainCheckBox()
        {
            TopLevelDomainComboBox.ClickAndWait();
        }

        public void SelectTopLevelDomain(string topLevelDomain)
        {
            GetTopLevelDomainNameComboBox(topLevelDomain).ClickAndWait();
        }
    }
}
