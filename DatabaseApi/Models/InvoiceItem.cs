namespace DatabaseApi.Models
{
    public class InvoiceItem
    {
        // Private Variables
        private double? _subTotal;
        private double? _discount;
        private double? _tax;
        private double? _total;

        // Foreign Keys
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int WarehouseId { get; set; }
        public int PriceId { get; set; }

        // Base Properties
        public double UnitPrice { get; set; }
        public double UnitDiscount { get; set; }
        public double UnitTax { get; set; }
        public int Quantity { get; set; }

        // Computational Properties
        public double SubTotal
        {
            get
            {
                if (_subTotal != null)
                {
                    return _subTotal.Value;
                }

                return Quantity * UnitPrice;
            }
            set
            {
                _subTotal = value;
            }
        }

        public double Discount
        {
            get
            {
                if (_discount != null)
                {
                    return _discount.Value;
                }

                return Quantity * UnitDiscount;
            }
            set
            {
                _discount = value;
            }
        }

        public double Tax
        {
            get
            {
                if (_tax != null)
                {
                    return _tax.Value;
                }

                return Quantity * UnitTax;
            }
            set
            {
                _tax = value;
            }
        }

        public double Total
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
