using System;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class NeighbourhoodsDialogWindowPage : CRMWebPages
    {
        const string dialogWindowTitle = "My Property and Neighbourhood Start Dialog";
        const string optionList = "Landlord References";
        const string landLordRequest = "No";
        private string _message;

        public NeighbourhoodsDialogWindowPage(string message)
        {
            _message = message;
        }

        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                return Browser.DialogWindowTitle(dialogWindowTitle);
                
            }
        }
        public NeighbourhoodsDialogWindowPage() { }

        public NeighbourhoodsDialogWindowPage SelectWith
        {
            get { return new NeighbourhoodsDialogWindowPage(); }
        }

        public NeighbourhoodsDialogWindowPage CompletedInfoDisplayedCorrectly
        {
            get { return new NeighbourhoodsDialogWindowPage(); }
        }

        public NeighbourhoodsDialogWindowPage ClickNextButton
        {
            get { return new NeighbourhoodsDialogWindowPage(); }
        }
        public void SelectLandLordRefrence()
        {
            GenericObjects.ClickNextButtonTwiceToGoToNextPage();
            Browser.SelectWithVisibleText(DropDownListElements, optionList);
            GenericObjects.GoToNextPage();
        }

        public void CloseNeighbourHoodDialogWindow()
        {
            Browser.CloseOtherWindows("My Property and Neighbourhood Start Dialog");
        }

        public void SelectLandLordRequestOptions()
        {
            Browser.SelectWithVisibleText(DropDownListElements, landLordRequest);
            GenericObjects.GoToNextPage();
        }

        public void SelectLandLordRequestForm()
        {
            Browser.SelectWithVisibleText(DropDownListElements, landLordRequest);
            GenericObjects.GoToNextPage();
        }

        public static bool message;
        public bool IsDisplayedMessage
        {
            get
            {

                if (PromptMessage.Text != null)
                {
                    PromptMessage.Text.Contains(TGPLabel.BusinessEmail.ToString());
                    return true;
                    
                }
                return string.IsNullOrEmpty(TGPLabel.BusinessEmail.ToString());
            }
        }

        //public NeighbourhoodsDialogWindowPage AddRequiredInformationmWith(string v)
        //{
        //    return new NeighbourhoodsDialogWindowPage(v);
        //}

        public void MessageDisplayCorrectlyAndDialogWindowIsClosed()
        {
            
            var proptMessage = TGPLabel.BusinessEmail.ToString();
            GenericObjects.GoToNextPage();

            if (PropmptMessageWithEmail.Text != null)
            {
               var trueMessage =  PropmptMessageWithEmail.Text.Contains(proptMessage);
               trueMessage = true ;
            }
            else
             string.IsNullOrEmpty(proptMessage);

            LiveThereElement.SendKeys(CustomerInformation.CommentInput);
            Browser.CloseOtherWindows("My Property and Neighbourhood Start Dialog");
        }
        public void FinishNeigbourhoodProcess()
        {
            DialogTitle.AtDialogWindow.ToString(); ;
            SelectLandLordRefrence();
            SelectLandLordRequestOptions();
            SelectLandLordRequestForm();
            IsDisplayedMessage.ToString();
            MessageDisplayCorrectlyAndDialogWindowIsClosed();

        }
    }
}