using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumTestSolution.Pages
{
    public class LoginPage
    {
        private AndroidDriver<AndroidElement> _appiumDriver;

        public LoginPage(AndroidDriver<AndroidElement> appiumDriver)
        {
            _appiumDriver = appiumDriver;
        }

        private AppiumWebElement usernameField => _appiumDriver.FindElementByXPath("//input[@name='username']");

        private AppiumWebElement passwordField => _appiumDriver.FindElementByXPath("//input[@name='password']");

        private AppiumWebElement loginButton => _appiumDriver.FindElementByXPath("//ion-button[text()='Login']");

        public void Login(string username, string password)
        {
            Thread.Sleep(3000);
            usernameField.Clear();
            usernameField.SendKeys(username);
            passwordField.Clear();
            passwordField.SendKeys(password);
            loginButton.Click();
        }

    }
}
