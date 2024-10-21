using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class InvoiceMap : IEntityMap
    {
        public int id { get; set; }
        public int web_id { get; set; }
        public int target_web { get; set; }
        public DateTime last_update { get; set; }
        public bool update_required { get; set; }
    }
}
