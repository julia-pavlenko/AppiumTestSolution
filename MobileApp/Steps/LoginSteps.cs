
using AppiumTestSolution.Base;
using MobileApp.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MobileApp.Steps
{
    [Binding]
    internal class LoginSteps : BaseStep
    {
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
        }

        [Given(@"I skip the welcome splash screen")]
        public void GivenISkipTheWelcomeSplashScreen()
        {
            PageFactory.Instance.CurrentPage = GetInstance<SplashPage>();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SplashPage>().SkipSplash();
        }

        [Then(@"I see the Schedule screen")]
        public void ThenISeeTheScheduleScreen()
        {
            var isLeftMenuButtonExist = PageFactory.Instance.CurrentPage.As<SchedulePage>().IsLeftMenuButtonExist();
            Assert.IsTrue(isLeftMenuButtonExist, "The LeftMenu button is not displayed");
        }

        [When(@"I click the Login item in Left menu")]
        public void WhenIClickTheLoginItemInLeftMenu()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SchedulePage>().OpenLeftMenu();
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<LeftMenuPage>().ClickLoginMenuItem();
        }

        [Then(@"I see the user Login screen")]
        public void ThenISeeTheUserLoginScreen()
        {
            var isLoginButtonExist = PageFactory.Instance.CurrentPage.As<LoginPage>().IsLoginButtonIsDisplayed();
            Assert.IsTrue(isLoginButtonExist, "The Login button is not displayed");
        }

        [When(@"I enter the username and password")]
        public void WhenIEnterTheUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            PageFactory.Instance.CurrentPage.As<LoginPage>().EnterCredentials((string) data.Username,(string) data.Password);
        }

        [When(@"click to the Login button")]
        public void WhenClickToTheLoginButton()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<LoginPage>().ClickLoginButton();
        }

    }
}
