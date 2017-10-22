using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    // This is an action class.
    //It's perform action by press enter keyboard
    public class ActionControl
    {
        private Actions _action;
        public ActionControl() { }
        
        public void PressEnterkeyBoard()
        {
            _action = new Actions(Browser.driver);
            _action.SendKeys(Keys.Enter).Perform();

        }

        
    }
}
