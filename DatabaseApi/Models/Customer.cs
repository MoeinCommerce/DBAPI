using System;
using System.Collections;
using System.Collections.Generic;

namespace DatabaseApi.Models
{
    public class Customer : MappableModel
    {
        public int? Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }

}