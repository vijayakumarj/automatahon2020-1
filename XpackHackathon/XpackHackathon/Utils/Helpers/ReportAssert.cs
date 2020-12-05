using NUnit.Framework;
using AventStack.ExtentReports;
using System;

namespace XpackHackathon.Utils.Helpers
{
    public class ReportAssert
    {
        public static void AreEqual(object expectedValue, object actualValue, string assertionDetails)
        {
            try
            {
                Assert.AreEqual(expectedValue, actualValue);
                Resources.Report.Log(Status.Pass , $"Checking '{assertionDetails}'");
            }
            catch (Exception e)
            {
                Resources.Report.Log(Status.Fail, $"Checking '{assertionDetails}'");
                Assert.Fail($"Checking : {assertionDetails}: Failed");
            }
        }
        public static void IsTrue(bool expression, string expressionDetails)
        {
            Resources.Report.Log(expression? Status.Pass: Status.Fail , $"Checking '{expressionDetails}'");
            if (!expression)
            {
                Assert.Fail($"Checking '{expressionDetails}': Failed");
            }
        }
        public static void IsFalse(bool expression, string expressionDetails)
        {
            Resources.Report.Log(expression ? Status.Fail : Status.Pass , $"Checking '{expressionDetails}'");
            if (expression)
            {
                Assert.Fail($"Checking '{expressionDetails}': Failed");
            }
        }

        public static void Pass(string message)
        {
            Resources.Report.Log(Status.Pass, message);
        }
        public static void Fail(string message)
        {
            Resources.Report.Log(Status.Fail, message);
        }
    }
}
