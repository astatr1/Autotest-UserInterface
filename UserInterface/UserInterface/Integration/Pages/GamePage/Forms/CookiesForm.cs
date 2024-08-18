using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterface.Integration.Pages.GamePage.Forms
{
    public class CookiesForm : Form
    {
        private static readonly By AcceptCookiesButtonLocator = By.XPath("//*[contains(@type,'button') and contains(text(),'Not really')]");
        private IButton AcceptCookiesButton => ElementFactory.GetButton(AcceptCookiesButtonLocator, "Not really, no");

        public CookiesForm() : base(AcceptCookiesButtonLocator, "Accept Cookies Form") { }

        public void AcceptCookies()
        {
            AcceptCookiesButton.WaitAndClick();
        }
    }
}
