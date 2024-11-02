namespace DatabaseApi.Models
{
    public class InvoiceItem
    {
        public int InvoiceId { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string  WarehouseName { get; set; }
    }
}