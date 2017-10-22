using System;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    public class RightToBuyPage : CRMWebPages
    {
        public RightToBuyPage RightToBuyWindowPopUp
        {
            get { return new RightToBuyPage(); }
        }

        public bool IsAt()
        {
            const string title = "New Right to Buy event for";

            Browser.Wait(TimeSpan.FromSeconds(3));
            Browser.SwitchToPageFrame("contentIFrame0");
            if (TGPDashBoardTitle.Text != null)
            {
                return TGPDashBoardTitle.Text.Contains(title);
            }
            else
                return string.IsNullOrEmpty(title);
        }

        public void GoToRightToBuyDialogWindow()
        {
            Browser.Wait(TimeSpan.FromSeconds(3));
            Browser.SwitchToPageFrame("contentIFrame0");
            StartRightToBuyDialogWindow();
                        
        }

        private bool IsAtRightToBuyDialogWindow
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                return Browser.DialogWindowTitle(RightToBuyMiniWindowPage.title);
            }
        }

        public void StartRightToBuyDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            StartRightToBuyMiniWindow.Click();           
        }

       
    }
}