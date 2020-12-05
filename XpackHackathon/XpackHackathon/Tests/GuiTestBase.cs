using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
            WebDriver = new ChromeDriver();
            WebDriver.Navigate()
                .GoToUrl("https://automatahon20.cpsatexam.org/challenge3/");
            WebDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
            var currentTestContext = TestContext.CurrentContext;
            var result = currentTestContext.Result.Outcome.Status;
            switch (result)
            {
                case TestStatus.Failed:
                    Assert.IsTrue(false, "failed");
                    break;
                case TestStatus.Inconclusive:
                    Assert.IsTrue(false, "inconclusive");
                    break;
                case TestStatus.Skipped:
                    Assert.IsTrue(false, "Skipped");
                    break;
                default:
                    Assert.IsTrue(true, "passed");
                    break;
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Resources.Report.EndReport();
        }
    }
}
