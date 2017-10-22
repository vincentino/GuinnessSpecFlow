using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.CRMPage;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFixture]
    public class PaymentDialogWindow : Hooks
    {
        [Test]
        [Category("SmokeTest")]
        public void CanGoToPaymentDialogWindow()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt, "Cannot go to Interaction dashborad");
            Pages.InteractionDashBoard.EventTile.Navigate("Payment");
            Assert.IsTrue(Pages.PaymentEventDashboard.IsAt, "Unable to navigate to Payment Page");
            Pages.PaymentEventDashboard.StartPaymentDialogWindow();
            Assert.IsTrue(Pages.PaymentDialogWindow.IsAt,"Payment window dialog not displayed");
            Pages.PaymentDialogWindow.CloseDialogWindow();

            ///<summary>
            ///Customer service can perform below action on the 
            ///small window
            ///</summary>
            //Pages.PaymentDialogWindow.StartDialogByClickNextButton();
            //Assert.IsTrue(Pages.PaymentDialogWindow.CustomerAccountIspreselected(),
            //    "Customer Service need to select customer account");
            //Pages.PaymentDialogWindow.StartDialogByClickNextButton();
            ////Pages.PaymentDialogWindow.SelectWith.NextButton.FinishDialogWindow();




            //Pages.PaymentDialogWindow.SelectWith.DirectDebitFroTheList();
            //Pages.PaymentDialogWindow.SelectWith.SelectAmendFromTheList();
            //Assert.AreEqual(TGPLabel.CurrencySign, Pages.PaymentDialogWindow
            //      .CurrencyFieldDisplayed);
            //Pages.PaymentDialogWindow.SetProposedDirectDebitAs("60.00")
            //     .PaymentAmountOptions();
            //Pages.PaymentDialogWindow.CustomerServiceCanAdFurherInformation(CustomerInformation.CommentInput);
            //Assert.AreEqual(TGPLabel.HasAssignedToCustomerAdvisor, Pages.PaymentDialogWindow.TaskHasBeenAssigned);
            //Pages.PaymentDialogWindow.StartDialogByClickNextButton();
            //Pages.PaymentDialogWindow.FinishDialogWindow();
        }
        
    }
}
