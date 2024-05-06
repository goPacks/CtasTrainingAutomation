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
    public class OutputTaxSteps


    {
        IOutputTaxPage _iPage;

        public OutputTaxSteps(IOutputTaxPage iPage)
        {
            _iPage = iPage;
        }

        [Then(@"I will click on Create Output Invoice button")]
        public void ThenIWillClickOnCreateOutputInvoiceButton()
        {
            _iPage.CreateOutputInvoice();
        }



     

    }
}
