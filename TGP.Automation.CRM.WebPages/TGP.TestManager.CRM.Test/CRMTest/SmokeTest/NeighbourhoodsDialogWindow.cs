using NUnit.Framework;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.CRMPage;
using TGP.Automation.CRM.WebPages.PageIntertaction;

namespace TGP.TestManager.CRM.Test.Hooks
{
    [TestFixture]
    public class NeighbourhoodsDialogWindow : Hooks
    {
        [Test]
        [Category("SmokeTest")]
        public void CanGoToNeighbourHoodsDialogWindow()
        {
            Pages.SystemDashBoard.CustomerName(CustomerInformation.CustomerNameLabel)
                 .AndPressEnterKeyBoard();
            Pages.SystemDashBoard.SelectSearchName.ClickOptions.AndStartInteraction();
            Assert.IsTrue(Pages.InteractionDashBoard.IsAt, 
                "Customer Service cannot got to Interaction Page");
            Pages.InteractionDashBoard.EventTile.Navigate("My Property and Neighbourhood");
            Assert.AreEqual(TGPLabel.PageTitle, Pages.NeighbourhoodsDashBoard
                  .IsAt,"Customer Service cannot got to Tenancy Enforcement DashBoard");
            Pages.NeighbourhoodsDashBoard.StartNeighbourhoodsDialogWindow();
            Assert.IsTrue(Pages.NeighbourHoodsDialogWindow.IsAt, "Window dialog not opened");
            Pages.NeighbourHoodsDialogWindow.CloseNeighbourHoodDialogWindow();
            //Pages.NeighbourHoodsDialogWindow.SelectWith.SelectLandLordRefrence();
            //Pages.NeighbourHoodsDialogWindow.SelectWith.SelectLandLordRequestOptions();
            //Pages.NeighbourHoodsDialogWindow.SelectWith.SelectLandLordRequestForm();
            //Assert.IsTrue(Pages.NeighbourHoodsDialogWindow.IsDisplayedMessage);
            //Pages.NeighbourHoodsDialogWindow.CompletedInfoDisplayedCorrectly
            //     .AddRequiredInformationmWith(CustomerInformation.CommentInput)
            //     .CanGoToNextPage();
        }

    }
}
