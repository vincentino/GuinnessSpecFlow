using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.CRMPage;

namespace TGP.TestManager.CRM.Test.Hooks.EventTileTest
{
    [TestFixture]
    public class RepairsDialogWindow : Hooks
    {
        [Test, Ignore("Working on repair Tile")]
        public void CustomerServiceProcessLeaseHoldAndRepairPropertyCorrectly()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt, 
                "Unable to go to Repair Interaction Dash Board");
            Pages.InteractionDashBoard.EventTile.Navigate(NavigationTitle.Repairs);
            Assert.IsTrue(Pages.RepairsDashBoard.IsAt, "Not at Repairs Dash Board");
            Pages.RepairsDashBoard.CustomerServiceStartRepairsDialogWindow();
            Assert.IsTrue(Pages.RepairsDialogWindow.IsAt,
                "Customer Advisor Cannot got to Repairs Dialog Window");
            Pages.RepairsDashBoard.SelectContactTypeFromTheOption();



        }
    }
}
