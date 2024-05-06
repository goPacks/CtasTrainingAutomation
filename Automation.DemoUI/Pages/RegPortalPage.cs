using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.DemoUI.Pages
{
    public class RegPortalPage : TestBase, IRegPortalPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        IAtBy byTpForeignEcommerceVatCollector => GetBy(LocatorType.Id, "taxpayerType-Foreign eCommerce VAT Collector");
        IAtWebElement TpForeignEcommerceVatCollector => _idriver.FindElement(byTpForeignEcommerceVatCollector);

        IAtBy byRegTabNextBtn => GetBy(LocatorType.CssSelector, "#regButton-nextRepresentative > .p-button-label");
        IAtWebElement RegTabNextBtn => _idriver.FindElement(byRegTabNextBtn);

        IAtBy byRegTpCompany => GetBy(LocatorType.Id, "regInput-taxpayerName");
        IAtWebElement RegTpCompany => _idriver.FindElement(byRegTpCompany);


        IAtBy byRegTabNextTpId => GetBy(LocatorType.CssSelector, "#regButton-nextTaxpayerIdentity > .p-button-label");
        IAtWebElement RegTabNextTpId => _idriver.FindElement(byRegTabNextTpId);

        IAtBy byContactTabEmail => GetBy(LocatorType.Id, "regInput-email");
        IAtWebElement ContactTabEmail => _idriver.FindElement(byContactTabEmail);


        IAtBy byContactTabEmailVerify => GetBy(LocatorType.CssSelector, "#regButton-verifyEmail > .p-button-label");
        IAtWebElement ContactTabEmailVerify => _idriver.FindElement(byContactTabEmailVerify);


        IAtBy byContactTabOTP => GetBy(LocatorType.Id, "regInput-emailsOTP");
        IAtWebElement ContactTabOTP  => _idriver.FindElement(byContactTabOTP);

        IAtBy byContactTabVerifyOTP => GetBy(LocatorType.CssSelector, "#regButton-verifyEmailsOTP > .p-button-label");
        IAtWebElement ContactTabVerifyOTP => _idriver.FindElement(byContactTabVerifyOTP);




        // driver.FindElement(By.CssSelector("#regButton-verifyEmailsOTP > .p-button-label")).Click();

        //driver.FindElement(By.Id("regInput-emailsOTP")).SendKeys("1234");
        // IAtBy byContactTabTel => GetBy(LocatorType.Id, "tel");
        //IAtWebElement ContactTabEmail => _idriver.FindElement(byContactTabEmail);

        ////driver.FindElement(By.Id("tel")).SendKeys("+62081110002433");

        //driver.FindElement(By.CssSelector("#regButton-verifyEmail > .p-button-label")).Click();
        //driver.FindElement(By.Id("regInput-emailsOTP")).Click();
        //driver.FindElement(By.Id("regInput-emailsOTP")).SendKeys("1234");



        public RegPortalPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
          : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }

        public void CkickTpForeignEcommerceVatCollector()
        {
            TpForeignEcommerceVatCollector.Click();
        }

        public void RegTabNextBtnClick()
        {
            RegTabNextBtn.Click();
        }

        public void EnterCompanyName(string companyName)
        {
            RegTpCompany.SendKeys(companyName);
        }

        public void RegTabNextTpIdClick()
        {
            RegTabNextTpId.Click();
        }

        public void ContactTabEnterEmail(string email)
        {
            ContactTabEmail.SendKeys(email);
        }

        public void ClickContactTabEmailVerify()
        {
            ContactTabEmailVerify.Click();
        }

        public void EnterOTP(string strOTP)
        {
            ContactTabOTP.SendKeys(strOTP);
        }

        public void ClockContactTabVerifyOTP()
        {
            ContactTabVerifyOTP.Click();
        }

    }
}
