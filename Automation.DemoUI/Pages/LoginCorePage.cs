using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Framework.Core.WebUI.Base;

namespace Automation.DemoUI.Pages
{
    public class LoginCorePage : TestBase, ILoginCorePage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;



        IAtBy byUserName => GetBy(LocatorType.Id, "username");
        IAtWebElement UserName => _idriver.FindElement(byUserName);

        IAtBy byPassword => GetBy(LocatorType.Id, "password");
        IAtWebElement Password => _idriver.FindElement(byPassword);

        //button[text()='LOGIN']

        IAtBy bySubmitBtn => GetBy(LocatorType.Xpath, "//button[text()='LOGIN']");
        IAtWebElement SubmitBtn => _idriver.FindElement(bySubmitBtn);

        public LoginCorePage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void NavigateTo(string URL)
        {
            _idriver.NavigateTo(URL);
        }

        public void EnterCredentials(string username, string passWord)
        {
            UserName.SendKeys(username);
            Password.SendKeys(passWord);
        }

        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }

        public void ClickLogin()
        {
            SubmitBtn.ClickWithJs();
        }




    }
}
