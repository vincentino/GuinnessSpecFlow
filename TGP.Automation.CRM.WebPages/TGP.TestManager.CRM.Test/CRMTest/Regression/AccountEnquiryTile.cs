using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.TestManager.CRM.Test.CRMTest.Regression;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFexture]
    public class AccountEnquiryTile : Hooks
    {
        [Test]
        [Category("Regression")]
        public void ProcessAccountEnquirySuccessfully()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();           
            Pages.InteractionDashBoard.EventTile.Navigate("Account Enquiries");            
            Pages.AccountEnquiryDashBoard.CanGoToAccountEnquiryDialogWindow();
            Pages.AccountEnquiriesDaialog.ClickNextButton.SelectWith
                 .FinishedAccountEnquiryProcess();

        }
    }
}
