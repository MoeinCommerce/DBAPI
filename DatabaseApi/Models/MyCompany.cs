using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class MyCompany
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string EconomicCode { get; set; }
        public string Activity { get; set; }
        public string Email { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Manager { get; set; }
        public byte[] Logo { get; set; }
        public string Note { get; set; }
        public string NationalCode { get; set; }
        public string PostalCode { get; set; }
        public int Id { get; set; }
        public Nullable<byte> Type { get; set; }
        public Nullable<bool> IsYearClosed { get; set; }
    }
}
