namespace DatabaseApi.Models
{
    public class PaymentMethod : MappableModel
    {
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }
    }
}