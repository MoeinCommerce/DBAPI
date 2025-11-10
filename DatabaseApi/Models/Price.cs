using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class Price
    {
        public long Id { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int PriceLevelId { get; set; }
        public PriceLevel PriceLevel { get; set; }
    }
}
