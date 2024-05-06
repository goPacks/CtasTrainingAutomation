
using Automation.DemoUI.WebAbstraction;
using Automation.Framework.Core.WebUI.Abstraction;
using Automation.Framework.Core.WebUI.Base;
using Automation.Framework.Core.WebUI.DriverContext;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Pages
{
    public class NamePage : TestBase, INamePage
    {
        IAtConfiguration _iatConfiguration;
        IDriver _idriver;

        //input[@type='submit']
        IAtBy bySubmitBtn => GetBy(LocatorType.Xpath, "//input[@type='submit']");
        IAtWebElement SubmitBtn => _idriver.FindElement(bySubmitBtn);


        public NamePage(IObjectContainer iobjectContainer, IAtConfiguration iatConfiguration, IDriver idriver)
          : base(iobjectContainer)
        {
            _iatConfiguration = iatConfiguration;
            _idriver = idriver;
        }

        public void NavigateTo(string URL)
        {
            _idriver.NavigateTo(URL);
        }

        public void CheckPageTitle(string pageTitle)             
        {
           
            Assert.That(pageTitle, Is.EqualTo(_idriver.GetPageTitle()));
        }


        public void moveToElement()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucelabs.com");
            Actions action = new Actions(driver);
            action.MoveByOffset(200, 100).Perform();
            Thread.Sleep(2000);
            action.Click();
            //Actions builder = _idriver.GetBuilderActions();

            //Thread.Sleep(5000);

            //builder.MoveByOffset(13,15).Perform();

            //new Actions(_driver)
            //    .MoveByOffset(13, 15)
            //    .Perform();

            //ActionBuilder actionBuilder = new ActionBuilder();
            //PointerInputDevice mouse = new PointerInputDevice(PointerKind.Mouse, "default mouse");
            //actionBuilder.AddAction(mouse.CreatePointerDown(MouseButton.Back));
            //actionBuilder.AddAction(mouse.CreatePointerUp(MouseButton.Back));
            //((IActionExecutor)_idriver).PerformActions(actionBuilder.ToActionSequenceList());

            //builder.Click(SubmitBtn.GetElement()).Perform();

            // builder.MoveToElement(SubmitBtn.GetElement()).Perform();

            //new Actions(driver)
            //    .click(clickable)
            //    .perform();

            // SubmitBtn.Click();
        }
    }
}
