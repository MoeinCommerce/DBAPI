using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class InvoiceServiceItem
    {
        public int ServiceID { get; set; } // IDService -> ServiceID
        public float? Quantity { get; set; } // Tedad -> Quantity
        public decimal? UnitPrice { get; set; } // Price -> UnitPrice
        public decimal? TotalPrice { get; set; } // SumPrice -> TotalPrice
        public string Information { get; set; } // Info -> Information
        public float? DiscountPercentage { get; set; } // TakhfifPerc -> DiscountPercentage
        public decimal VisitorPrice { get; set; }
        public float VisitorPercentage { get; set; } // VisitorPerc -> VisitorPercentage
        public int InvoiceServiceItemID { get; set; } // ID -> InvoiceServiceItemID
        public int? InvoiceID { get; set; } // FactorID -> InvoiceID
        public decimal? Discount { get; set; } // Takhfif -> Discount
        public int PaymentValue { get; set; }
        public short PaymentType { get; set; }
        public DateTime PaymentDate { get; set; } // PaymentDate -> PaymentDate (changed to DateTime)
        public decimal? Tax { get; set; } // Maliat -> Tax
        public int? TechnicianID { get; set; }
        public decimal? TechnicianPrice { get; set; }
        public float? TechnicianPercentage { get; set; } // TechnicianPerc -> TechnicianPercentage
        public bool? IsAuto { get; set; } // Auto -> IsAuto
        public int? RowNumber { get; set; } // Row -> RowNumber
        public int? PriceLevelID { get; set; }
    }

}
