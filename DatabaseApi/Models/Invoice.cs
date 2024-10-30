using System;

namespace DatabaseApi.Models
{
    // This model should be updated
    public class Invoice : MappableModel
    {
        public int CompanyId { get; set; } 
        public int WarehouseId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}