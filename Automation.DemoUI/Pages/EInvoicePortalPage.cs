using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.Pages
{
    public class EInvoicePortalPage: TestBase, IEInvoicePortalPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        IAtBy byOutputTaxMenu => GetBy(LocatorType.Id, "86");
        IAtWebElement OutputTaxMenu => _idriver.FindElement(byOutputTaxMenu);



        public EInvoicePortalPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
          : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void ClickOnOutputTaxMenu()
        {
            OutputTaxMenu.Click();
        }


    }
}
