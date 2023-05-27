

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumMobileTests
{
    public class AppiumMobileTests
    {
        private AndroidDriver<AndroidElement> driver;
        private AppiumOptions options;
        private const string appLocation = @"C:\QA_FrontEnd_Retake\taskboard-androidclient.apk";
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";

        [SetUp]
        public void PrepareApp()
        {
            this.options = new AppiumOptions() { PlatformName = "Android" };
            options.AddAdditionalCapability("app", appLocation);
            this.driver = new AndroidDriver<AndroidElement>(new Uri(appiumServer), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [TearDown]
        public void CloseApp()
        {
            driver.Quit();
        }

        [Test]
        public void Test_Search_CheckTheNameOfTheFirstResultTask()
        {
            var apiUrlInputField = driver.FindElementById("taskboard.androidclient:id/editTextApiUrl");
            apiUrlInputField.Clear();
            apiUrlInputField.SendKeys("https://taskboard--itsageorgieva.repl.co/api");

            var connectButton = driver.FindElementById("taskboard.androidclient:id/buttonConnect");
            connectButton.Click();


            var searchField = driver.FindElementById("taskboard.androidclient:id/editTextKeyword");
            searchField.SendKeys("project");
            var searchButton = driver.FindElementById("taskboard.androidclient:id/buttonSearch");
            searchButton.Click();

            TimeSpan.FromSeconds(10);
            var resultTitle = driver.FindElementById("taskboard.androidclient:id/textViewTitle");
            //var resultTitle = driver.FindElementByXPath("android.widget.TextView[2]");
            
            Assert.That(resultTitle.Text, Is.EqualTo("Project skeleton"));
            

        }
    }
}