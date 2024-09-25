using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class Inventory
    {
        public int ProductID { get; set; }                   // Product ID
        public Nullable<float> Quantity { get; set; }        // Total quantity in stock
        public Nullable<decimal> TotalValue { get; set; }    // Total value of inventory
        public Nullable<decimal> UnitPrice { get; set; }     // Unit price
        public Nullable<decimal> TotalPrice { get; set; }    // Total price of available stock
        public int WarehouseID { get; set; }                 // Warehouse or storage ID
        public Nullable<float> QuantityUnit1 { get; set; }   // Quantity in primary unit
        public Nullable<float> QuantityUnit2 { get; set; }   // Quantity in secondary unit
    }
}
