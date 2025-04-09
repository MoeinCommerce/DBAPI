// System
using System;
using System.Collections.Generic;


namespace DatabaseApi.Models
{
    public class Customer : MappableModel
    {
        public int? GroupId { get; set; }
        public int? Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string NationalCode { get; set; }
        public string PostCode { get; set; }
        public string AccountNumber { get; set; }
        public string CompanyName { get; set; }
        public string WebSite { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }

}