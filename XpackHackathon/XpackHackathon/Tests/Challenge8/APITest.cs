using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using XpackHackathon.API.Models;
using XpackHackathon.API.Services;
using XpackHackathon.Utils.Helpers;

namespace XpackHackathon.Tests.Challenge8
{
    [TestFixture]
    public class APITest : ApiTestBase
    {
        [Test]
        [TestCaseSource("GetData")]
        [Category("Challenge8")]
        public async Task ApiTestChallege8PostAndDelete(Company company)
        {
            try
            {
                //morphing the static data
                company.Name = company.Name + RandomHelper.Generate();
                company.Email = company.Email+ RandomHelper.Generate();
                CompanyServices companyServices = new CompanyServices();
                List<Company> companies = new List<Company>();
                companies = await companyServices.PostCompany(company, System.Net.HttpStatusCode.OK);
                ReportAssert.IsTrue(companies.Exists(x => x.Name.Equals(company.Name)), "If the company Exists");
                var response = companyServices.DeleteAddress(company.Name, System.Net.HttpStatusCode.OK);
                await companyServices.GetCompany(company.Name, System.Net.HttpStatusCode.NotFound);
            }
            catch(Exception e)
            {
                ReportError(e);
            }
        }

        [Test]
        [TestCaseSource("GetData")]
        [Category("Challenge8")]
        public async Task ApiTestChallege8PostAndUpdate(Company company)
        {
            try
            {
                company.Name = company.Name + RandomHelper.Generate();
                company.Email = company.Email + RandomHelper.Generate();
                CompanyServices companyServices = new CompanyServices();
                List<Company> companies = new List<Company>();
                companies = await companyServices.PostCompany(company, System.Net.HttpStatusCode.OK);
                ReportAssert.IsTrue(companies.Exists(x => x.Name.Equals(company.Name)), "If the company Exists");

                company.Email = "test@1234.com";
                await companyServices.PutCompany(company, System.Net.HttpStatusCode.OK);
                List<Company> responseGetCompany = await companyServices.GetAllCompanies(System.Net.HttpStatusCode.OK);
                ReportAssert.IsTrue(responseGetCompany.Exists(x => x.Name.Equals(company.Name)), "If the company Exists");
            }
            catch (Exception e)
            {
                ReportError(e);
            }
        }


        private static IEnumerable<object[]> GetData()
        {
            var companyList = JsonHelper.GetObjectData<CompanyList>(Directory.GetCurrentDirectory() + "\\TestData\\Company.json");
            foreach (var company in companyList.Companies)
            {
                yield return new[] { company };
            }
        }
    }
}
