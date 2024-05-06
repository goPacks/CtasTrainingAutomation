using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace Automation.DemoUI.Pages
{
   public class TaxCorePage : TestBase, ITaxCorePage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;


       
        IAtWebElement PaymentMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Payment"));

              
        IAtWebElement BalTransferRequestSubMenu => _idriver.FindElement(GetBy(LocatorType.LinkText, "Balance Transfer Request"));


        public TaxCorePage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
     : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
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

                default:
                    break;
            }
        }

    }
}
