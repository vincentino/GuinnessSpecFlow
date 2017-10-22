using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class TenancyEnforcementPage : CRMWebPages
    {
        const string TenancyEnforcementPageTitle = "New Tenancy Enforcement";
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                Browser.driver.SwitchTo().Frame("contentIFrame0");

                if (TGPDashBoardTitle.Text != null)
                {
                    TGPDashBoardTitle.Text.Contains(TenancyEnforcementPageTitle);
                    return true;
                }
                return string.IsNullOrEmpty(TenancyEnforcementPageTitle);

            }
        }
        public void StartTenancyRepairsDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            StartTenancyEnforcementWindow.Click();
        }

        public void CanGoTEnforcementDialogWindow()
        {
            Browser.Wait(TimeSpan.FromSeconds(2));
            Browser.driver.SwitchTo().Frame("contentIFrame0");
            StartTenancyRepairsDialogWindow();
        }

        public bool HasBack
        {
            get
            {
                Browser.SwitchToNewWindow();
                Browser.CloseOtherWindows("Resolution:");
                Browser.CurrentWindowTitle().Contains("Tenancy Enforcement : Information");
                return true;
            }
        }
    }
}