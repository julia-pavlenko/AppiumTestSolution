using AppiumTestSolution.Base;
using OpenQA.Selenium.Appium;

namespace MobileApp.Pages
{
    public class LoginPage : BasePage
    {
        private AppiumWebElement usernameField => AppiumDriver.FindElementByXPath("//input[@name='username']");

        private AppiumWebElement passwordField => AppiumDriver.FindElementByXPath("//input[@name='password']");

        private AppiumWebElement loginButton => AppiumDriver.FindElementByXPath("//ion-button[text()='Login']");

        public void EnterCredentials(string username, string password)
        {
            Thread.Sleep(3000);
            usernameField.Clear();
            usernameField.SendKeys(username);
            passwordField.Clear();
            passwordField.SendKeys(password);
            AppiumDriver.HideKeyboard();
        }

        public SchedulePage ClickLoginButton()
        {
            loginButton.Click();
            return GetInstance<SchedulePage>();
        }


        public bool IsLoginButtonIsDisplayed()
        {
            return loginButton.Displayed;
        }

    }
}
