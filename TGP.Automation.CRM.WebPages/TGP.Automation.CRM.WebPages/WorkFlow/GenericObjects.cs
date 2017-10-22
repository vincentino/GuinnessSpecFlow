namespace TGP.Automation.CRM.WebPages
{
    public class GenericObjects: CRMWebPages
    {
        public static void GoToNextPage()
        {
            Next.Click();
        }

        public static void ClickNextButtonTwiceToGoToNextPage()
        {
            GoToNextPage();
            Next.Click();
        }
    }
}