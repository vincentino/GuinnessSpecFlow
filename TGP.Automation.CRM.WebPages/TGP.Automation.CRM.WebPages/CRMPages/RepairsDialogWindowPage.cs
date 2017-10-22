using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class RepairsDialogWindowPage
    {
        const string repairDialogPageTitle = "Repairs - Start Dialog";
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(3));      
                return Browser.DialogWindowTitle(repairDialogPageTitle);
            }
        }

       
    }
}