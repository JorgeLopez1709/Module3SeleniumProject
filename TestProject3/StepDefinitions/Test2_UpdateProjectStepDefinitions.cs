using System;
using TechTalk.SpecFlow;
using TestProject3.code.page;
using TestProject3.code.test;

namespace Module3SeleniumProject.StepDefinitions
{
    [Binding]
    public class Test2_UpdateProjectStepDefinitions : TestBase
    {
        LeftMenu leftMenu = new LeftMenu();
        MainPage mainPage = new MainPage();

        [When(@"I select the project to be updated")]
        public void WhenISelectTheProjectToBeUpdated()
        {
            try { mainPage.TimeZoneCloseButton.Click(); }
            catch (Exception ex) { }
            leftMenu.ClickProjectName("Mojix909090");
        }

        [When(@"I update the project name")]
        public void WhenIUpdateTheProjectName()
        {
            leftMenu.subMenuIcon.Click();
            leftMenu.editButton.Click();
            leftMenu.projectNameTxtBox.SetText("MojixUpdateddddd");
        }

        

        [Then(@"I should see the updated project name")]
        public void ThenIShouldSeeTheUpdatedProjectName()
        {
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!!The project was not updated");
            Thread.Sleep(10000);
            CloseBrowser();
        }
    }
}
