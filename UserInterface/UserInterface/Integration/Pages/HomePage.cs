using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterface.Integration.Pages
{
    public class HomePage : Form
    {
        private ILink RegistrationPageLink => ElementFactory.GetLink(By.XPath("//*[contains(@class,'start__link')]"), "Registration Page");

        public HomePage() : base(By.XPath("//*[contains(@class,'start')]"), "Home Page") { }

        public void GoToRegistrationPage()
        {
            RegistrationPageLink.ClickAndWait();
        }
    }
}