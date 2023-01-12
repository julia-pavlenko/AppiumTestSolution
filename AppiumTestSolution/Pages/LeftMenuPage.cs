using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumTestSolution.Pages
{
    public class LeftMenuPage
    {
        private AndroidDriver<AndroidElement> _appiumDriver;

        public LeftMenuPage(AndroidDriver<AndroidElement> appiumDriver)
        {
            _appiumDriver = appiumDriver;
        }

        

        private AppiumWebElement loginMenuItem => _appiumDriver.FindElementByXPath("//ion-item[@routerlink='/login']");

        public LoginPage ClickLoginMenuItem()
        {
            loginMenuItem.Click();
            return new LoginPage(_appiumDriver);
        }


    }
}
