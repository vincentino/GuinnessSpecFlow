using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.Automation.CRM.WebPages.CRMPage
{
    public class ResolutionPage : CRMWebPages
    {
        const string resolutinTitle = "Resolution";

        public static bool IsAt
        {
            get
            {
                //Get the Resolution page title
               Browser.SwitchToNewWindow();
                if (ResolutionTitle.Text != null)
                {
                    ResolutionTitle.Text.Equals(resolutinTitle);
                    return true;
                }
                else
                    return string.IsNullOrEmpty(resolutinTitle);

            }
        }
    }
}