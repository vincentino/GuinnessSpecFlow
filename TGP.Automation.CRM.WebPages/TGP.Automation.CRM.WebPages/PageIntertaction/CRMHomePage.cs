using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMHomePage
{
    public class CRMHomePage : CRMWebPages
    {
        public void GoTo()
        {
            Browser.LaunchURL();
        }
        public bool IsAt
        {
            get
            {
                var title = "Dashboards: Generic - Microsoft Dynamics CRM";

                if (Browser.driver.Title != null)
                {

                    return Browser.driver.Title.Equals(title);
                }
                else
                    return false;
            }

        }

        // Declare Control properties
        public Inbox CustomerSearch { get; private set; }
        public ActionControl KeyEnter { get; private set; }
        public Label ResultList { get; private set; }
        public Button DesireResult { get; private set; }
        public Label CustomerDetailsSummary { get; private set; }
        //public Button CustomerMemorableWord { get; private set; }

        private void Initialize()
        {
            // page element control
            CustomerSearch = new Inbox(TextElement);
            KeyEnter = new ActionControl();
            ResultList = new Label(Result);
            DesireResult = new Button();
            CustomerDetailsSummary = new Label(SummaryDetails);
            //CustomerMemorableWord = new Button();

        }
        public void SearchForCustomer(string cusName)
        {
            // switch to default window before performing any action
            Browser.SwitchToDefaultWindow();

            // switch to action frame
            Browser.SwitchToPageFrame();

            // initialized page element
            Initialize();

            // search for customer name 
            CustomerSearch.InputTextIntoTheField(cusName);

            // press enter from keyboard
            KeyEnter.PressEnterkeyBoard();
            //Browser.WaitForVisibilityOfElement(5000, Result);
            Browser.WaitForVisibilityOfElement(5000, "results");
        }

        public bool SearhResultList
        {
            get
            {
                if (Result.Displayed)
                {
                    return ResultList.Contains("SIMON DAWSON");
                }
                return false;
            }
        }

        // select search name from the list
        public void SelectCustomerFromTheList()
        {
            ResultListElement.Click();

        }

        public bool CustomerDetailsDisplayCorrectly
        {
            get
            {
                if (SummaryDetails != null)
                {
                    if (SummaryDetails.Text.Contains("8 Oct 1975")
                        && SummaryDetails.Text.Contains("07551889513"))
                    {
                        return true;
                    }

                }
                return false;
            }
        }

        public void StartInteraction()
        {
            MemoElement.Click();
            Browser.WaitForVisibilityOfElement(5000, "action1");
            InteractElement.Click();
        }

    }
}
