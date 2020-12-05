using System;
using System.Collections.Generic;
using System.Text;

namespace XpackHackathon.API.Models
{
        public class Address
        {
            public string AddressId { get; set; }
            public string Comment { get; set; }
            public string FullAddress { get; set; }
            public string AddressType { get; set; }
            public bool IsPrimary { get; set; }
        }
        public class AddressList
        {
            public List<Address> Addresses { get; set; }
        }
}
