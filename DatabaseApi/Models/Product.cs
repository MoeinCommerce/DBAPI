using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class Product
    {
        public Nullable<long> Code { get; set; }                // Product code
        public string Name { get; set; }                        // Product name
        public string Unit { get; set; }                        // Primary unit of measure
        public string SecondaryUnit { get; set; }               // Secondary unit of measure
        public Nullable<decimal> PurchasePrice { get; set; }    // Buy price
        public Nullable<int> ReorderPoint { get; set; }         // Reorder point
        public string StorageLocation { get; set; }             // Storage location
        public string PurchaseCode { get; set; }                // Purchase code
        public string SalesCode { get; set; }                   // Sales code
        public string AlternativePurchaseCode { get; set; }     // Alternative purchase code
        public string AlternativeSalesCode { get; set; }        // Alternative sales code
        public Nullable<int> Shortcut { get; set; }             // Shortcut key or reference
        public Nullable<int> GroupID { get; set; }              // Group ID
        public string ImagePath { get; set; }                   // Path to product image
        public Nullable<float> TotalQuantity { get; set; }      // Total quantity in stock
        public Nullable<bool> IsSelectable { get; set; }        // Indicates if product is selectable for sale
        public string ExternalCode1 { get; set; }               // External code 1
        public string ExternalCode2 { get; set; }               // External code 2
        public int ID { get; set; }                             // Unique ID
        public bool IsActive { get; set; }                      // Active status
        public bool IsTaxable { get; set; }                     // Taxable status
        public Nullable<float> VisitorPercentage { get; set; }  // Visitor percentage
        public Nullable<decimal> TotalPurchasePrice { get; set; } // Total buy price
        public Nullable<byte> UnitType { get; set; }            // Type of unit
        public string AdditionalInfo { get; set; }              // Additional information
        public Nullable<short> IconIndex { get; set; }          // Icon index
        public Nullable<float> Stock { get; set; }              // Stock quantity
        public string Barcode { get; set; }                     // Product barcode
        public Nullable<int> MenuOrder { get; set; }            // Menu display order
        public Nullable<bool> HasWeight { get; set; }           // Indicates if the product has weight
        public Nullable<float> Thickness { get; set; }          // Product thickness
        public Nullable<float> Density { get; set; }            // Product density
        public Nullable<decimal> Cost { get; set; }             // Cost price
        public Nullable<decimal> SalePrice { get; set; }        // Sale price
        public Nullable<decimal> IncrementPercentage { get; set; } // Price increase percentage
        public Nullable<decimal> IncrementAmount { get; set; }  // Price increment amount
        public Nullable<int> PriceCalculationMethod { get; set; } // Method of price calculation
        public Nullable<decimal> CalculatedValue { get; set; }  // Calculated value
    }
}
