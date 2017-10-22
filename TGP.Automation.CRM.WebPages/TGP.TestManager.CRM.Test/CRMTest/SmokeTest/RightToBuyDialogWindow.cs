using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.CRMPage;

namespace TGP.TestManager.CRM.Test.Hooks
{
    [TestFixture]

    public class RightToBuyDialogWindow : Hooks
    {
        [Test]
        [Category("SmokeTest")]
        public void CanGoToRightToBuyDialogWindow()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation
                 .CustomerNameLabel).AndPressEnterKeyBoard();
            Assert.IsTrue(Pages.SystemDashBoard.SearchResultList(), "Search result not displayed searh name");
            Pages.SystemDashBoard.SelectSearchNameFromTheList();
            Assert.AreEqual(CustomerInformation.CustomerInformationSummary("noemail@CSC.com", "04 Feb 1971"),
                Pages.SystemDashBoard.ActualValue(), "Expected and actual are not the same");
            Pages.SystemDashBoard.AddMemoWordAndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt, "Cannot go to Interaction dashborad");
            Pages.InteractionDashBoard.EventTile.Navigate("Right to buy");
            //Assert right to buy title page
            Assert.IsTrue(Pages.RightToBuyDashBoard.IsAt(), "Fail to Go to Right To Buy Page");
            // Click start botton from the menu bar
            Pages.RightToBuyDashBoard.StartRightToBuyDialogWindow();
            Assert.IsTrue(Pages.RightToBuyDialogWindow.IsAt, "Unable to navigate to dialog window");
            Pages.RightToBuyDialogWindow.CloseRightToBuyDialogWindow();




           // Pages.RightToBuyDialogWindow.CanClickNextButton();

           // //// select make a new application and click next
           // Pages.RightToBuyDialogWindow.SelectWith.SelectNewApplication();

           // ////select voluntary sale and click next

           // Pages.RightToBuyDialogWindow.SelectWith.VoluntarySale();

           // //// check active anti-social behaviour
           // Pages.RightToBuyDialogWindow.CheckWith.SocialBehaviour();

           // ////assert Eligibility message display
           // Assert.IsTrue(Pages.RightToBuyDialogWindow.WarningMessage(CustomerInformation.EligibilityAdviced));

           //// Pages.RightToBuyDashBoard.RightToBuyWindowPopUp.DialogBox.SharingRight();
           // Pages.RightToBuyDialogWindow.SharingRight();

           // // sharing right section including relative name, relationship 
           // //and time at the address

           // Pages.RightToBuyDialogWindow.SharingRightWith(CustomerInformation.CustomerNorminee)
           //      .WithRelationship(CustomerInformation.Relative)
           //      .WithTimeLiveAtTheAddress(CustomerInformation.TimeAtTheAddress)
           //      .CustomerNormineeName();

           // //// select application form and click next
           // Pages.RightToBuyDialogWindow.ApplicationForm();
           // //// select not send to post office
           // Pages.RightToBuyDialogWindow.PostOfficeOption();

           // //// input comment 
           // Pages.RightToBuyDialogWindow.InputAddtionalInformation(CustomerInformation.CommentInput);

            //// Finish the application form in the mini window
           // Pages.RightToBuyDialogWindow.FinishDialogInteraction();

            
        }


    }
}
