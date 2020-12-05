using System;
using System.IO;

namespace XpackHackathon.Utils.Reports
{
    public class HtmlReporter
    {
        /*public AventStack.ExtentReports.ExtentReports Extent;

        public ExtentTest ParentTest;
        private string _reportFolderPath;
        private string _reportpath;
        private string _reportDateTime;
        string _screenShotPath;
        public string ReportPath { get { return _reportpath; } }
        public string ReportDateTime { get { return _reportDateTime; } }

        public string ReportFolderLocation { get; set; }
        public string ScreenShotFolderLocation { get; set; }


        public string AppEnv { get; set; }
        public string AppUrl { get; set; }
        public string AppUserName { get; set; }
        public string Browser { get; set; }



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

        public void StartReport()
        {
            CreateReportFolder();
            _reportDateTime = string.Format("{0:ddMMMyyyy-HHmm}", DateTime.Now);
            _reportpath = _reportFolderPath + "\\ExeReport" + _reportDateTime + ".html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(_reportpath);
            htmlReporter.Config.ReportName = "AutomATAhon 2020";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            Extent = new AventStack.ExtentReports.ExtentReports();
            Extent.AttachReporter(htmlReporter);
            Extent.AddSystemInfo("Env", AppEnv);
            Extent.AddSystemInfo("URL", AppUrl);
            Extent.AddSystemInfo("User", AppUserName);
            if (Browser == "") return;
            Extent.AddSystemInfo("Browser", Browser);
        }

        public ExtentTest StartTest(string testName, string testDescription)
        {
            return Extent.CreateTest(testName, testDescription);
        }

        public void StartParentTest(string testName, string testDescription)
        {
            //ParentTest = Extent.CreateTest(testName, testDescription);
        }


        public void Log(ExtentTest Test, Status status, string logReport)
        {
            Test.Log(status, logReport);
        }

        public void LogInfo(ExtentTest Test, string logReport)
        {
            Test.Log(Status.Info, logReport);
        }

        public void LogRunnerOutput(string logReport)
        {
            Extent.AddTestRunnerLogs(logReport);
        }

        public void LogException(ExtentTest Test, Status status, Exception e)
        {
            Test.Log(status, e.Message + e);
        }

        public void EndReport()
        {
            Extent.Flush();
        }

        public void TakeSnapshot(ExtentTest Test, string imageFileLocation)
        {
            Test.Log(Status.Info, "Snapshot below: " + Test.AddScreenCaptureFromPath(imageFileLocation));
        }

        public Status GetLogStatus(bool result)
        {
            if (result == true)
            {
                return Status.Pass;
            }
            else
            {
                return Status.Fail;
            }
        }
*/
    }
}
