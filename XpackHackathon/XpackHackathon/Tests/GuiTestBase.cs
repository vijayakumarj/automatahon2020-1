using NUnit.Framework;
using OpenQA.Selenium;
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
        public void OneTimeSetup()
        {
            Resources.InitializeReport();
        }

        [SetUp]
        public void SetUp()
        {
            Resources.Report.StartTest($"{TestContext.Test.MethodName}");
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
