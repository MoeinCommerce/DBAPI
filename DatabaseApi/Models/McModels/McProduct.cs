using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models.McModels
{
    public class McProduct
    {
        public int id { get; set; }
        public int? web_id { get; set; }
        public string name { get; set; }
        public string web_name { get; set; }
        public int? target_web { get; set; }
    }
}
