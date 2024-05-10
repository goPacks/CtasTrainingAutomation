using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using Automation.Framework.Core.WebUI.DriverContext;
using BoDi;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using Automation.DemoUI.WebAbstraction.Core;

namespace Automation.DemoUI.Pages.Core
{
    public class CorePaymentPage : TestBase, ICorePaymentPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        ILogging _ilogging;

        IAtWebElement CreateNewBalanceTransferRequestMenu => _idriver.FindElement(GetBy(LocatorType.Id, "842"));

        IAtWebElement RequestNumber => _idriver.FindElement(GetBy(LocatorType.Id, "request-number"));

        IAtWebElement elementDate => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".rounded-0"));


        IAtWebElement element1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-ink-active"));

        IAtWebElement RequestDate => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".rounded-0"));

        IAtWebElement RequestDatePick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-datepicker-buttonbar > .p-element:nth-child(1)"));

        IAtWebElement Channel => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#channel .p-dropdown-label"));

        IAtWebElement ChannelPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(2) > .p-ripple"));

        IAtWebElement TaxPayer => _idriver.FindElement(GetBy(LocatorType.Id, "Taxpayer"));

        IAtWebElement ObjectPermitNumber => _idriver.FindElement(GetBy(LocatorType.Id, "ObjectPermitNumber"));

        //    IAtWebElement ObjectPermitNumberSelect => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".col-sm-12 > .p-inputgroup > .p-button-warn"));


        IAtWebElement ObjectPermitNumberSelect => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[text()='Select']"));

        IAtWebElement SearchPaymentRecords => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".col-sm-12 > .p-inputgroup > .p-button-warn"));
        IAtWebElement PickPaymentRecord => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(1) #SetActive"));

        IAtWebElement PlaceHolder => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-placeholder"));

        //driver.FindElement(By.CssSelector(".p-element:nth-child(1) > .p-ripple")).Click();
        //driver.FindElement(By.CssSelector(".ng-star-inserted:nth-child(3) > .p-element .p-dropdown-label")).Click();

        IAtWebElement DestinationCombo => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple"));
       IAtWebElement DestinationComboPickOld => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[@id='pr_id_78_label']"));

       
        IAtWebElement DestinationComboPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(3) > .p-element .p-dropdown-label"));


        IAtWebElement x1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple"));



        //  IAtWebElement DestinationComboPick => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[text()='Taxpayer Account']"));

        //span[text()='Taxpayer Account']

        //  IAtWebElement RefCombo => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(7) .p-dropdown-label"));

        IAtWebElement TaxLiabilityCombo => _idriver.FindElement(GetBy(LocatorType.Xpath, "//span[contains(text(),'Self Service')]"));



        // AmountToBeTransferred
        IAtWebElement AmountToBeTransferred => _idriver.FindElement(GetBy(LocatorType.Id, "AmountToBeTransferred"));

        IAtWebElement TaxPaymentCodeCombo => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(3) > .p-dropdown-item"));

        IAtWebElement TaxPaymentCodeComboPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(1) > .p-element"));

        
        IAtWebElement Amount => _idriver.FindElement(GetBy(LocatorType.Id, "Amount0"));


        IAtWebElement ValidateRequestButton => _idriver.FindElement(GetBy(LocatorType.Xpath, "//button[text()='Validate Request']"));




        IAtWebElement taxLiability => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(6) .p-dropdown-trigger-icon"));

        IAtWebElement taxLiabilityPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(3) > .p-ripple"));

        IAtWebElement taxPaymentCode => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(8) .p-dropdown-trigger"));

        IAtWebElement taxPaymentCodePick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(2) > .p-ripple .mb-0"));


        IAtWebElement taxPeriod => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".ng-star-inserted:nth-child(9) .p-dropdown-trigger-icon"));

        IAtWebElement taxPeriodPick => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(1) > .p-ripple"));

        IAtWebElement total => _idriver.FindElement(GetBy(LocatorType.Xpath, "//td[text()='Total']"));



        IAtWebElement submitBtn => _idriver.FindElement(GetBy(LocatorType.Xpath, "//button[text()='Submit Request']"));

       

        IAtWebElement validateBtn => _idriver.FindElement(GetBy(LocatorType.Xpath, "//button[text()='Validate Request']"));


        //-----------------------------------------------------------------------------------------------------------------------
        IAtWebElement ObjectPermitNumberBtn => _idriver.FindElement(GetBy(LocatorType.Id, "ObjectPermitNumber"));

        IAtWebElement selectCode => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-button-sm"));

        IAtWebElement a1 => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#TaxTypeTaxPayment .p-dropdown-label"));

        IAtWebElement revenueCodeFilter => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-dropdown-filter"));

        IAtWebElement a3 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(4) > .p-ripple"));

        IAtWebElement a4 => _idriver.FindElement(GetBy(LocatorType.CssSelector, "#TaxPeriod .p-dropdown-label"));

        IAtWebElement taxPeriodFiler => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-dropdown-filter"));

        IAtWebElement taxPeriodPick2 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(12) .ng-star-inserted"));

        IAtWebElement AmountInput => _idriver.FindElement(GetBy(LocatorType.Id, "AmountInput"));

       IAtWebElement a5 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".form-group:nth-child(13) > .col-sm-9"));

       IAtWebElement a6 => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".btn-primary"));


       // IAtWebElement sortAsc => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".p-element:nth-child(8) .p-sortable-column-icon"));

       //IAtWebElement sortDesc => _idriver.FindElement(GetBy(LocatorType.CssSelector, ".pi-sort-amount-up-alt"));

        //// 10 | click | css=.p-element:nth-child(8) .p-sortable-column-icon | 
        //driver.FindElement(By.CssSelector(".p-element:nth-child(8) .p-sortable-column-icon")).Click();
        //// 11 | click | css=.pi-sort-amount-up-alt | 
        //driver.FindElement(By.CssSelector(".pi-sort-amount-up-alt")).Click();

        //thead/tr[1]/th[8]/p-sorticon[1]/i[1]

        IAtWebElement sort => _idriver.FindElement(GetBy(LocatorType.Xpath, "//thead/tr[1]/th[8]/p-sorticon[1]/i[1]"));

        IAtWebElement transferValue  => _idriver.FindElement(GetBy(LocatorType.Xpath, "//tbody/tr[1]/td[5]"));


        //tbody/tr[1]/td[5]

        //thead/tr[1]/th[8]/p-sorticon[1]/i[1]

        public CorePaymentPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
         : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void CheckPageTitle(string pageTitle)
        {
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }

        public void ClickOnSideMenu(string sideMenu)
        {
            switch (sideMenu)
            {
                case "Create New Balance Transfer Request":
                    CreateNewBalanceTransferRequestMenu.Click();
                    break;

                default:
                    break;
            }
        }

        public void EnterRequestNumber(string requestNumber)
        {
            RequestNumber.SendKeys(requestNumber);

            RequestDate.Click();
            RequestDatePick.Click();

            Channel.Click();
            ChannelPick.Click();


            TaxPayer.Click();


            ObjectPermitNumber.SendKeys("1091031210910452");

            Thread.Sleep(3000);

            ObjectPermitNumberSelect.Click();

            Thread.Sleep(2000);

            SearchPaymentRecords.Click();

            Thread.Sleep(3000);

            PickPaymentRecord.Click();



            PlaceHolder.Click();

           // DestinationCombo.Click();


           // _idriver.ScrollIntoView(DestinationCombo);


          //DestinationCombo.MoveToElement();





          DestinationCombo.Click();

         DestinationComboPick.Click();

            x1.Click();

            Thread.Sleep(2000);

            taxLiability.Click();

            Thread.Sleep(2000);

            taxLiabilityPick.Click();


            //laceHolder.Click();

          

            taxPaymentCode.Click();
            taxPaymentCodePick.Click();

            Thread.Sleep(2000);

            taxPeriod.Click();
            taxPeriodPick.Click();

            Thread.Sleep(2000);

            var amt = AmountToBeTransferred.GetAttribute("value");
            Amount.SendKeys(amt);

            Thread.Sleep(2000);

            total.Click();

            Thread.Sleep(2000);

            validateBtn.ClickWithJs();

            Thread.Sleep(2000);

            submitBtn.ClickWithJs();

            _idriver.GetNewTab();

            _idriver.NavigateTo("https://ctas-mtra.intranet.pajak.go.id/home/en-US/");



            //-----------------------------------------------------------------------------------------
           // a5.Click();

          //  a6.Click();

            //sortAsc.Click();

            //sortDesc.Click();




        }



        public void BalanceTransferRequestSuccess()
        {
            Thread.Sleep(5000);

            sort.Click();

            Thread.Sleep(5000);

            sort.Click();


            string amt = "0";
                
            amt =    transferValue.GetAttribute("value");  

            Console.WriteLine(amt);

         

            Assert.That(amt, Is.EqualTo("999"));

            //sortAsc.Click();

            //sortDesc.Click();
        }

        public void EnterRequestNumberolder(string requestNumber)
        {
            RequestNumber.SendKeys(requestNumber);

            RequestDate.Click();
            RequestDatePick.Click();

            Channel.Click();
            ChannelPick.Click();


            TaxPayer.Click();


            ObjectPermitNumber.SendKeys("1091031210910452");

            ObjectPermitNumberSelect.Click();

            Thread.Sleep(5000);

            SearchPaymentRecords.Click();

            PickPaymentRecord.Click();

            PlaceHolder.Click();

            DestinationCombo.Click();

            Thread.Sleep(2000);

            //   DestinationComboPick.Click();

            return;

            Thread.Sleep(2000);

            taxLiability.Click();

            taxLiabilityPick.Click();

            taxPaymentCode.Click();

            taxPaymentCodePick.Click();

            Thread.Sleep(2000);

            taxPeriod.Click();

            taxPeriodPick.Click();

            Thread.Sleep(2000);

            var amt = AmountToBeTransferred.GetAttribute("value");
            Amount.SendKeys(amt);

            Thread.Sleep(2000);

            total.Click();

            Thread.Sleep(2000);

            validateBtn.ClickWithJs();

            Thread.Sleep(2000);

            submitBtn.ClickWithJs();

            _idriver.GetNewTab();

            _idriver.NavigateTo("https://ctas-mtra.intranet.pajak.go.id/home/en-US/");

        }

        

        public void SelfServiceBillingCodeCreation(string objectPermitNumber)
        {
            ObjectPermitNumberBtn.SendKeys(objectPermitNumber);
            Thread.Sleep(5000);
            selectCode.Click();

            Thread.Sleep(3000);

            a1.Click();

            Thread.Sleep(1000);

            revenueCodeFilter.SendKeys("month");

            Thread.Sleep(1000);

            a3.Click();

            Thread.Sleep(1000);

            a4.Click();

            Thread.Sleep(1000);

            taxPeriodFiler.SendKeys("2020");

            taxPeriodPick2.Click();

            AmountInput.SendKeys("1100000");

            Thread.Sleep(1000);

           a5.Click();

            Thread.Sleep(1000);

           a6.Click();

            _idriver.GetNewTab();

            _idriver.NavigateTo("https://ctas-mtra.intranet.pajak.go.id/home/en-US/");


        }


        //public void act()
        //{


        // Actions builder =   _idriver.GetBuilderActions();
        //    builder.MoveToElement(elementNew.GetElement()).ClickAndHold().Perform();
        //}



    }





}
