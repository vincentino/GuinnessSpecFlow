using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.CustomerCredentials;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFixture]
    public class ApplicationEnquiryTile : Hooks
    {
        [Test]
        [Category("Regression")]
        public void ProcessAppplicationEquiryTile()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Pages.InteractionDashBoard.EventTile.Navigate("Application Enquiry");
            Pages.ApplicationEquiriesDashBoard.GoToEnquiryDialogWindow();
            Pages.ApplicationEquiriesDialogWindow.SelectWith
                 .ThenClickNextButton.AndFinishInteraction();
        }
    }
}
