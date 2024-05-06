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
    public class RegPortalSteps
    {
        IRegPortalPage _iRegPage;


        public RegPortalSteps(IRegPortalPage iRegPage)
        {
            _iRegPage = iRegPage;
        }

        //[Then(@"I will check if am on RegPage titled ""([^""]*)""")]
        //public void ThenIWillCheckIfAmOnRegPageTitled(string pageTitle)
        //{
        //    _iRegPage.CheckPageTitle(pageTitle);


        //}

      
        [Then(@"I click on And I click on Foreign eCommerce VAT Collector")]
        public void ThenIClickOnAndIClickOnForeignECommerceVATCollector()
        {
            _iRegPage.CkickTpForeignEcommerceVatCollector();
        }

        [Then(@"on Representive Tab I click on the Next Button")]
        public void ThenOnRepresentiveTabIClickOnTheNextButton()
        {
            _iRegPage.RegTabNextBtnClick();
        }


        [Then(@"on Taxpayer Identity Tab I enter Company Name as ""([^""]*)""")]
        public void ThenOnTaxpayerIdentityTabIEnterCompanyNameAs(string companyName)
        {
             _iRegPage.EnterCompanyName(companyName);
        }

        [Then(@"Taxpayer Identity Tab I click on the Next Button")]
        public void ThenTaxpayerIdentityTabIClickOnTheNextButton()
        {
            _iRegPage.RegTabNextTpIdClick();
        }

        [Then(@"on Contact Detail Tab I enter email address as ""([^""]*)""")]
        public void ThenOnContactDetailTabIEnterEmailAddressAs(string email)
        {
            _iRegPage.ContactTabEnterEmail(email);
        }

        [Then(@"I will click Verify")]
        public void ThenIWillClickVerify()
        {
         //   _iRegPage.ClickContactTabEmailVerify();
        }

        [Then(@"I will enter OTP ""([^""]*)""")]
        public void ThenIWillEnterOTP(string strOTP)
        {
            // _iRegPage.EnterOTP(strOTP);

            
        }

        [Then(@"I will click OTP Verify")]
        public void ThenIWillClickOTPVerify()
        {
            _iRegPage.ClockContactTabVerifyOTP();
        }


    }


}
