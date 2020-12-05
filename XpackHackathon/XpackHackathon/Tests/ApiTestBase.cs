using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NUnit.Framework.Interfaces;
using XpackHackathon.Utils;
using System.Net.Http;

namespace XpackHackathon.Tests
{
    [TestFixture]
    public class ApiTestBase
    {
        [ThreadStatic]
        public static HttpClient WebClient;
        public string Version { get; set; }
        public static string BaseUrl { get; set; }

        [TearDown]
        public void TestCleanUp()
        {
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
        public void ReportError(Exception e)
        {
            if (e != null)
            {
                Resources.Report.LogException(e);
                Assert.Fail();
            }
        }

        [SetUp]
        public void TestSetUp()
        {
            var currentTestContext = TestContext.CurrentContext;
            Resources.Report.StartTest($"{currentTestContext.Test.MethodName}");
            BaseUrl = currentTestContext.Test.Properties["ApiBaseUri"].ToString();
        }
        
        public static void LaunchReport()
        {
            var reportProcess = new Process();
            //reportProcess.StartInfo.FileName = Resources.Report.ReportPath;
            reportProcess.Start();
            var hWnd = reportProcess.MainWindowHandle;
            ShowWindow(hWnd, 3);
            SetForegroundWindow(hWnd);
        }
        [DllImport("user32.dll")]
        internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Resources.InitializeReport();
        }

        [OneTimeTearDown]
        public static void AssemblyCleanUp()
        {
            Resources.Report.EndReport();
        }


    }
}
