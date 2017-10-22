using System;
using TGP.Automation.CRM.WebPages.Utilities;
using TGP.Automation.CRM.WebPages.PageIntertaction;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class NeighbourhoodsPage : CRMWebPages
    {
        const string title = "My Property and Neighbourhood : Information";

        public bool IsAt
        {
            
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(3));
                Browser.SwitchToPageFrame("contentIFrame0");

                var expected = TGPLabel.PageTitle.ToString();
                if (TGPDashBoardTitle.Text != null)
                {
                    TGPDashBoardTitle.Text.Contains(expected);
                    return true;
            
                }
                return string.IsNullOrEmpty(expected);
            }
        }
        public void StartNeighbourhoodsDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            ClickStartNeighbourhoods.Click();           
        }

        public void GoToNeighbourHoodDialogWindow()
        {
           // if (!DialogTitle.AtDialogWindow)
           // {
                Browser.Wait(TimeSpan.FromSeconds(3));
                Browser.SwitchToPageFrame("contentIFrame0");
                StartNeighbourhoodsDialogWindow();
            //}
            
        }
    }
}