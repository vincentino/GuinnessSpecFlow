using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class AccountEnquiriesPage : CRMWebPages
    {
        const string actDashBordTitle = "New Account Enquiries";
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                Browser.driver.SwitchTo().Frame("contentIFrame0");
                if (TGPDashBoardTitle.Text != null)
                {
                    return TGPDashBoardTitle.Text.Contains(actDashBordTitle);
                }
                return
                    string.IsNullOrEmpty(actDashBordTitle);
            }
        }
        public void AccountEnquiriesDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            ClickStartAccountEnquiries.Click();
        }

        public void CanGoToAccountEnquiryDialogWindow()
        {
            Browser.Wait(TimeSpan.FromSeconds(2));
            Browser.driver.SwitchTo().Frame("contentIFrame0");
            AccountEnquiriesDialogWindow();
        }
    }
}