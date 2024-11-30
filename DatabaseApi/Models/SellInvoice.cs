namespace DatabaseApi.Models
{
    public class SellInvoice : PreInvoice
    {
        public Payment Payment { get; set; }
    }
}