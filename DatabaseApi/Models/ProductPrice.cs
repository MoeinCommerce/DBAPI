using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class ProductPrice
    {
        public int ID { get; set; }                         // Unique identifier
        public Nullable<int> PriceID { get; set; }          // Price reference ID
        public Nullable<int> ProductID { get; set; }        // Product (Kala) ID
        public Nullable<int> PriceType { get; set; }        // Type of price (e.g., sell, buy)
        public Nullable<decimal> BasePrice { get; set; }    // Base price of the product
        public Nullable<double> DiscountPercentage { get; set; } // Discount percentage
        public Nullable<decimal> FinalPrice { get; set; }   // Final price after discount
        public Nullable<decimal> DiscountAmount { get; set; } // Discount amount in currency
    }
}
