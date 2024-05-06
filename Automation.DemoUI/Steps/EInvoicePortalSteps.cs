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
    public class EInvoicePortalSteps
    {

        
            IEInvoicePortalPage _iPage;

        public EInvoicePortalSteps(IEInvoicePortalPage iPage)
        {
            _iPage = iPage;
        }

        

        [Then(@"I will click on Output Tax menu")]
        public void ThenIWillClickOnOutputTaxMenu()
        {
            _iPage.ClickOnOutputTaxMenu();
        }


    }
}
