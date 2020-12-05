using System.IO;
using XpackHackathon.Utils.Reports;

namespace XpackHackathon.Utils
{
    public static class Resources
    {
        public static ExtentHtmlReport Report { get; set; }
        public static string JSonDataFileLocation { get; set; }
        public static string ApplicationFileLocation { get; set; }

        public static void InitializeReport()
        {
            ApplicationFileLocation = Directory.GetCurrentDirectory();
            JSonDataFileLocation = ApplicationFileLocation + "\\TestData";
            string reportFolderLocation = Directory.GetCurrentDirectory() + "\\Reports";
            Report = new ExtentHtmlReport("QAT", "dummy url", "Chrome", reportFolderLocation);
            Report.StartReport();
        }
    }
}
