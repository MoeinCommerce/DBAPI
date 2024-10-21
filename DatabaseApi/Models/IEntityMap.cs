using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public interface IEntityMap
    {
        int id { get; set; }
        int web_id { get; set; }
        int target_web { get; set; }
        DateTime last_update { get; set; }
        bool update_required { get; set; }
    }
}
