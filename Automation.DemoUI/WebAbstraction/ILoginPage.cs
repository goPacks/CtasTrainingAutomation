using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.WebAbstraction
{
    public interface ILoginPage
    {
        void NavigateTo(string URL);
        void EnterCredentials(string tin, string passWord);

        void CheckPageTitle(string pageTitle);

        void ClickLogin();

        void ClickNewReg();

    }
}
