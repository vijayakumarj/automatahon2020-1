using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.IO;

namespace XpackHackathon.Utils.Reports
{
    public class ExtentReport
    {
        /*public ExtentReports extent { get; set; }
        [ThreadStatic]
        public static ExtentTest test;

        private string _reportFolderPath;
        private string _reportpath;
        private string _reportDateTime;
        string _screenShotPath;

        public string ReportPath { get { return _reportpath; } }
        public string ReportDateTime { get { return _reportDateTime; } }
        public string ReportFolderLocation { get; set; }
        public string ScreenShotFolderLocation { get; set; }

        private void CreateReportFolder()
        {
            _reportFolderPath = ReportFolderLocation;
            var todaysdate = DateTime.Now.ToString("dd-MMM-yyyy");
            if (!Directory.Exists(_reportFolderPath + "\\" + todaysdate))
            {
                Directory.CreateDirectory(_reportFolderPath + "\\" + todaysdate);
            }
            ReportFolderLocation = _reportFolderPath + "\\" + todaysdate;
            _reportFolderPath = _reportFolderPath + "\\" + todaysdate;
            _screenShotPath = _reportFolderPath + "\\" + todaysdate;
        }

        /// <summary>
        /// Starts the Report for the Entire Execution
        /// </summary>
        public void StartReport()
        {
            CreateReportFolder();
            _reportDateTime = string.Format("{0:ddMMMyyyy-HHmm}", DateTime.Now);
            _reportpath = _reportFolderPath + "\\ExeReport" + _reportDateTime + ".html";

           
            extent = new ExtentReports(_reportpath, true);

            extent.AddSystemInfo("Host Name", "YourHostName")
                .AddSystemInfo("Environment", "YourQAEnvironment")
                .AddSystemInfo("Username", "YourUserName");

            extent.LoadConfig(_reportpath + "Extent-Config.xml"); //Get the config.xml file from http://extentreports.com

        }

        /// <summary>
        /// Used to log success in the test
        /// </summary>
        /// <param name="successDetails"></param>
        public void LogSuccess()
        {
            extent.EndTest(test);
        }

        /// <summary>
        /// Ends logging for a test
        /// </summary>
        public void AfterClass()
        {
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = " " + TestContext.CurrentContext.Result.StackTrace + " ";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, status + errorMessage);
            }

            //End test report
            extent.EndTest(test);
        }

        /// <summary>
        /// Ends the Extent Report for the execution
        /// </summary>
        public void EndReport()
        {
            //End Report
            extent.Flush();
            extent.Close();
        }

        /// <summary>
        /// Starts the test's logging
        /// </summary>
        /// <param name="testName"></param>
        public void StartTest(string testName)
        {
            test = extent.StartTest(testName);
        }

        /// <summary>
        /// Logs an information about a test or a step
        /// </summary>
        /// <param name="infoToBeLogged"></param>
        public void LogInfo(string infoToBeLogged)
        {
            test.Log(LogStatus.Info, infoToBeLogged);
        }

        /// <summary>
        /// Reports an Error from the 
        /// </summary>
        /// <param name="exception"></param>
        public void LogException(Exception exception)
        {
            test.Log(LogStatus.Fail, exception);
        }

        /// <summary>
        /// Log status with status for a step
        /// </summary>
        /// <param name="logStatus"></param>
        /// <param name="details"></param>
        public void Log(LogStatus logStatus, string details)
        {
            test.Log(logStatus, details);
        }*/
    }
}
