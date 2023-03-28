using AppiumTestSolution.Base;
using AppiumTestSolution.Config;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace MobileApp.Hooks
{
    [Binding]
    public class TestInitialize 
    {
        [BeforeScenario]
        public void Initialize()
        {
            ConfigReader.InitializeSettings();
            DriverFactory.Instance.InitAppiumDriver<AndroidDriver<AppiumWebElement>>(MobileType.Hybrid);
        }

        [TearDown]
        public void Cleanup()
        {
            DriverFactory.Instance.CloseAppiumApp();
        }

    }
}
