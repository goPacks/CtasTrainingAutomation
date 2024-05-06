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
    public class Tp360Steps
    {
        ITp360Page _iTp360Page;

        public Tp360Steps(ITp360Page iTp360Page)
        {
            _iTp360Page = iTp360Page;
        }

        [Then(@"I will check if am on page titled ""([^""]*)""")]
        public void ThenIWillCheckIfAmOnPageTitled(string pageTitle)
        {
            _iTp360Page.CheckPageTitle(pageTitle);

        }

        [Then(@"I will click on ""([^""]*)"" menu")]
        public void ThenIWillClickOnMenu(string menuItem)
        {
            _iTp360Page.ClickMenu(menuItem);
        }


       

        [When(@"I click on SubMenu label ""([^""]*)""")]
        public void WhenIClickOnSubMenuLabel(string subMenuItem)
        {
            _iTp360Page.ClickSubMenu(subMenuItem);
        }



    }
}
