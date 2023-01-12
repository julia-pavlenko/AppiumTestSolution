using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumTestSolution.Pages
{
    public class SplashPage
    {
        public AndroidDriver<AndroidElement> _appiumDriver;

        public SplashPage(AndroidDriver<AndroidElement> appiumDriver)
        {
            _appiumDriver = appiumDriver;
        }

        private AppiumWebElement skipButton => _appiumDriver.FindElementByXPath("//ion-button[text()='Skip']");

        public SchedulePage SkipSplash()
        {
            skipButton.Click();
            return new SchedulePage(_appiumDriver);
        }
    }
}
