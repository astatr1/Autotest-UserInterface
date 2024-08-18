using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserInterface.Integration.Pages.GamePage.Forms;

namespace UserInterface.Integration.Pages.GamePage
{
    public class GamePage : Form
    {
        private ILabel TimerLabel => ElementFactory.GetLabel(By.XPath("//*[contains(@class,'view')]/*[contains(@class,'timer')]"), "Timer");
        public CookiesForm CookiesForm => new();
        public HelpForm HelpForm => new();

        public GamePage() : base(By.XPath("//*[contains(@class,'game')]"), "Game Page") { }

        public string GetValueTimer() => TimerLabel.GetText();
    }
}
