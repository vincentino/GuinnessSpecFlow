using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class RepairsPage : CRMWebPages
    {
        const string repairsPageTitle = "New Repairs";
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                Browser.SwitchToPageFrame("contentIFrame0");

                if (TGPDashBoardTitle.Text != null)
                {
                    TGPDashBoardTitle.Text.Contains(repairsPageTitle);
                    return true;
                }
                return false;
            }
        }

        public void CustomerServiceStartRepairsDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            ClickStartRepairWindow.Click();
        }

        public void SelectContactTypeFromTheOption()
        {
            GenericObjects.GoToNextPage();
            var newRepair = "New Repair";
            Browser.SelectWithVisibleText(NewRepairElement, newRepair);

            GenericObjects.GoToNextPage();

        }
    }
}