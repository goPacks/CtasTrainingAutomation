using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;

namespace Automation.DemoUI.Pages
{
    public class PortalPaymentPage : TestBase, IPortalPaymentPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        IAtWebElement x1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .ng-star-inserted > #not\\ selected0 .p-checkbox-box"));

        IAtWebElement x2 => _idriver.FindElement(GetBy(LocatorType.Id, "amount"));

        IAtWebElement x3 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".btn:nth-child(1)"));

     


        public PortalPaymentPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void AutoBalTransferTaxArrear()
        {

            x1.Click();
            x2.Click();
            x3.Click();



        }


    }
}
