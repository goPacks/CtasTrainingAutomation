using Automation.DemoUI.Pages;
using Automation.DemoUI.WebAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps
{
    [Binding]
    public class PortalPaymentSteps
    {
        IPortalPaymentPage _iPaymentPortalPage;

        public PortalPaymentSteps(IPortalPaymentPage iPaymentPortalPage)
        {
            _iPaymentPortalPage = iPaymentPortalPage;
        }

        [Then(@"I will AutoTransfer")]
        public void ThenIWillAutoTransfer()
        {
            _iPaymentPortalPage.AutoBalTransferTaxArrear();
        }

        [Then(@"I will AutoTransfer on Portal Payment Page")]
        public void ThenIWillAutoTransferOnPortalPaymentPage()
        {
            _iPaymentPortalPage.AutoBalTransferTaxArrear();
        }


        //[Then(@"I will Bal Transfer from Tax Arrear")]
        //public void ThenIWillBalTransferFromTaxArrear()
        //{
        //    _iPaymentPortalPage.AutoBalTransferTaxArrears();
        //}



    }
}
