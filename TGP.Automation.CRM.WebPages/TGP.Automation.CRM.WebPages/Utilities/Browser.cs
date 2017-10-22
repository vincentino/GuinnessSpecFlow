using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TGP.Automation.CRM.WebPages.Utilities
{
    public enum BrowserTypes
    {
        InternentExplorer,
        FirefoxDriver,
        ChromeDriver,
    }
    public static class Browser
    {
        public static IWebDriver driver { get; private set; }
        private static WebDriverWait _wait { get; set; }
        private static SelectElement select;    
        private static string _baseUrl = "https://crmuat.tgp.gp.local/CRMPreProd/main.aspx#178172665";
        public const string DriverPath = "C:/Tools/InternentExplorerDriver";
        public static IWebElement element;
        public static ISearchContext Driver
        {
            get
            {
                return driver;
                
            }
        }
        public static IWebDriver InitializeChromeDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }

        public static IWebDriver InitializeIE()
        {
            driver = new InternetExplorerDriver(DriverPath);
            return driver;
        }

        public static IWebDriver InitializeFirefoxDriver()
        {
            driver = new FirefoxDriver();
            return driver;
        }
        /// <summary>
        /// This function launches browser based on the 
        /// browser types passing into the argument
        /// </summary>
        /// <param name="browser"></param>
        public static void LaunchBrowser(BrowserTypes browser)
        {
            switch (browser)
            {
                case BrowserTypes.ChromeDriver:
                   InitializeChromeDriver();
                    break;
                case BrowserTypes.InternentExplorer:
                    InitializeIE();
                    break;
                case BrowserTypes.FirefoxDriver:
                    InitializeFirefoxDriver();
                        break;
                default:
                    Console.WriteLine($"Browser is initializing: {browser}");
                    break;
            }
        }

        public static void LaunchURL()
        {
            driver.Navigate().GoToUrl(_baseUrl);
            driver.Manage().Window.Maximize();
        }
        public static void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
        public static void SelectWithVisibleText(IWebElement element, string text)
        {
            element.Click();
            select = new SelectElement(element);
            select.SelectByText(text);
        }
        public static void WaitForElementVisibility(string elementString)
        {
            var locatorType = By.Id(elementString);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
            _wait.Until(ExpectedConditions.ElementIsVisible(locatorType));
        }

        // Wait for element to display before action is perform
        public static void WaitForVisibilityOfElement(int timeOutSeconds, string text)
        {
            var waitForElement = By.Id(text);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutSeconds));
            _wait.Until(ExpectedConditions.ElementIsVisible(waitForElement));
        }
     
        //Custom method to find List of Elements
        public static IReadOnlyCollection<IWebElement> FindElement(By by)
        {
            return driver.FindElements(by);
        }

        public static bool Title(string title)
        {
            if (title != null)
            {
                return driver.Title.Contains(title);
            }
            return false;           
        }

        public static IWebElement ClickElementWhenItVisible(By by)
        {
            var count = 0;
            var elementToBeClick = driver.FindElement(by);
            try
            {
                if (elementToBeClick.Displayed)
                {
                    elementToBeClick.Click();

                    if (count == 3)
                    {
                        throw new Exception();
                    }
                }
                
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("Cannot finr element " + elementToBeClick);
            }
            
            Wait(TimeSpan.FromSeconds(4));
            count++;
            return elementToBeClick = driver.FindElement(by);
        }

        public static IWebElement firstFrame;

        public static void SwitchToPageFrame(string parentFrame, string firstChildFrame, string lastChildFrame)
        {
            firstFrame = driver.FindElement(By.Id(parentFrame));
            driver.SwitchTo().Frame(firstFrame);
            
            IWebElement secondFrame = driver.FindElement(By.Id(firstChildFrame));
            driver.SwitchTo().Frame(secondFrame);

            IWebElement thirdElement = driver.FindElement(By.Id(lastChildFrame));
            driver.SwitchTo().Frame(thirdElement);
        }

        public static void SwitchToPageFrame(string frames)
        {
            IWebElement frame = Driver.FindElement(By.Id(frames));
            driver.SwitchTo().Frame(frame);
        }
        public static void SwitchToDefaultWindow()
        {
            driver.SwitchTo().DefaultContent();
        }

        public static void WaitUntilTilePageIsDisplayed(string text, int timeOUT)
        {
           var titlePage =  By.ClassName(text);
           var eleTitle = Driver.FindElement(titlePage);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOUT));
            _wait.Until(ExpectedConditions.TextToBePresentInElement(eleTitle, text));
        }

        public static void WaitUntilPageTitleDisplayed(string title)
        {
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            _wait.Until(ExpectedConditions.TitleContains(title));
        }
        // Control waiting time before perform action on the page
        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)timeSpan.TotalSeconds * 1000);
        }
        public static bool DialogWindowTitle(string smallWindowTitle)
        {
            try
            {
                SwitchToNewWindow();

                if (driver.Title != null)
                {
                    driver.CurrentWindowHandle.Contains(smallWindowTitle);
                        //StringComparison.CurrentCultureIgnoreCase);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
            return string.IsNullOrEmpty(smallWindowTitle);
        }

        public static string MainWindow()
        {
           return driver.CurrentWindowHandle;
        }
        public static string CurrentWindowTitle()
        {
            var windowTitle = driver.Title;
            return windowTitle;
        }

        public static bool CloseOtherWindows(string title)
        {
            string openWindow = driver.CurrentWindowHandle;
            
            IReadOnlyList<string> allWindow = driver.WindowHandles;
            for (int i = 0; i < allWindow.Count; i++)
            {
                driver.SwitchTo().Window(allWindow[i]);

                if (driver.SwitchTo().Window(allWindow[i]).Title.Contains(title))
                {
                    driver.SwitchTo().Window(allWindow[1]);
                    driver.Close();
                    break;
                }
                else if (driver.SwitchTo().Window(allWindow[1]).Title == title)
                {
                    driver.SwitchTo().Window(allWindow[1]);
                    driver.Close();
                    break;
                }
                else
                {
                    driver.SwitchTo().Window(allWindow[0]);
                }
            }
            driver.SwitchTo().Window(allWindow[0]);
            if (driver.WindowHandles.Count == 0 )
            {
                return true;
            }
            return false;
            
        }

        public static void SwitchToNewWindow()
        {
            string parentWindow = driver.CurrentWindowHandle;
            string newWindowHandle = null;
            IReadOnlyCollection<string> crmWindows = driver.WindowHandles;

            for (int i = 0; i < 10; i++)
            {
                if (crmWindows.Count > 1)
                {
                    foreach (var allWindows in crmWindows)
                    {
                        if (allWindows != parentWindow)
                        {
                            newWindowHandle = allWindows;
                            break;
                        }
                    }

                }
                driver.SwitchTo().Window(newWindowHandle);
                break;
            }
            if (parentWindow == newWindowHandle)
            {
                throw new TimeoutException("Time Out - No window found");
            }
            Wait(TimeSpan.FromSeconds(4));
            


        }
    }
}
