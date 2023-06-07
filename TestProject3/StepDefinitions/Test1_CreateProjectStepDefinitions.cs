using System;
using TechTalk.SpecFlow;
using TestProject3.code.page;
using TestProject3.code.session;
using TestProject3.code.test;

namespace Module3SeleniumProject.StepDefinitions
{
    [Binding]
    public class Test1_CreateProjectStepDefinitions : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginPage loginSection = new LoginPage();
        LeftMenu leftMenu = new LeftMenu();

        [Given(@"I am logged in TodoIst")]
        public void GivenIAmLoggedInTodoIst()
        {
            OpenBrowser();
            this.mainPage.loginButton.Click();
            loginSection.Login("jorge.e.lopez.1709@gmail.com", "Password1234");
        }

        [When(@"I click on the Add New Project button")]
        public void WhenIClickOnTheAddNewProjectButton()
        {
            try { mainPage.TimeZoneCloseButton.Click(); }
            catch (Exception ex) { }
            leftMenu.addNewProjectButton.Click();
        }

        [When(@"I enter a valid project name")]
        public void WhenIEnterAValidProjectName()
        {
            leftMenu.projectNameTxtBox.SetText("Mojix909090");
            
        }

        [When(@"I click the Save button")]
        public void WhenIClickTheSaveButton()
        {
            leftMenu.saveButton.Click();
        }

        [Then(@"I should see the new project name displayed")]
        public void ThenIShouldSeeTheNewProjectNameDisplayed()
        {
            Thread.Sleep(10000);
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("Mojix909090"), "ERROR!!The project was not created");
            CloseBrowser();
        }
    }
}
