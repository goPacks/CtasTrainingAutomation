using Automation.DemoUI.WebAbstraction;
using Automation.DemoUI.WebAbstraction.Core;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace Automation.DemoUI.Pages.Core
{
    public class CoreHomePage : TestBase, ICoreHomePage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;



        IAtWebElement PaymentMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Payment"));


        IAtWebElement BalTransferRequestSubMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Balance Transfer Request"));


        IAtWebElement SelfServiceBillingCodeCreation => _idriver.FindElement(GetBy(LocatorType.LinkText, "Self-Service Billing Code Creation"));


        public CoreHomePage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
     : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }



        public void ClickMenu(string menu)
        {
            switch (menu)
            {
                case "Payment":
                    PaymentMenu.Click();
                    break;



                default:
                    break;
            }

        }

        public void ClickSubMenu(string subMenu)
        {
            switch (subMenu)
            {
                case "Balance Transfer Request":
                    BalTransferRequestSubMenu.Click();
                    break;

                case "Self-Service Billing Code Creation":
                    SelfServiceBillingCodeCreation.Click();
                    break;

                default:
                    break;
            }
        }

    }
}
