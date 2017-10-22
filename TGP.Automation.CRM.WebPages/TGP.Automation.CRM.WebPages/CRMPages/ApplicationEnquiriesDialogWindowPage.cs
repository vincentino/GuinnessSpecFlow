using System;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class ApplicationEnquiriesDialogWindowPage :CRMWebPages
    {
        const string smallWindowTitle = "Application Enquiry - Start Dialog";

        

        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));        
                return Browser.DialogWindowTitle(smallWindowTitle.Trim());               
            }         
        }
        public ApplicationEnquiriesDialogWindowPage SelectWith
        {
            get { return new ApplicationEnquiriesDialogWindowPage(); }
        }
        public void SelectNeWApplication()
        {
            var newApplication = "Make a New Application";
            SelectDesireOptionFromTheList(newApplication);

        }

        public void SelectHousingForOlderPeople()
        {
            var olderPeopleHome = "Housing For Older People";
            SelectDesireOptionFromTheList(olderPeopleHome);
        }

        public void CloseEnquiryDialogWindow()
        {
            Browser.CloseOtherWindows("Application Enquiry - Start Dialog");
        }

        public void SelectApplicationChoosenArea()
        {
            var option = "No";
            Browser.SelectWithVisibleText(OptionElements, option);
            GenericObjects.GoToNextPage();
        }
        // this method is called when to select from the list
        private void SelectDesireOptionFromTheList( string title)
        {             
            Browser.SelectWithVisibleText(DropDownListElements, title);
            GenericObjects.GoToNextPage();
        }

        public void AddFurtherInformation(string comment)
        {
            DropDownListElements.SendKeys(comment);
            GenericObjects.GoToNextPage();
        }
        public void CanGoToNextPage()
        {
            GenericObjects.GoToNextPage();
        }

        public bool HasDisplayedAdvisedMessage
        {           
            get
            {
                var message = TGPLabel.HasMessageForCustomer;
                MessageAdvice.Text.Equals(message);
                return true;
            }
           
        }
        public ApplicationEnquiriesDialogWindowPage ThenClickNextButton
        {
            get
            {
                return new ApplicationEnquiriesDialogWindowPage();
            }
        }

        public void FinishInteraction()
        {
            Browser.CloseOtherWindows("Application Enquiry - Start Dialog");

        }

        /// <summary>
        /// This function do all the interaction on dialog window
        /// Also, part of regression test
        /// </summary>
        public void AndFinishInteraction()
        {
            
            if (DialogTitle.AtDialogWindow)
            {
                SelectNeWApplication();
                SelectHousingForOlderPeople();
                SelectApplicationChoosenArea();
                CanGoToNextPage();
                AddFurtherInformation(CustomerInformation.CommentInput);
                FinishInteraction();
            }          
        }
    }
}