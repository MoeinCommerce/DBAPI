namespace DatabaseApi.Models
{
    public class PreInvoice : Invoice
    {
        private double? _total;

        public override double Total
        {
            get
            {
                if (_total != null)
                {
                    return _total.Value;
                }

                return SubTotal - Discount + Tax;
            }
            set
            {
                _total = value;
            }
        }
    }
}
