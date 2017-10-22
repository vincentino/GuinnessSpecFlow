using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;

namespace TGP.TestManager.CRM.Test.Hooks
{
    [TestFixture]
    public class AccountEnquiryDialogWindow : Hooks
    {
        [Test]
        [Category("SmokeTest")]
        public void CanProcessAccountEnquiries()
        {
            ///<summary>
            ///
            ///</summary>
            Pages.SystemDashBoard.CustomerName("Simon Dawson").AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt, "Cannot go to Interaction dashborad");
            Pages.InteractionDashBoard.EventTile.Navigate("Account Enquiries");
            Assert.IsTrue(Pages.AccountEnquiryDashBoard.IsAt, "Unable to goto Account Enquiries Page");
            Pages.AccountEnquiryDashBoard.AccountEnquiriesDialogWindow();
            Assert.IsTrue(Pages.AccountEnquiriesDaialog.IsAt, 
                "Unable to open Account Enquiries Dialoque Window");
            Pages.AccountEnquiriesDaialog.CloseAccountEnquiryDialogWindow();

            ///<summary>
            ///
            ///</summary>           
            //Pages.AccountEnquiriesDaialog.AccountEnquiriesNextButton();
            //Pages.AccountEnquiriesDaialog.SelectWith.BalanceTransferAndMissingPayment();
            //Pages.AccountEnquiriesDaialog.SelectWith.AdminCanLocateAdvisorPayement();
            //Pages.AccountEnquiriesDaialog.SelectWith.AdminCanSelectStandingOrder();            
            //Pages.AccountEnquiriesDaialog.CustomerAmountAndDateOfPayment();
            //Pages.AccountEnquiriesDaialog.AdminFinishedDialogWindow();
 
        }

    }
}
