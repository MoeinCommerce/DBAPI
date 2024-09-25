using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class OrderHeader
    {
        public int ID { get; set; }                         // Unique order ID
        public int InvoiceNumber { get; set; }              // Invoice number
        public string Date { get; set; }                    // Order date
        public int CustomerID { get; set; }                 // Customer ID (person or entity)
        public Nullable<int> ReferenceInvoice { get; set; } // Reference invoice number
        public Nullable<decimal> TotalOrderAmount { get; set; } // Total order amount
        public Nullable<decimal> TotalReceivedAmount { get; set; } // Total amount received
        public Nullable<decimal> DiscountAmount { get; set; } // Discount or reduction amount
        public string Notes { get; set; }                   // Additional information
        public int WarehouseID { get; set; }                // Warehouse or storage ID
        public string Time { get; set; }                    // Order time
        public Nullable<decimal> DeliveryCharge { get; set; } // Delivery charge
        public Nullable<int> DriverID { get; set; }         // Driver ID (for delivery)
    }

}
