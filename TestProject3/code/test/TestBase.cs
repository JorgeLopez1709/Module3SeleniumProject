using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject3.code.test
{
    public class TestBase
    {
        
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
