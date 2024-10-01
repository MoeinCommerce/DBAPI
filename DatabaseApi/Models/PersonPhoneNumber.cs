using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class PersonPhoneNumber
    {
        public int ID { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string Caption { get; set; }
        public string PhoneNumber { get; set; }
    }
}
