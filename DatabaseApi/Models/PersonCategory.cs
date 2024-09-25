using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class PersonCategory
    {
        public int ID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Caption { get; set; }
        public bool SMS { get; set; }
        public Nullable<int> SysID { get; set; }
    }
}
