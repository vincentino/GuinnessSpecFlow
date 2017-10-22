using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.CustomerCredentials;

namespace TGP.TestManager.CRM.Test.Hooks.CRMTest
{
    [TestFixture]
    public class NeighbourhoodTile : Hooks
    {
        [Test]
        [Category("Regression")]
        public void ProcessPropertyAndNeighbourHoodsTile()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Pages.InteractionDashBoard.EventTile.Navigate("My Property and Neighbourhood");
            Pages.NeighbourhoodsDashBoard.GoToNeighbourHoodDialogWindow();
            Pages.NeighbourHoodsDialogWindow.ClickNextButton
                 .SelectWith.FinishNeigbourhoodProcess();
            
            

        }
    }
}
