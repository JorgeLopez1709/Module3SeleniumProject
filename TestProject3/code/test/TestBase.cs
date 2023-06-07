using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject3.code.page;

namespace TestProject3.code.test
{
    public class TestBase
    {
        MainPage mainPage = new MainPage();
        LoginPage loginSection = new LoginPage();
        LeftMenu leftMenu = new LeftMenu();
        ProjectSection projectSection = new ProjectSection();
        public void OpenBrowser()
        {
            session.Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com/es");
        }

        
        public void CloseBrowser()
        {
            session.Session.Instance().CloseBrowser();
        }
    }
}
