using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.CRMPage;

namespace TGP.TestManager.CRM.Test.Hooks
{
    [TestFixture]
    public class ApplicationEnquiriesDialogWindow : Hooks
    {
        [Test]
        [Category("SmokeTest")]
        public void CanGoToApplicationEquiriesDialogWindow()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt, "Cannot go to Interaction dashborad");
            Pages.InteractionDashBoard.EventTile.Navigate("Application Enquiry");
            Assert.IsTrue(Pages.ApplicationEquiriesDashBoard.IsAt, "Not at the application page");
            Pages.ApplicationEquiriesDashBoard.StartApplicationEnquriesDialogWindow();
            Assert.IsTrue(Pages.ApplicationEquiriesDialogWindow.IsAt,
                "Application Enquiry did not diplayed title ");
            Pages.ApplicationEquiriesDialogWindow.CloseEnquiryDialogWindow();
        }
    }
}
