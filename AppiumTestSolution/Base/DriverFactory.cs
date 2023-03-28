using AppiumTestSolution.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Support.UI;

namespace AppiumTestSolution.Base
{
    public enum MobileType
    {
        Native,
        Hybrid
    }

    public class DriverFactory
    {
        private AppiumLocalService _appiumLocalService;
        private static Lazy<DriverFactory> _instance = new Lazy<DriverFactory>(() => new DriverFactory());

        public static DriverFactory Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private DriverFactory()
        {
        }

        public AppiumDriver<AppiumWebElement> AppiumDriver { get; set; }
        
        public T InitAppiumDriver<T>(MobileType mobileType) where T : AppiumDriver<AppiumWebElement>
        {
            AppiumOptions options = new AppiumOptions();
            options.PlatformName = Settings.PlatformName;
            options.AddAdditionalCapability("deviceName", Settings.DeviceName);
            options.AddAdditionalCapability("app", Settings.AUTPath);
            options.AddAdditionalCapability("appWaitActivity", "*.MainActivity");
            var builder = StartAppiumLocalService();
            
            if (mobileType == MobileType.Hybrid)
            {
                options.AddAdditionalCapability("chromedriverExecutable", Settings.ChromeDriverPath);
                AppiumDriver = (T)Activator.CreateInstance(typeof(T), builder, options);
                AppiumDriver.Context = AppiumDriver.Contexts.First(x => x.Contains("WEBVIEW_"));
            }
            else
            {
                AppiumDriver = (T)Activator.CreateInstance(typeof(T), builder, options);
            }
            return (T)AppiumDriver;
        }

        private AppiumLocalService StartAppiumLocalService()
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }

        private AppiumLocalService StartAppiumLocalService(int portNumber)
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();
            if (!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();

            return _appiumLocalService;
        }

        public void CloseAppiumApp()
        {
            AppiumDriver.CloseApp();
        }

        public void WaitForElement(AppiumWebElement appiumWebElement)
        {
            DefaultWait<AppiumDriver<AppiumWebElement>> fluentWait =
                new DefaultWait<AppiumDriver<AppiumWebElement>>(AppiumDriver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => appiumWebElement);
        }

    }
}
