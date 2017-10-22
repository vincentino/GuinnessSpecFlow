using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.CRMPage;

namespace TGP.TestManager.CRM.Test.Hooks
{
    [TestFixture]
    public class TenancyEnforcementDialogWindow : Hooks
    {
        [Test]
        [Category("SmokeTest")]
        public void CanGoToTenancyEnforcementDialogWindow()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt,
                "Customer Service cannot got to Interaction Page");
            Pages.InteractionDashBoard.EventTile.Navigate(NavigationTitle.TenancyEnforcement);
            Assert.IsTrue(Pages.TenancyEncorcementDashBoard.IsAt, 
                "Customer Service cannot got to Tenancy Enforcement DashBoard");
            Pages.TenancyEncorcementDashBoard.StartTenancyRepairsDialogWindow();          
            Assert.IsTrue(Pages.TenancyEncorcementDialogWindow.IsAt(),
                "Dialog window did not open as expected");
            Pages.TenancyEncorcementDialogWindow.CloseEnforcementDialogWindow();
        }
    }
}
