using OpenQA.Selenium;
using System.Collections.Generic;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages
{
    public class CRMWebPages
    {       
        private IWebElement textElement;
        private IWebElement _amountInputText;
        public IWebElement WindowTitle => Browser.Driver.FindElement(By.Id("pageTitle"));
        public IWebElement SearchResult => Browser.Driver.FindElement(By.Id("results"));
        public IWebElement SearchName => Browser.Driver.FindElement(By.Id("81ec3e69-0b76-e711-80e4-005056ad7101"));
        public IWebElement DefaultSelected => Browser.Driver.FindElement(By.Id("InteractionStep51"));
        public IList<IWebElement> SummaryDetailElements => Browser.Driver.FindElements(By.XPath("//div[@class='verifyrow']/div[@class='value']"));
        public IWebElement MemoElement => Browser.Driver.FindElement(By.Id("dPAYes"));
        public IWebElement InteractElement => Browser.Driver.FindElement(By.Id("action1"));
        public IWebElement InteractionTitle => Browser.Driver.FindElement(By.ClassName("ms-crm-Form-Title"));
        public IWebElement DisplayElement => Browser.Driver.FindElement(By.Id("optevia_contactid_d"));
        public IList<IWebElement> NavContainer => Browser.Driver.FindElements(By.XPath("//div[@id='buttoncontainer']/a"));
        public IWebElement EventButton => Browser.Driver.FindElement(By.XPath("//*[text() ='Right to Buy']"));
        public IReadOnlyCollection<IWebElement> EventButton1 => Browser.FindElement(By.XPath("//a[@class='eventButton']"));
        public static IWebElement TGPDashBoardTitle => Browser.Driver.FindElement(By.Id("FormTitle"));
        public IWebElement StartRightToBuyMiniWindow => Browser.Driver.FindElement(By.XPath("//li[@id='guinness_righttobuy|NoRelationship|Form|optevia.guinness_righttobuy.Start.Button']/span/a"));
        public IWebElement ClickStartAccountEnquiries => Browser.Driver.FindElement(By.XPath("//li[@id='guinness_accountenquiries|NoRelationship|Form|optevia.guinness_accountenquiries.Start.Button']/span/a"));
        public IWebElement ClickStartPayment => Browser.Driver.FindElement(By.XPath("//li[@id ='guinness_payment|NoRelationship|Form|optevia.guinness_payment.Start.Button']/span/a"));
        public IWebElement ClickStartApplicationEnquiry => Browser.Driver.FindElement(By.XPath("//li[@id ='guinness_applicationenquiry|NoRelationship|Form|optevia.guinness_applicationenquiry.Start.Button']/span/a"));
        public IWebElement ClickStartRepairWindow => Browser.Driver.FindElement(By.XPath("//li[@id ='guinness_repair|NoRelationship|Form|optevia.guinness_repair.Start.Button']/span/a"));
        public IWebElement StartTenancyEnforcementWindow => Browser.Driver.FindElement(By.XPath("//li[@id ='guinness_tenancyenforcement|NoRelationship|Form|optevia.guinness_tenancyenforcement.Start.Button']/span/a"));
        public IWebElement ClickStartNeighbourhoods => Browser.driver.FindElement(By.XPath("//li[@id ='guinness_mypropertyandneighbourhood|NoRelationship|Form|optevia.guinness_mypropertyandneighbourhood.Start.Button']/span/a"));
        public static IWebElement Next => Browser.Driver.FindElement(By.Id("butNext"));
        public IWebElement PaymentElement => Browser.Driver.FindElement(By.Id("InteractionStep24"));
        public IWebElement DatePickerElement => Browser.Driver.FindElement(By.Id("2rowimg"));
        public IList<IWebElement> DateElementsData => Browser.Driver.FindElements(By.ClassName("ms-crm-MiniCal-Day"));
        public IWebElement DropDownListElements => Browser.Driver.FindElement(By.Id("InteractionStep2"));
        public IWebElement StandingOrderElement => Browser.Driver.FindElement(By.Id("InteractionStep13"));
        public IWebElement VolElement => Browser.Driver.FindElement(By.Id("InteractionStep12"));
        public IWebElement RadioElement => Browser.Driver.FindElement(By.Id("rad_InteractionStep442"));
        public IWebElement EligibilityMessageElement => Browser.Driver.FindElement(By.Id("InteractionStep51_prompt"));
        public IWebElement CustomerSharingElement => Browser.Driver.FindElement(By.Id("InteractionStep14"));
        public IWebElement NormineeNameElement => Browser.Driver.FindElement(By.Id("InteractionStep28"));
        public IWebElement RelationshipNameElement => Browser.driver.FindElement(By.Id("InteractionStep29"));
        public IWebElement LiveThereElement => Browser.driver.FindElement(By.Id("InteractionStep30"));
        public IWebElement PostageElement => Browser.Driver.FindElement(By.Id("InteractionStep11"));
        public IWebElement CATElement => Browser.Driver.FindElement(By.Id("InteractionStep23_prompt"));
        public IWebElement MessageAdvice => Browser.Driver.FindElement(By.Id("InteractionStep2_prompt"));
        public IWebElement FinishButton => Browser.Driver.FindElement(By.Id("butFinish"));
        public IWebElement ParentWindowElements => Browser.Driver.FindElement(By.XPath("//table[@name='tab_6_section_1']"));
        public IWebElement CommentBox => Browser.Driver.FindElement(By.Id("InteractionStep6"));
        public IWebElement OptionElements => Browser.Driver.FindElement(By.Id("InteractionStep47"));
        public IWebElement NewRepairElement => Browser.Driver.FindElement(By.Id("InteractionStep42"));
        public IWebElement PromptMessage => Browser.Driver.FindElement(By.Id("InteractionStep27_prompt"));
        public IWebElement LinkToResolutionPage => Browser.driver.FindElement(By.Id("1frame1link"));
        public static IWebElement ResolutionTitle => Browser.Driver.FindElement(By.Id("cvc_banner"));
        public IWebElement SafeGuardElement => Browser.Driver.FindElement(By.Id("InteractionStep20"));
        public IWebElement RequiredInfo => Browser.Driver.FindElement(By.Id("InteractionStep26"));
        public IWebElement PropmptMessageWithEmail => Browser.Driver.FindElement(By.Id("InteractionStep29_prompt"));

        public IWebElement TextElement
        {
            get
            {
                return textElement = Browser.driver.FindElement(By.Id("searchbox"));
                
            }
            set
            {
                if (value != null)
                {
                    value = textElement;
                }
            }
        }

        public IWebElement AmountInputText
        {
            get
            {
                return _amountInputText = Browser.Driver.FindElement(By.Id("InteractionStep11"));
            }
            set
            {
                if (value != null)
                {
                    value = _amountInputText;
                }
            }
        }

    }
}
