using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;

namespace AppiumTestSolution.Utilities
{
    public class Base
    {
        public AppiumLocalService AppiumServiceContext;

        public AndroidDriver<AndroidElement> AndroidContext;

        public AppiumUtilities AppiumUtilities => new AppiumUtilities(AppiumServiceContext, AndroidContext);

        public AndroidDriver<AndroidElement> StartAppiumServerForHybrid()
        {
            //Appium local service
            AppiumServiceContext = AppiumUtilities.StartAppiumLocalService();
            AndroidContext = AppiumUtilities.InitAndroidHybridApp();

            return AndroidContext;
        }
    }
}
