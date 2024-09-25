using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class OrderDetail
    {
        public int ID { get; set; }                         // Detail line item ID
        public int OrderID { get; set; }                    // Associated order ID
        public int LineNumber { get; set; }                 // Line item number
        public int ProductID { get; set; }                  // Product ID
        public Nullable<decimal> UnitPrice { get; set; }    // Price per unit
        public string Notes { get; set; }                   // Additional information
        public int WarehouseID { get; set; }                // Warehouse or storage ID
        public Nullable<float> OrderedQuantity { get; set; } // Quantity ordered
        public Nullable<float> ReceivedQuantity { get; set; } // Quantity received
    }
}
