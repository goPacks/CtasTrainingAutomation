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
    public class NameSteps
    {
        INamePage _iPage;
        
        public NameSteps(INamePage iPage)
        {
            _iPage = iPage;
        }

       

        [Given(@"I navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string URL)
        {
            _iPage.NavigateTo(URL);
        }

        [Given(@"Given I navigate to TpPortal at ""([^""]*)""")]


        [Given(@"I am on page titled ""([^""]*)""")]
        public void GivenIAmOnPageTitled(string pageTitle)
        {
            _iPage.CheckPageTitle(pageTitle);
        }

        



        [Then(@"Set Step (.*)")]
        public void ThenSetStep(int p0)
        {
           
        }

        [Then(@"I will move to element")]
        public void ThenIWillMoveToElement()
        {
            _iPage.moveToElement();
        }







    }
}
