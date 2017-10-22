using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class GuinnessInteractionPage :CRMWebPages
    {
        // Get the page title 
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(4));
                Browser.SwitchToDefaultWindow();
                Browser.SwitchToPageFrame("contentIFrame0");

                if (InteractionTitle.Displayed)
                {
                    return true;
                }
                return false;
            }
        }
        public GuinnessInteractionPage EventTile
        {
            get { return new GuinnessInteractionPage(); }
        }

        
        public void Navigate(string navElement)
        {
            Browser.SwitchToDefaultWindow();
            Browser.SwitchToPageFrame("contentIFrame0");
            Browser.SwitchToPageFrame("WebResource_eventbuttons");

            foreach (var navTitle in NavContainer)
            {
                if (navTitle.Displayed)
                {
                    if (navTitle.Text.Equals(navElement, StringComparison.InvariantCultureIgnoreCase))
                    {
                        navTitle.Click();
                        break;
                    }
                }
                

            }
        }
    }
}