using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace UserInterface.Integration.Pages
{
    public class ProfilePersonalDetailsPage : Form
    {
        public ProfilePersonalDetailsPage() : base(By.XPath("//*[contains(@class,'page-indicator') and contains(text(),'3')]"), "Profile personal details page") { }
    }
}
