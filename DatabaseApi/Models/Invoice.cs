using System;
using System.Collections.Generic;

namespace DatabaseApi.Models
{
    public class Invoice : MappableModel
    {
        public int PersonId { get; set; }
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalTaxDiscount { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}
