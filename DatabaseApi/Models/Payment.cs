// System
using System;


namespace DatabaseApi.Models
{
    public class Payment
    {
        public string InvoiceId { get; set; }
        public string PaymentMethodId { get; set; }
        public string TransactionId { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}