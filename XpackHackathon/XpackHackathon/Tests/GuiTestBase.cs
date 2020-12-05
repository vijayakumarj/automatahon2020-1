using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using XpackHackathon.Utils;

namespace XpackHackathon.Tests
{
    [TestFixture]
    public class GuiTestBase
    {
        [ThreadStatic]
        public static IWebDriver WebDriver;
        public TestContext TestContext { get; set; }

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            Resources.InitializeReport();
        }

        [SetUp]
        public void SetUp()
        {
            var currentTestContext = TestContext.CurrentContext;
            Resources.Report.StartTest($"{currentTestContext.Test.MethodName}");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate()
                .GoToUrl(currentTestContext.Test.Properties["GuiUrlChallenge2"].ToString());
            driver.Manage().Window.Maximize();
            driver.Quit();
        }

        [TearDown]
        public void TearDown()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
