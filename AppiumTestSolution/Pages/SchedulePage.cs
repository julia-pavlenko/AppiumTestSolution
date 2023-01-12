using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumTestSolution.Pages
{
    public class SchedulePage
    {
        private AndroidDriver<AndroidElement> _appiumDriver;

        public SchedulePage(AndroidDriver<AndroidElement> appiumDriver)
        {
            _appiumDriver = appiumDriver;
        }

        private AppiumWebElement leftMenuButton => _appiumDriver.FindElementByXPath("//ion-menu-button");

        public LeftMenuPage OpenLeftMenu()
        {
            leftMenuButton.Click();
            return new LeftMenuPage(_appiumDriver);
        }

    }
}
