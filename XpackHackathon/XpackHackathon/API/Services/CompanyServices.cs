using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using XpackHackathon.API.Models;
using XpackHackathon.Utils.Helpers;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;

namespace XpackHackathon.API.Services
{
    public class CompanyServices : BaseServices
    {
        #region POST

        /// <summary>
        /// Posts a new company to the system
        /// </summary>
        /// <param name="company"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public async Task<List<Company>> PostCompany(Company company, HttpStatusCode expectedStatusCode)
        {

            Dictionary<string, object> newCompany = new Dictionary<string, object>();

            newCompany.Add("name", company.Name.TrimEnd());
            newCompany.Add("tel", company.Tel.TrimEnd());
            newCompany.Add("email", company.Email.TrimEnd());

            var companyString = JsonConvert.SerializeObject(newCompany, Formatting.Indented);
            var formValues = new StringContent(companyString);
            var response = await Post($"{BaseUri}/companies/", formValues, "Company");
            var responseAsString = await response.Content.ReadAsStringAsync();
            ReportAssert.AreEqual(response.StatusCode, expectedStatusCode, "Expected and Actual Status Codes");
            return JsonConvert.DeserializeObject<List<Company>>(responseAsString);
        }
        #endregion

   

        #region GET

        /// <summary>
        /// To Get all companies as a list
        /// </summary>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public async Task<List<Company>> GetAllCompanies(HttpStatusCode expectedStatusCode)
        {
            var response = await Get($"{BaseUri}/companies/", "Company");
            var responseAsString = await response.Content.ReadAsStringAsync();
            ReportAssert.AreEqual(response.StatusCode, expectedStatusCode, "Expected and Actual Status Codes");
            return JsonConvert.DeserializeObject<List<Company>>(responseAsString);
        }

        /// <summary>
        /// Get a single company by it's name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public async Task<Company> GetCompany(string name, HttpStatusCode expectedStatusCode)
        {
            var response = await Get($"{BaseUri}/companies/{name}", "Company");
            var responseAsString = await response.Content.ReadAsStringAsync();
            ReportAssert.AreEqual(response.StatusCode, expectedStatusCode, "Expected and Actual Status Codes");
            return JsonConvert.DeserializeObject<Company>(responseAsString);
        }

        #endregion

        #region DELETE
        /// <summary>
        /// Deletes a company from the system
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public async Task<string> DeleteAddress(string name, HttpStatusCode expectedStatusCode)
        {
            var response = await Delete($"{BaseUri}/companies/{name}", "company");
            var responseAsString = await response.Content.ReadAsStringAsync();
            ReportAssert.AreEqual(response.StatusCode, expectedStatusCode, "Expected and Actual Status Codes");
            return JsonConvert.DeserializeObject<string>(responseAsString);
        }
        #endregion

        #region PUT

        /// <summary>
        /// Updates the company details in the system
        /// </summary>
        /// <param name="company"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public async Task<string> PutCompany(Company company, HttpStatusCode expectedStatusCode)
        {
            Dictionary<string, object> newCompany = new Dictionary<string, object>();

            newCompany.Add("name", company.Name.TrimEnd());
            newCompany.Add("tel", company.Tel.TrimEnd());
            newCompany.Add("email", company.Email.TrimEnd());

            var companyString = JsonConvert.SerializeObject(newCompany, Formatting.Indented);
            var formValues = new StringContent(companyString, Encoding.ASCII, "application/json");
            var response = await Put($"{BaseUri}/companies/{company.Name}", formValues, "Company");
            var responseAsString = await response.Content.ReadAsStringAsync();
            ReportAssert.AreEqual(response.StatusCode, expectedStatusCode, "Expected and Actual Status Codes");
            return JsonConvert.DeserializeObject<string>(responseAsString);
        }
        #endregion
    }
}
