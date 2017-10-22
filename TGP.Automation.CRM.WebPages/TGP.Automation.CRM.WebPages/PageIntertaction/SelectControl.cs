using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    public class SelectControl
    {
        private SelectElement _select;    
        public void SelectByVisibleText(IWebElement element, string text)
        {
            element.Click();
            _select = new SelectElement(element);
            _select.SelectByText(text);
        }
    }
}

