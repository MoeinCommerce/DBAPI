using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class ProductPriceLevel
    {
        public int ID { get; set; }            // Price level ID
        public string Description { get; set; } // Price level description or caption
    }
}
