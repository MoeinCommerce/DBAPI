using System;

namespace DatabaseApi.Models
{
    public class Payment
    {
        public int InvoiceId { get; set; }
        public int PaymentMethodId { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
    }
}