using System.Collections.Generic;

namespace DatabaseApi.Models
{
    public class SellInvoice : Invoice
    {
        public List<Payment> Payments { get; set; }
    }
}