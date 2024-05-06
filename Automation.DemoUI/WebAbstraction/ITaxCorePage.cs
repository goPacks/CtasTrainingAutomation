using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction
{
    public interface ITaxCorePage
    {

        void CheckPageTitle(string pageTitle);

        void ClickMenu(string menu);

        void ClickSubMenu(string subMenu);
    }
}
