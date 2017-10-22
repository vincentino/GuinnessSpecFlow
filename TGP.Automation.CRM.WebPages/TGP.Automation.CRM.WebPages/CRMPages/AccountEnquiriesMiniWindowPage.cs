using System;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class AccountEnquiriesMiniWindowPage : CRMWebPages
    {
        private string  receipt = "Yes";
        private string dialogTitle = "Start";

        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(3));
                Browser.DialogWindowTitle(dialogTitle);
                return true;              
            }
        }

        public AccountEnquiriesMiniWindowPage SelectWith
        {
            get
            {
                return new AccountEnquiriesMiniWindowPage();
            }
        }

        public AccountEnquiriesMiniWindowPage ClickNextButton
        {
            get { return new AccountEnquiriesMiniWindowPage(); }
        }

        public void AccountEnquiriesNextButton()
        {
            GenericObjects.ClickNextButtonTwiceToGoToNextPage();
        }
        public void BalanceTransferAndMissingPayment()
        {
            var selectByText = "Balance Transfers or Missing Payment";

            Browser.SelectWithVisibleText(DropDownListElements, selectByText);
            GenericObjects.GoToNextPage();
            
        }

        public void AdminCanLocateAdvisorPayement()
        {
            var selectByText = "No";
            Browser.SelectWithVisibleText(DropDownListElements, selectByText);
            GenericObjects.GoToNextPage();
        }

        public void CloseAccountEnquiryDialogWindow()
        {
            Browser.CloseOtherWindows("Account Enquiries - Start Dialog");
        }
        public void AdminCanSelectStandingOrder()
        {
            var selectByText = "Standing Order";
            Browser.SelectWithVisibleText(StandingOrderElement, selectByText);
            GenericObjects.GoToNextPage();
        }
        public void CustomerAmountAndDateOfPayment(string amount, string date)
        {
            PaymentElement.SendKeys(amount);

            DatePickerElement.Click();
            foreach (var dateElement in DateElementsData)
            {  
                if (dateElement.Text.Equals(date))
                {
                    dateElement.Click();
                    break;
                }

            }

            Browser.SelectWithVisibleText(RelationshipNameElement, receipt);

            GenericObjects.GoToNextPage();
        }
        public void AdminFinishedDialogWindow()
        {
            GenericObjects.ClickNextButtonTwiceToGoToNextPage();
            Browser.CloseOtherWindows("Account Enquiries - Start Dialog");
        }

        public void FinishedAccountEnquiryProcess()
        {
            if (DialogTitle.AtDialogWindow)
            {
                AccountEnquiriesNextButton();
                BalanceTransferAndMissingPayment();
                AdminCanLocateAdvisorPayement();
                AdminCanSelectStandingOrder();
                CustomerAmountAndDateOfPayment(CustomerInformation.Amount, CustomerInformation.Date);
                AdminFinishedDialogWindow();
            }
            
           
        }


    }
}