using OpenQA.Selenium.Support.PageObjects;
using TGP.Automation.CRM.WebPages.PageIntertaction;
using TGP.Automation.CRM.WebPages.Utilities;


namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        /// <summary>
        /// If is not at CRM Home Page.Go to CRM Home page
        /// </summary>
        public static void GoTo()
        {           
             Browser.LaunchURL();                      
        }
        public static SystemDashBoardPage SystemDashBoard
        {
            get
            {
                return GetPage<SystemDashBoardPage>();

            }
        }
        public static GuinnessInteractionPage InteractionDashBoard
        {
            get { return GetPage<GuinnessInteractionPage>(); }

        }
        public static RightToBuyPage RightToBuyDashBoard
        {
            get { return GetPage<RightToBuyPage>(); }           
        }

        public static RightToBuyMiniWindowPage RightToBuyDialogWindow
        {
            get { return GetPage<RightToBuyMiniWindowPage>(); }
        }

        public static AccountEnquiriesPage AccountEnquiryDashBoard
        {
            get { return GetPage<AccountEnquiriesPage>(); }
        }

        public static AccountEnquiriesMiniWindowPage AccountEnquiriesDaialog
        {
            get { return GetPage<AccountEnquiriesMiniWindowPage>(); }
        }

        public static PaymentPage PaymentEventDashboard
        {
            get { return GetPage<PaymentPage>(); }
        }

        public static PaymentDialogPage PaymentDialogWindow
        {
            get { return GetPage<PaymentDialogPage>(); }
        }

        public static ApplicationEnquiriesPage ApplicationEquiriesDashBoard
        {
            get { return GetPage<ApplicationEnquiriesPage>(); }
        }

        public static ApplicationEnquiriesDialogWindowPage ApplicationEquiriesDialogWindow
        {
            get { return GetPage<ApplicationEnquiriesDialogWindowPage>(); }
        }

        public static RepairsPage RepairsDashBoard
        {
            get { return GetPage<RepairsPage>(); }
        }

        public static RepairsDialogWindowPage RepairsDialogWindow
        {
            get { return GetPage<RepairsDialogWindowPage>(); }
        }

        public static TenancyEnforcementPage TenancyEncorcementDashBoard
        {
            get { return GetPage<TenancyEnforcementPage>(); }
        }

        public static TenancyEnforcementDialogWindowPage TenancyEncorcementDialogWindow
        {
            get { return GetPage<TenancyEnforcementDialogWindowPage>(); }
        }

        public static ResolutionPage ResolutionWindow
        {
            get { return GetPage<ResolutionPage>(); }
        }

        public static NeighbourhoodsPage NeighbourhoodsDashBoard
        {
            get { return GetPage<NeighbourhoodsPage>(); }
        }

        public static NeighbourhoodsDialogWindowPage NeighbourHoodsDialogWindow
        {
            get { return GetPage<NeighbourhoodsDialogWindowPage>(); }
        }

        
    }
}

