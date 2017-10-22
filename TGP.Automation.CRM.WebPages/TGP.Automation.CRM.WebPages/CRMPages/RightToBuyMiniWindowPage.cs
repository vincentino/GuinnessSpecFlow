using System;
using TGP.Automation.CRM.WebPages.CustomerCredentials;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class RightToBuyMiniWindowPage: CRMWebPages
    {
        private string _name;
        private string _relationship;
        private string _timeAtAddress;
        public const string title = "Right to Buy - Start Dialog";

        public RightToBuyMiniWindowPage SharingRightWith(string name)
        {
            return new RightToBuyMiniWindowPage(name);
        }

        public RightToBuyMiniWindowPage() { }

        public RightToBuyMiniWindowPage(string name)
        {
            _name = name;
            
        }

        public RightToBuyMiniWindowPage WithTimeLiveAtTheAddress(string timeAtAddress)
        {
            _timeAtAddress = timeAtAddress;
            return this;
        }

        public RightToBuyMiniWindowPage WithRelationship(string relationship)
        {
            _relationship = relationship;
            return this;
        }
        public RightToBuyMiniWindowPage CheckWith
        {
            get { return new RightToBuyMiniWindowPage(); }
        }

        public RightToBuyMiniWindowPage ClickNext
        {
            get { return new RightToBuyMiniWindowPage(); }
        }

        public RightToBuyMiniWindowPage SelectWith
        {
            get { return new RightToBuyMiniWindowPage(); }
        }
        public bool IsAt
        {           
            get
            {
                Browser.Wait(TimeSpan.FromSeconds(2));
                return Browser.DialogWindowTitle(title);                

            }           
        }

        //close window without performing action
        public void CloseRightToBuyDialogWindow()
        {
            Browser.CloseOtherWindows("Right to Buy - Start Dialog");
        }

        public void CanClickNextButton()
        {
            GenericObjects.GoToNextPage();
        }
        public void SelectNewApplication()
        {
            var selectFromTheList = "Make a New Application";
            Browser.SelectWithVisibleText(DropDownListElements, selectFromTheList);
            CanClickNextButton();
        }
        public void VoluntarySale()
        {
            var voluntarySale = "Voluntary Sale";
            Browser.SelectWithVisibleText(VolElement, voluntarySale);
            GenericObjects.GoToNextPage();

        }
        public void SocialBehaviour()
        {
            RadioElement.Click();
            GenericObjects.GoToNextPage();
        }

        public bool WarningMessage(string eligibilityAdviced)
        {
            if (EligibilityMessageElement.Text.Equals(eligibilityAdviced))
            {
                GenericObjects.ClickNextButtonTwiceToGoToNextPage();
                return true;
            }
            return false;
        }
        public void SharingRight()
        {
            var yes = "Yes";
            Browser.SelectWithVisibleText(CustomerSharingElement, yes);
            GenericObjects.GoToNextPage();
        }
        public void CustomerNormineeName()
        {
            NormineeNameElement.SendKeys(_name);
            RelationshipNameElement.SendKeys(_relationship);
            LiveThereElement.SendKeys(_timeAtAddress);
            GenericObjects.GoToNextPage();
        }

        /// <summary>
        /// Method overloading. This function is for regression test only
        /// </summary>
        /// <param name="sharingRightName"></param>
        /// <param name="relation"></param>
        /// <param name="time"></param>
        public void CustomerNormineeName(string sharingRightName, string relationship, string time)
        {
            NormineeNameElement.SendKeys(sharingRightName);
            RelationshipNameElement.SendKeys(relationship);
            LiveThereElement.SendKeys(time);
            GenericObjects.GoToNextPage();
        }
        public void ApplicationForm()
        {
            var appForm = "Application Form";
            Browser.SelectWithVisibleText(DropDownListElements, appForm);
            GenericObjects.GoToNextPage();
        }
        public void PostOfficeOption()
        {
            var selectPost = "No - send by post";
            Browser.SelectWithVisibleText(PostageElement, selectPost);
            GenericObjects.GoToNextPage();
        }

        public void InputAddtionalInformation(string info)
        {
            DropDownListElements.SendKeys(info);
            GenericObjects.ClickNextButtonTwiceToGoToNextPage();
        }

        public void FinishRightToBuyDialogWindow()
        {
            if (DialogTitle.AtDialogWindow)
            {
                GenericObjects.GoToNextPage();
                SelectNewApplication();
                VoluntarySale();
                SocialBehaviour();
                WarningMessage(CustomerInformation.EligibilityAdviced);
                SharingRight();
                CustomerNormineeName(CustomerInformation.CustomerNorminee,
                    CustomerInformation.Relative, CustomerInformation.TimeAtTheAddress);
                ApplicationForm();
                PostOfficeOption();
                InputAddtionalInformation(CustomerInformation.CommentInput);
                Browser.CloseOtherWindows("Right to Buy - Start Dialog");
            }
            
        }
    }
}