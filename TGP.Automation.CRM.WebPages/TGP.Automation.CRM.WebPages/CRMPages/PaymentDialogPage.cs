using System;
using TGP.Automation.CRM.WebPages.Utilities;
using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class PaymentDialogPage :CRMWebPages
    {
        private string _amount = "60.00";
        public const string smallWindowTitle = "Start Dialog";
        public PaymentDialogPage(string amount)
        {
            _amount = amount;
        }

        public PaymentDialogPage() {  }
        public bool IsAt
        {
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(3));
                return Browser.DialogWindowTitle(smallWindowTitle.Trim());
            }
        }

        public PaymentDialogPage SelectWith
        {
            get { return new PaymentDialogPage(); }
        }

        public void StartDialogByClickNextButton()
        {
            GenericObjects.GoToNextPage();
        }

        public bool CustomerAccountIspreselected()
        {
            var customerAcount = "605354 REN";
            if (!DefaultSelected.Selected)
            {
               return DefaultSelected.Text.Contains(customerAcount);
            }
            return false;
        }

        public void ClickNextButtonTwice()
        {
            GenericObjects.ClickNextButtonTwiceToGoToNextPage();
        }

        // close dialog window 
        public void CloseDialogWindow()
        {
            Browser.CloseOtherWindows("Start Dialog");
        }

        public void DirectDebitFroTheList()
        {
            var directDebit = "Direct Debit";
            Browser.SelectWithVisibleText(DropDownListElements, directDebit);
            GenericObjects.GoToNextPage();
        }

        // Assert select from the list set at default
        private bool DefaultSelection()
        {
            if (!DropDownListElements.Selected)
            {
              return DropDownListElements.Text.Contains("Please Select");
            }
            return false;
        }

        public void SelectAmendFromTheList()
        {
            var amend = "Amend";
            Browser.SelectWithVisibleText(DropDownListElements, amend);
            GenericObjects.GoToNextPage();         
        }
        public bool CurrencyFieldDisplayed
        {
            get
            {
                var expectedLabel = TGPLabel.CurrencySign;
                if (expectedLabel)
                {
                    return true;
                }
                return false;
            }    
        }
        public Inbox Amount { get; private set; }
        public bool  TaskHasBeenAssigned
        {
            get
            {
                var expected = TGPLabel.HasAssignedToCustomerAdvisor;

                if (CATElement.Text != null)
                {
                    CATElement.Text.Equals(expected);
                    return true;
                }
                return false;
            }
        }

        public PaymentDialogPage NextButton
        {
            get
            {
                return new PaymentDialogPage();
            }
        }

        public PaymentDialogPage SelectFromTheList
        {
            get
            {
                return new PaymentDialogPage();
            }
        }

        private void Initialized()
        {
            Amount = new Inbox(AmountInputText);
        }
        public PaymentDialogPage SetProposedDirectDebitAs(string amount)
        {
            return new PaymentDialogPage(amount);
        }

        public void PaymentAmountOptions()
        {
            var proposedAmountOption = "Yes";

            Initialized();
            Amount.InputTextIntoTheField(_amount);

            Browser.SelectWithVisibleText(VolElement, proposedAmountOption);
            GenericObjects.ClickNextButtonTwiceToGoToNextPage();

        }
        public void CustomerServiceCanAdFurherInformation(string comment)
        {
            CommentBox.SendKeys(comment);
            GenericObjects.GoToNextPage();    
        }

        /// <summary>
        /// Part of regrssion test
        /// </summary>
        public void FinishPaymentDialogWindow()
        {
            if (DialogTitle.AtDialogWindow)
            {
                GenericObjects.GoToNextPage();
                CustomerAccountIspreselected();
                GenericObjects.GoToNextPage();
                DirectDebitFroTheList();
                SelectAmendFromTheList();
                PaymentAmountOptions();
                CustomerServiceCanAdFurherInformation(CustomerInformation.CommentInput);
                GenericObjects.GoToNextPage();
                Browser.CloseOtherWindows("Tenancy Exists");

            }
            
        }

        //public static bool /*IsAtDialogWindow*/AtDialogWindow
        //{
        //    get
        //    {
        //        Browser.Wait(TimeSpan.FromSeconds(3));
        //        //return Browser.DialogWindowTitle(smallWindowTitle.Trim());
        //        return Browser.DialogWindowTitle(DialogTitle.AtDialogWindow.ToString());
        //    }
        //}
    }
}

public class DialogTitle : CRMWebPages
{
    //private static string smallWindowTitle = "Start Dialog";

    public static bool AtDialogWindow
    {
        get
        {
            Browser.Wait(TimeSpan.FromSeconds(3));
            //return Browser.DialogWindowTitle(smallWindowTitle.Trim());
            Browser.SwitchToNewWindow();
            return true;
        }
    }

    /// <summary>
    /// This Function check if Interaction page title displayed
    /// </summary>
    /// <param name="expected"></param>
    /// <returns></returns>
    public static bool IsAtInteractionPage(string expected) 
    {
        Browser.Wait(TimeSpan.FromSeconds(3));
        Browser.SwitchToPageFrame("contentIFrame0");

        if (TGPDashBoardTitle.Text != null)
        {
            TGPDashBoardTitle.Text.Contains(expected);
            return true;

        }
        return string.IsNullOrEmpty(expected);
        
    }
}