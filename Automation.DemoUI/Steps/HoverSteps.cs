using Automation.DemoUI.WebAbstraction;
using Gherkin.CucumberMessages.Types;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Buffers.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using TechTalk.SpecFlow;

namespace Automation.DemoUI.Steps
{
    [Binding]

    public class HoverSteps
    {
        IHoverPage _iHoverPage;

        public HoverSteps(IHoverPage iHoverPage)
        {
            _iHoverPage = iHoverPage;
        }


        [Given(@"I test move action")]
        public void GivenITestMoveAction()
        {

            // WebDriver driver = new ChromeDriver();

            // driver.Navigate().GoToUrl("https://testsigma.com/");
            // driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            // var element = driver.FindElement(By.XPath("//p[text()='Resources']"));

            // Actions action = new Actions(driver);

            //action.MoveToElement(element).Build().Perform();

            //_iHoverPage.MoveToElement();

            _iHoverPage.MoveToElement2("https://testsigma.com/");


        }
    }
}


