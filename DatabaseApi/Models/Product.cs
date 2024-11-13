using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class Product : MappableModel
    {
        public long? Code { get; set; }
        public string Unit { get; set; }   
        public string Description { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int WarehouseId { get; set; }
        public int StockQuantity { get; set; }
        public int? CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
