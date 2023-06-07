using System;
using TechTalk.SpecFlow;
using TestProject3.code.page;
using TestProject3.code.test;

namespace TestProject3.StepDefinitions
{
    [Binding]
    public class LoginToTodoIstStepDefinitions : TestBase
    {
        
        MainPage mainPage = new MainPage();
        LoginPage loginPage = new LoginPage();
        UserPage userPage = new UserPage();
        [Given(@"I have the valid credentials")]
        public void GivenIHaveTheValidCredentials()
        {
            OpenBrowser();
            mainPage.loginButton.Click();
        }

        [When(@"I click on login button with the filled required fields")]
        public void WhenIClickOnLoginButtonWithTheFilledRequiredFields()
        {
            loginPage.Login("jorge.e.lopez.1709@gmail.com", "Password1234");
        }

        [Then(@"the TodoIst Main page is displayed")]
        public void ThenTheTodoIstMainPageIsDisplayed()
        {
            Thread.Sleep(10000);
            Assert.IsTrue(userPage.menuButton.IsControlDisplayed(),
                "ERROR !! the login was not successfully, review credentials please");

            CloseBrowser();
        }
    }
}
