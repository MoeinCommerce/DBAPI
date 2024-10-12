using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class WebEntity
    {
        public int web_id { get; set; }
        public string web_name { get; set; }
        public int target_web { get; set; }
    }
}
