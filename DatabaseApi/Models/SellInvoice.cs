namespace DatabaseApi.Models
{
    public class SellInvoice : Invoice
    {
        public Payment Payment { get; set; }
    }
}