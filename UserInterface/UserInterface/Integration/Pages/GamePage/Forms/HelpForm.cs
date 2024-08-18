using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using UserInterface.Framework.Elements;
using UserInterface.Integration.Utils;

namespace UserInterface.Integration.Pages.GamePage.Forms
{
    public class HelpForm : Form
    {
        private IButton SendToBottom => ElementFactory.GetButton(By.XPath("//button[contains(@class,'help-form__send-to-bottom')]"), "Hide the help form");
        private ILabel LabelHiddenHelpForm => ElementFactory.GetLabel(By.XPath("//*[contains(@class,'help-form is-hidden')]"), "Sign of an invisible help form");

        public HelpForm() : base(By.XPath("//*[contains(@class,'help-form')]"), "Help Form") { }

        public double GetCurrentHeightForm(string unitMeasure)
        {
            var heightRowValue = CssElement.Property.GetHeight(LabelHiddenHelpForm);

            return ValueParser.ParseDoubleCulture(ValueFormatter.RemoveMeasure(heightRowValue, unitMeasure));
        }

        public void ClickButtonSendToBottom()
        {
            SendToBottom.Click();
        }
    }
}
