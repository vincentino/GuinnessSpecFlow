using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.CustomerCredentials;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFixture]
    public class PaymentEventTile : Hooks
    {
        [Test]
        [Category("Regression")]
        public void AmendCustomerPayment()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Pages.InteractionDashBoard.EventTile.Navigate("Payment");
            Pages.PaymentEventDashboard.GoToPaymentDialogWindow();      
            Pages.PaymentDialogWindow.NextButton.SelectFromTheList
                 .FinishPaymentDialogWindow();
        }
    }
}
