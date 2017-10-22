using OpenQA.Selenium;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    public class Inbox
    {
        private IWebElement _textInput;
        public Inbox(IWebElement textInput)
        {
            _textInput = textInput;
        }

        public void InputTextIntoTheField(string text)
        {
            _textInput.Clear();
            _textInput.SendKeys(text);
        }

        public void ClearText()
        {
            _textInput.Clear();
        }

        
    }
}
