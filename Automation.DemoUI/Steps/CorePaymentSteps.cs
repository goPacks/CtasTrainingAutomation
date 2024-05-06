using Automation.DemoUI.Pages;
using Automation.DemoUI.WebAbstraction;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps
{
    [Binding]
    public class CorePaymentSteps
    {
        ICorePaymentPage _iPage;

        public CorePaymentSteps(ICorePaymentPage iPage)
        {
            _iPage = iPage;
        }

        [Then(@"I will check if am on core payment page")]
        public void ThenIWillCheckIfAmOnCorePaymentPage()
        {
            _iPage.CheckPageTitle("Payment");


        }

        [Then(@"I click on Create New Balance Transfer Request menu")]
        public void ThenIClickOnCreateNewBalanceTransferRequestMenu()
        {
            _iPage.ClickOnSideMenu("Create New Balance Transfer Request");
        }

        [Then(@"I enter new request ""([^""]*)"" on  New Balance Transfer Request Details Form")]
        public void ThenIEnterNewRequestOnNewBalanceTransferRequestDetailsForm(string requtstNumber)
        {
            _iPage.EnterRequestNumber(requtstNumber);
        }

        [Then(@"I will enter Tax Object Number ""([^""]*)"" in core payment page")]
        public void ThenIWillEnterTaxObjectNumberInCorePaymentPage(string objectPermitNumber)
        {
            _iPage.SelfServiceBillingCodeCreation(objectPermitNumber);

        }

        [Then(@"I will perform Self Service Billing with ""([^""]*)"" on Core Payment page")]
        public void ThenIWillPerformSelfServiceBillingWithOnCorePaymentPage(string number)
        {
            _iPage.SelfServiceBillingCodeCreation(number);

        }



    }
}
