using System.IO;
using XpackHackathon.Utils.Reports;

namespace XpackHackathon.Utils
{
    public static class Resources
    {
        public static ExtentHtmlReport Report { get; set; }
        
        public static void InitializeReport()
        {
            string reportFolderLocation = Directory.GetCurrentDirectory() + "\\Reports";
            Report = new ExtentHtmlReport("QAT", "dummy url", "Chrome", reportFolderLocation);
            Report.StartReport();
        }
    }
}
