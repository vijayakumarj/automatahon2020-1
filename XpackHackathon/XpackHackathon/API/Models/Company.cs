using System;
using System.Collections.Generic;
using System.Text;

namespace XpackHackathon.API.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
    }

    public class CompanyList
    {
        public List<Company> Companies { get; set; }
    }
}
