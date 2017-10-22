using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.CustomerCredentials;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFixture]
    public class RightToBuyTile : Hooks
    {
        [Test]
        [Category("Regression")]
        public void ProcessingVoluntarySaleSuccessfully()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation
                 .CustomerNameLabel).AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions
                 .AndStartInteraction();
            Pages.InteractionDashBoard.EventTile.Navigate("Right to buy");
            Pages.RightToBuyDashBoard.GoToRightToBuyDialogWindow();
            Pages.RightToBuyDialogWindow.ClickNext.SelectWith.FinishRightToBuyDialogWindow();
        }

    }

    
}
