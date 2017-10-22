using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class ApplicationEnquiriesPage : CRMWebPages
    {
        const string applicationEnquriesTitle = "New Application Enquiry";
        const string smallWindowTitle = "Application Enquiry - Start Dialog";
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                Browser.driver.SwitchTo().Frame("contentIFrame0");
                if (TGPDashBoardTitle.Text !=null)
                {
                    TGPDashBoardTitle.Text.Contains(applicationEnquriesTitle);
                    return true;
                }
                return string.IsNullOrEmpty(applicationEnquriesTitle);

            }
        }

        // Start application enquiry dialog window function
        // Only use for smoke test category
        public void StartApplicationEnquriesDialogWindow()
        {
            Browser.SwitchToDefaultWindow();
            ClickStartApplicationEnquiry.Click();

        }

        /// <summary>
        /// Start application enquiry dialog window function
        /// Only use for Regression test category
        /// if if not in application enquiry dialog window, 
        /// then go to application enquiry dialog window
        /// </summary>
        public void GoToEnquiryDialogWindow()
        {
            Browser.Wait(TimeSpan.FromSeconds(2));
            Browser.driver.SwitchTo().Frame("contentIFrame0");
            StartApplicationEnquriesDialogWindow();
        }

        private bool IsApplicationEnquiryDialogWindow
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                return Browser.DialogWindowTitle(smallWindowTitle.Trim());
            }
        }
    }
}