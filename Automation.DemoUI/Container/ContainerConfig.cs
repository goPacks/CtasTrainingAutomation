using Automation.DemoUI.Configuration;
using Automation.DemoUI.Pages;
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.DIContainer;
using BoDi;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Container
{
    [Binding]
    public class ContainerConfig
    {

        [BeforeScenario(Order =1)]
        public void BeforeScenario(IObjectContainer iobjectContainer)
        {

            
            iobjectContainer.RegisterTypeAs<NamePage, INamePage>();
            iobjectContainer.RegisterTypeAs<LoginPage, ILoginPage>();
            iobjectContainer.RegisterTypeAs<LoginCorePage, ILoginCorePage>();
            iobjectContainer.RegisterTypeAs<Tp360Page, ITp360Page>();
            iobjectContainer.RegisterTypeAs<TaxCorePage, ITaxCorePage>();
            iobjectContainer.RegisterTypeAs<CorePaymentPage, ICorePaymentPage>();
            iobjectContainer.RegisterTypeAs<PortalPaymentPage, IPortalPaymentPage>();

            iobjectContainer.RegisterTypeAs<AtConfiguration, IAtConfiguration>();

            iobjectContainer.RegisterTypeAs<RegPortalPage, IRegPortalPage>();
            
            iobjectContainer.RegisterTypeAs<OutputTaxPage, IOutputTaxPage>();
            iobjectContainer.RegisterTypeAs<EInvoicePortalPage, IEInvoicePortalPage>();
           iobjectContainer.RegisterTypeAs<HoverPage, IHoverPage>();
            iobjectContainer = CoreContainerConfig.SetContainer(iobjectContainer);


        }
    }
}
