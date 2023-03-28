using AppiumTestSolution.Base;
using OpenQA.Selenium.Appium;

namespace MobileApp.Pages
{
    public class SchedulePage : BasePage
    {
        private AppiumWebElement leftMenuButton => AppiumDriver.FindElementByXPath("//ion-menu-button");

        public LeftMenuPage OpenLeftMenu()
        {
            DriverFactory.Instance.WaitForElement(leftMenuButton);
            leftMenuButton.Click();
            return GetInstance<LeftMenuPage>();
        }

        public bool IsLeftMenuButtonExist()
        {
            DriverFactory.Instance.WaitForElement(leftMenuButton);
            return leftMenuButton.Displayed;
        }

    }
}
