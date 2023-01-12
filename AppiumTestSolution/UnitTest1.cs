using AppiumTestSolution.Hooks;
using AppiumTestSolution.Pages;
using NUnit.Framework;

namespace AppiumTestSolution
{
    public class Tests : TestInitialize
    {

        [Test]
        public void PositiveLogin()
        {

            SplashPage splashPage = new SplashPage(AndroidContext);
            SchedulePage schedulePage = splashPage.SkipSplash();

            LeftMenuPage leftMenuPage = schedulePage.OpenLeftMenu();
            LoginPage loginMenu = leftMenuPage.ClickLoginMenuItem();

            loginMenu.Login("test@test.com", "pas123");




        }
    }
}