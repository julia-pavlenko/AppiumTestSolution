using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;

namespace AppiumTestSolution.Utilities
{
    public class AppiumUtilities : Base
    {
        private AppiumLocalService _appiumLocalService;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly AndroidDriver<AppiumWebElement> _androidAppiumDriver;

        public AppiumUtilities(AppiumLocalService appiumLocalService, AndroidDriver<AndroidElement> androidDriver)
        {
            _appiumLocalService = appiumLocalService;
            _androidDriver = androidDriver;
        }
        public AndroidDriver<AndroidElement> InitAndroidHybridApp()
        {
            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability("deviceName", "Pixel_6_API_33");
            options.AddAdditionalCapability("chromedriverExecutable", @"C:\Users\yvehner\Desktop\Appium Course\driver\chromedriver.exe");
            options.AddAdditionalCapability("app", @"C:\Users\yvehner\Desktop\Appium Course\app-debug-1.apk");
            
            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(_appiumLocalService, options);
            androidDriver.Context = androidDriver.Contexts.First(x => x.Contains("WEBVIEW_"));

            return androidDriver;
        }

        public AppiumLocalService StartAppiumLocalService()
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }

        public AppiumLocalService StartAppiumLocalService(int portNumber)
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }

        public void CloseAppiumServer()
        {
            _androidDriver.CloseApp();
        }
    }
}
