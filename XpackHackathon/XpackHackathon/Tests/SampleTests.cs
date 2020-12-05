using NUnit.Framework;
using System;
using System.Threading.Tasks;
using XpackHackathon.API.Models;
using XpackHackathon.API.Services;
using XpackHackathon.Utils;
using XpackHackathon.Utils.Helpers;

namespace XpackHackathon.Tests
{
    [TestFixture]
    public class SampleTests : ApiTestBase
    {
        [Test]
        [Category("API Test")]
        public void Test()
        {
            try
            {
                Resources.Report.LogInfo("Started the test");

                Resources.Report.LogInfo("Ends the test");
            }
            catch (Exception e)
            {
                ReportError(e);
            }
            
        }

        [Test]
        public async Task Test2()
        {
            try
            {
                Address address = new Address();
                SampleServices sampleServices = new SampleServices();
                address = await sampleServices.GetAddress("654654", "656", System.Net.HttpStatusCode.OK);

                ReportAssert
            }
            catch
            {

            }
        }
    }
}
