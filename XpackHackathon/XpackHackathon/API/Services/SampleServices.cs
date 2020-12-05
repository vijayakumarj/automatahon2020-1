using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using XpackHackathon.API.Models;
using XpackHackathon.Utils.Helpers;

namespace XpackHackathon.API.Services
{
    public class SampleServices : BaseServices
    {
        #region POST
        public async Task<Address> GetAddress(string userId, string addressId, HttpStatusCode expectedStatusCode)
        {
            var response = await Get($"{BaseUri}/Client/{userId}/Address/{addressId}", "Client Address");
            var responseAsString = await response.Content.ReadAsStringAsync();
            ReportAssert.AreEqual(response.StatusCode, expectedStatusCode, "Expected and Actual Status Codes");
            return JsonConvert.DeserializeObject<Address>(responseAsString);
        }
        #endregion

        #region PUT

        #endregion

        #region GET

        #endregion

        #region DELETE

        #endregion

    }
}
