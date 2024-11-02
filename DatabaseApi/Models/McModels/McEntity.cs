using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models.McModels
{
    public class McEntity
    {
        public int id { get; set; }
        public int wcid { get; set; }
        public int target_web { get; set; }
        public DateTime last_update { get; set; }
        public bool update_required { get; set; }
    }
}
