using AppiumTestSolution.Base;
using OpenQA.Selenium.Appium;

namespace MobileApp.Pages
{
    public class SplashPage : BasePage
    {
        private AppiumWebElement skipButton => AppiumDriver.FindElementByXPath("//ion-button[text()='Skip']");

        public SchedulePage SkipSplash()
        {
            skipButton.Click();
            return GetInstance<SchedulePage>();
        }
    }
}
