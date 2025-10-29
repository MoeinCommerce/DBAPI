using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class Visitor
    {
        public int ID { get; set; }
        public int? GroupId { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }
        public decimal? VisitPercentage { get; set; }
        public decimal? VisitPrice { get; set; }
    }
}
