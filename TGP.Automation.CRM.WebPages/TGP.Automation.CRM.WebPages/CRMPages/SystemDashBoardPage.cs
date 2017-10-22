using OpenQA.Selenium;
using System;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.Utilities;


namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class SystemDashBoardPage : CRMWebPages
    {
        private string _name;

        //will return specific page object for the test scenario
        public Inbox SearchWith { get; private set; }
        public ActionControl KeyBoard { get; private set; }

        private void InitializedObjects()
        {
            SearchWith = new Inbox(TextElement);
            KeyBoard = new ActionControl();
        }
        public SystemDashBoardPage SelectSearchName
        {
            get
            {
                return new SystemDashBoardPage();

            }
           
        }

        public SystemDashBoardPage MemorableWordCheckBox
        {
            get { return new SystemDashBoardPage(); }
        }

        public SystemDashBoardPage ClickOptions
        {
            get { return new SystemDashBoardPage(); }
        }

        private bool IsAt
        {
            get
            {
                var title = "Dashboards: Generic - Microsoft Dynamics CRM";
                return Browser.driver.Title.Contains(title);
            }
        }
        /// <summary>
        /// This constructor search for customer name
        /// </summary>
        /// <param name="name"></param>
        public SystemDashBoardPage(string name)
        {
            _name = name;
        }

        // Deafault contructor
        public SystemDashBoardPage() { }
        public SystemDashBoardPage CustomerName(string name)
        {
            return new SystemDashBoardPage(name);
        }

        // Enter customer name in the search field and press enter keyboard
        public void AndPressEnterKeyBoard()
        {
            ///<summary>
            /// switch to parent frame and to childs frame 
            /// before action is perform
            ///</summary>

            if (!IsAt)
            {
                Pages.GoTo();
            }
                
            Browser.SwitchToPageFrame("contentIFrame0", "dashboardFrame", "WebResource_Componentca309fc");

            // initialized page element
            InitializedObjects();

            // search for customer name 
            SearchWith.InputTextIntoTheField(_name);

            // press enter from keyboard
            KeyBoard.PressEnterkeyBoard();            
        }

        //Assert dropdown search result display search name
        public bool SearchResultList()
        {
            Browser.Wait(TimeSpan.FromSeconds(2));
            if (SearchResult.Text != null)
            {
               return SearchResult.Text.Contains(CustomerInformation.CustomerNameLabel);
            }
            return false;
        }

        // Select customer name from the list
        public void SelectSearchNameFromTheList()
        {
            var visibilityId = "81ec3e69-0b76-e711-80e4-005056ad7101";
            Browser.WaitForElementVisibility(visibilityId);
            SearchName.Click();
        }

        // Assert displayed information are equal to customer information
        public bool ActualValue()
        {
            foreach (var item in SummaryDetailElements)
            {
                if (item.Text.Contains(CustomerInformation.EmailAddress)
                    && item.Text.Contains(CustomerInformation.DateOfBirth))
                {
                    return true;                   
                }               
            }
            return false;
        }
        public void AddMemoWordAndStartInteraction()
        {
            Browser.Wait(TimeSpan.FromSeconds(3));
            Browser.ClickElementWhenItVisible(By.Id("dPAYes"));
            //MemoElement.Click();
            InteractElement.Click();           
        }

        /// <summary>
        /// This function click search name, click memoword
        /// and click start interaction
        /// </summary>
        public void AndStartInteraction()
        {
            SelectSearchNameFromTheList();
            AddMemoWordAndStartInteraction();
            
        }


    }
}
