using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class PaymentPage :CRMWebPages
    {
        const string paymentPageTitle = "New Payment event";
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                Browser.SwitchToPageFrame("contentIFrame0");
                if (TGPDashBoardTitle.Text.Contains(paymentPageTitle))
                    return true;
                return string.IsNullOrEmpty(paymentPageTitle);
              
            }

        }
        public void StartPaymentDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            ClickStartPayment.Click();
        }

        public void GoToPaymentDialogWindow()
        {
            Browser.Wait(TimeSpan.FromSeconds(2));
            Browser.SwitchToPageFrame("contentIFrame0");
            StartPaymentDialogWindow();
        }
        
    }
}