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
    public class LoginCoreSteps
    {

        ILoginCorePage _iLoginCorePage;

        public LoginCoreSteps(ILoginCorePage iLoginCorePage)
        {
            _iLoginCorePage = iLoginCorePage;
        }


        [Given(@"I navigate to CtasCore at @""([^""]*)""")]
        public void GivenINavigateToCtasCoreAt(string URL)
        {
            _iLoginCorePage.NavigateTo(URL);
        }

        [When(@"I will check if am on Core page titled ""([^""]*)""")]
        public void WhenIWillCheckIfAmOnCorePageTitled(string title)
        {
            _iLoginCorePage.CheckPageTitle(title);
        }

        [Then(@"I enter ""([^""]*)"" as userId and ""([^""]*)"" as Password")]
        public void ThenIEnterAsUserIdAndAsPassword(string username, string password)
        {
            _iLoginCorePage.EnterCredentials(username, password);
        }

        [Then(@"I press Login Button")]
        public void ThenIPressLoginButton()
        {
            _iLoginCorePage.ClickLogin();
        }



    }
}
