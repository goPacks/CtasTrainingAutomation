using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.WebAbstraction
{
    public interface ITp360Page
    {

        void CheckPageTitle(string pageTitle);

        void ClickMenu(string menu);

        void ClickSubMenu(string subMenu);

    }
}
