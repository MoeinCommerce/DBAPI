namespace DatabaseApi.Models
{
    public class InvoiceItem
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int WarehouseId { get; set; }
        public string RegularPrice { get; set; }
        public string SubtotalTax { get; set; }
        public string TotalTax { get; set; }
        public string SalePrice { get; set; }
    }
}
