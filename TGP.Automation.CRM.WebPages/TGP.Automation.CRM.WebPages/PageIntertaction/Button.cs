using OpenQA.Selenium;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    public class Button
    {
        private IWebElement _click;

        public Button(IWebElement click)
        {
            _click = click;

        }
        public Button()
        {
            _click.Click();
        }
       
        public void ClickButton()
        {

            _click.Click();
        }

        

        public void CheckButton()
        {
            if (!_click.Selected)
            {
                _click.Click();
            }
        }

        public void Checked()
        {
            if (!_click.Selected)
            {
                _click.Click();
            }
        }




    }
        
    
       

}

