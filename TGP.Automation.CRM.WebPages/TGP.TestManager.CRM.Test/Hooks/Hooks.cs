using NUnit.Framework;
using TGP.Automation.CRM.WebPages.Utilities;

namespace TGP.TestManager.CRM.Test.Hooks
{
    public class Hooks
    {
        [SetUp]
        public void SetUp()
        {
            Browser.LaunchBrowser(BrowserTypes.ChromeDriver);
        }

        [TearDown]
        public void CleanUp()
        {
            Browser.CloseBrowser();
        }
    }
}
