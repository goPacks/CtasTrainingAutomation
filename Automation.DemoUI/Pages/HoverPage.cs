
using Automation.DemoUI.Configuration;
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using Automation.Framework.Core.WebUI.DriverContext;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Automation.DemoUI.Pages
{
   public class HoverPage : TestBase, IHoverPage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

    //    IAtBy byResources => GetBy(LocatorType.Xpath, "//p[text()='Resources']");
        IAtWebElement Resources => _idriver.FindElement(GetBy(LocatorType.Xpath, "//p[text()='Resources']"));


        public HoverPage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
       : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void MoveToElement()
        {
            WebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://testsigma.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            var element = driver.FindElement(By.XPath("//p[text()='Resources']"));

            Actions action = new Actions(driver);

            action.MoveToElement(element).Build().Perform();
        }

        public void MoveToElement2(string URL)
        {
            _idriver.NavigateTo(URL);



            //IWebElement webEx = Resources.GetElement();


            Resources.MoveToElement();

           // Resources.MouseHover();

            //Actions action = new Actions(_idriver.GetWebDriver());

            //action.MoveToElement((webEx).Build().Perform();

            //    action.MoveToElement((WebElement)Resources).Build().Perform();
        }
    }
}
