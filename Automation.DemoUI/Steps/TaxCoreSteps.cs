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
   public class TaxCoreSteps
    {
        ITaxCorePage _iTaxCorePage;

        public TaxCoreSteps(ITaxCorePage iTaxCorePage)
        {
            _iTaxCorePage = iTaxCorePage;
        }


        [Then(@"I will check if am on core page titled ""([^""]*)""")]
        public void ThenIWillCheckIfAmOnCorePageTitled(string title)
        {
            _iTaxCorePage.CheckPageTitle(title);
        }

        [When(@"I click on Menu label ""([^""]*)""")]
        public void WhenIClickOnMenuLabel(string menu)
        {
            _iTaxCorePage.ClickMenu(menu);
        }

        

    }
}
