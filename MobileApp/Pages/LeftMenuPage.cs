using AppiumTestSolution.Base;
using OpenQA.Selenium.Appium;

namespace MobileApp.Pages
{
    public class LeftMenuPage : BasePage
    {
        private AppiumWebElement loginMenuItem => AppiumDriver.FindElementByXPath("//ion-item[@routerlink='/login']");

        public LoginPage ClickLoginMenuItem()
        {
            DriverFactory.Instance.WaitForElement(loginMenuItem);
            loginMenuItem.Click();
            return GetInstance<LoginPage>();
        }
    }
}
