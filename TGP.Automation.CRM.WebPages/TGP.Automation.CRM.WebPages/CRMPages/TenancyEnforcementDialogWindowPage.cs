using System;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class TenancyEnforcementDialogWindowPage :CRMWebPages
    {
        const string tenancyEnforcementWindowTitle = "Tenancy Enforcement - Start Dialog3";
        const string domAbuse = "*Domestic Abuse";
        private string saguardOption = "No";

        public TenancyEnforcementDialogWindowPage() { }

        public bool IsAt()
        {
           
            Browser.Wait(TimeSpan.FromSeconds(3));;
            Browser.SwitchToNewWindow();
            return true;
        }
        public TenancyEnforcementDialogWindowPage EnterTextWith
        {
            get { return new TenancyEnforcementDialogWindowPage(); }
        }

        public TenancyEnforcementDialogWindowPage ClickNextButton
        {
            get { return new TenancyEnforcementDialogWindowPage(); }
        }

        public TenancyEnforcementDialogWindowPage SelectFromTheList
        {
            get { return new TenancyEnforcementDialogWindowPage(); }
        }
        public void SelectDomesticsAbuseFromTheList()
        {
            GenericObjects.GoToNextPage();
            Browser.SelectWithVisibleText(DropDownListElements,domAbuse);
            GenericObjects.GoToNextPage();
        }

        public bool ActualImminentRiskMessage
        {
            get
            {
                var expected = TGPLabel.ExpectedImminentRiskMessage;

                if (expected)
                {
                    return true;
                }
                return false;
                
            }

        }

        public void CloseEnforcementDialogWindow()
        {
            Browser.CloseOtherWindows("Tenancy Enforcement - Start Dialog");
        }
        public void CanGoToResolutionLink()
        {
            GenericObjects.GoToNextPage();
            LinkToResolutionPage.Click();
        }
        public void SwitchBackToTenancyEnforcementWindow(string refNUmber)
        {
            Browser.SwitchToNewWindow();
            CustomerSharingElement.SendKeys(refNUmber);
            Browser.SelectWithVisibleText(SafeGuardElement, saguardOption);
            GenericObjects.GoToNextPage();

        }
        public void InputFurtherMessage(string message)
        {
            RequiredInfo.SendKeys(message);
            GenericObjects.GoToNextPage();
            Browser.Wait(TimeSpan.FromSeconds(3));
            Browser.CloseOtherWindows("Tenancy Enforcement - Start Dialog");

        }

        public void FinishTenancyEnforcementProcess()
        {
            if (DialogTitle.AtDialogWindow)
            {
                SelectDomesticsAbuseFromTheList();
                ActualImminentRiskMessage.ToString();
                CanGoToResolutionLink();
                ResolutionPage.IsAt.ToString();
                SwitchBackToTenancyEnforcementWindow("456377"); // Test if the field accept int and string
                InputFurtherMessage(CustomerInformation.CommentInput);


            }

        }


    }
}