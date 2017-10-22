using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.CustomerCredentials;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFixture]
    public class TenancyEnforcement : Hooks
    {
        [Test]
        [Category("Regression")]
        public void TenancyEnforcementProcessSuccessfully()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Pages.InteractionDashBoard.EventTile.Navigate(NavigationTitle.TenancyEnforcement);
            Pages.TenancyEncorcementDashBoard.CanGoTEnforcementDialogWindow();
            Pages.TenancyEncorcementDialogWindow.ClickNextButton.SelectFromTheList
                 .FinishTenancyEnforcementProcess();
        }
    }
}
