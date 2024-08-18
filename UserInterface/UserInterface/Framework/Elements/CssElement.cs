using Aquality.Selenium.Elements.Interfaces;

namespace UserInterface.Framework.Elements
{
    public class CssElement
    {
        public CssElement() { }
        public string GetValueProperty(IElement element, string property)
        {
            return element.GetCssValue(property);
        }
        public static class Property
        {
            public static string GetHeight(IElement element)
            {
                return element.GetCssValue("height");
            }
        }
    }
}
