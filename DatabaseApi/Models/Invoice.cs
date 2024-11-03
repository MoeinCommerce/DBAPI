using System;

namespace DatabaseApi.Models
{
    public class Invoice : MappableModel
    {
        public int PersonId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
