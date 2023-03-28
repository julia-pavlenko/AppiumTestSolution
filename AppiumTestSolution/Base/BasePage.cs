using OpenQA.Selenium.Appium;

namespace AppiumTestSolution.Base
{
    public class BasePage
    {
        public AppiumDriver<AppiumWebElement> AppiumDriver;

        public BasePage() => AppiumDriver = DriverFactory.Instance.AppiumDriver;

        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            var T = Activator.CreateInstance(typeof(TPage));
            return (TPage)T;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
