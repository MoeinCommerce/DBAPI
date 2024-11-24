namespace DatabaseApi.Models
{
    public class InvoiceItem
    {
        // Foreign Keys
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int PriceId { get; set; }

        // Base Properties
        public double UnitPrice { get; set; }
        public double UnitDiscount { get; set; }
        public double UnitTax { get; set; }
        public int Quantity { get; set; }

        // Computational Properties
        public double SubTotal => Quantity * UnitPrice;
        public double Discount => Quantity * UnitDiscount;
        public double Tax => Quantity * UnitTax;
        public double Total => SubTotal - Discount + Tax;
    }
}
