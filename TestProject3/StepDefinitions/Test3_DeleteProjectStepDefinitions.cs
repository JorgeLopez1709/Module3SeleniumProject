using System;
using TechTalk.SpecFlow;
using TestProject3.code.page;
using TestProject3.code.test;

namespace Module3SeleniumProject.StepDefinitions
{
    [Binding]
    public class Test3_DeleteProjectStepDefinitions : TestBase
    {
        
        LeftMenu leftMenu = new LeftMenu();
        ProjectSection projectSection = new ProjectSection();

        [When(@"I click on the project to be Deleted")]
        public void WhenIClickOnTheProjectToBeDeleted()
        {
            leftMenu.ClickProjectName("MojixUpdateddddd");
        }

        [When(@"I click on the Delete button")]
        public void WhenIClickOnTheDeleteButton()
        {
            projectSection.projectMenuIcon.Click();
            projectSection.deleteButton.Click();
        }

        [When(@"I confirm the deletion")]
        public void WhenIConfirmTheDeletion()
        {
            Thread.Sleep(2000);
            projectSection.confirmDeleteButton.Click();
        }

        [Then(@"I should not see the Deleted project")]
        public void ThenIShouldNotSeeTheDeletedProject()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(!leftMenu.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!!The project was not deleted");
            CloseBrowser();
        }
    }
}
