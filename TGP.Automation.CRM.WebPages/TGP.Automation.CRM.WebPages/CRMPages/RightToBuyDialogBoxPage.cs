using System;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.PageIntertaction
{
    
    public class RightToBuyDialogBoxPage :CRMWebPages
    {
        //private string _name;
        //private string _relationship;
        //private string _timeAtAddress;

        //public RightToBuyDialogBoxPage() { }

        /// <summary>
        /// Parameter constructor to perform right to share method 
        /// fluently.
        /// </summary>
        /// <param name="name"></param>
        public RightToBuyDialogBoxPage(string name)
        {
            _name = name;
        }

        //public RightToBuyDialogBoxPage WithTimeLiveAtTheAddress(string timeAtAddress)
        //{
        //    _timeAtAddress = timeAtAddress;
        //    return this;
        //}

        //public RightToBuyDialogBoxPage WithRelationship(string relationship)
        //{
        //    _relationship = relationship;
        //    return this;
        //}

        //public RightToBuyDialogBoxPage SharingRightWith(string name)
        //{
        //    return new RightToBuyDialogBoxPage(name);
        //}
        public bool IsAt()
        {
            Browser.MiniWindow();
            return true;
        }

        //public bool MiniWindowTitlePage
        //{
        //    get
        //    {
        //        if (SmallWindowTitle.Text != null)
        //        {
        //            return SmallWindowTitle.Text.Contains("Right to Buy - Start Dialog");

        //        }
        //        else
        //            return string.Empty == "";
        //    }
        //}

        //public RightToBuyDialogBoxPage SelectWith
        //{
        //    get { return new RightToBuyDialogBoxPage(); }
        //}

        //public RightToBuyDialogBoxPage CheckWith
        //{
        //    get { return new RightToBuyDialogBoxPage(); }
        //}

        //public void ClickNextButton()
        //{
        //    Next.Click();
        //}

        //public void NewApplication()
        //{
        //    var selectFromTheList = "Make a New Application";
        //    AppElement.Click();
        //    Browser.SelectWithVisibleText(AppElement, selectFromTheList);

        //    ClickNextButton();
        //}

        //public void VoluntarySale()
        //{
        //    var selectFromTheList = "Voluntary Sale";
        //    VolElement.Click();
        //    Browser.SelectWithVisibleText(VolElement, selectFromTheList);
        //    ClickNextButton();
        //    Browser.Wait(TimeSpan.FromSeconds(3));
        //}

        //public void SocialBehaviour()
        //{                     
        //    RadioElement.Click();
        //    ClickNextButton();
        //    //DoubleNextBotton();
        //}

        // Eligibity advice message
        //public bool WarningMessage(string eligibilityAdviced)
        //{
        //    if(EligibilityMessageElement.Text.Equals(eligibilityAdviced))
        //    {
        //        DoubleNextBotton();
        //        return true;
        //    }
        //    return false;          
        //}

        public void NextWindow()
        {
            ClickNextButton();
        }

        //private void DoubleNextBotton()
        //{
        //    ClickNextButton();
        //    ClickNextButton();
        //}

        //public void SharingRight()
        //{
        //    var yes = "Yes";
        //    CustomerSharingElement.Click();
        //    Browser.SelectWithVisibleText(CustomerSharingElement, yes);
        //    ClickNextButton();
        //}
        //public void CustomerNormineeName()
        //{
        //    NorminneNameElement.SendKeys(_name);
        //    RelationshipNameElement.SendKeys(_relationship);
        //    LiveThereElement.SendKeys(_timeAtAddress);

        //    ClickNextButton();

        //}
        //public void ApplicationForm()
        //{
        //    var selectFromTheList = "Application Form";
        //    AppElement.Click();
        //    Browser.SelectWithVisibleText(AppElement, selectFromTheList);
        //    ClickNextButton();
        //}
        //public void PostOfficeOption()
        //{
        //    var selectFromTheList = "No - send by post";
        //    PostageElement.Click();
        //    Browser.SelectWithVisibleText(PostageElement, selectFromTheList);
        //    ClickNextButton();
        //}

        //public void MakeComment(string info)
        //{            
        //    AppElement.SendKeys(info);
        //    DoubleNextBotton();
        //}

        //public void FinishDialogInteraction()
        //{
        //    //FinishButton.Click();
        //    Browser.CloseMiniWindow();

        //}


    }
    
}