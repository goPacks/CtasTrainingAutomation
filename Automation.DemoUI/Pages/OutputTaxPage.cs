
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using Automation.Framework.Core.WebUI.DriverContext;
using Automation.Framework.Core.WebUI.WebElements;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
namespace Automation.DemoUI.Pages
{
    public class OutputTaxPage : TestBase, IOutputTaxPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

      //  IAtBy byCreateOutputInvoiceButton => GetBy(LocatorType.CssSelector, "#CreateOutputInvoiceButton > .p-button-label");
        IAtWebElement CreateOutputInvoiceButton => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#CreateOutputInvoiceButton > .p-button-label"));

        IAtWebElement dropDown => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-dropdown-clearable > .p-dropdown-label"));

        IAtWebElement dropDownPickOutputTax => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple > .ng-star-inserted"));

       

        public OutputTaxPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
          : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void CreateOutputInvoice()
        {
            CreateOutputInvoiceButton.MoveToElement();

            dropDown.Click();
            dropDownPickOutputTax.Click();
           


        }
    }
}
