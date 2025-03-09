using System.Collections.Generic;

namespace DatabaseApi.Models
{
    public class SellInvoice : Invoice
    {
        private double? _total;
        public List<Payment> Payments { get; set; }
        public VehicleFare VehicleFare { get; set; }
        public override double Total 
        {
            get
            {
                if (_total != null)
                {
                    return _total.Value;
                }

                double vehicleFare = VehicleFare?.FareAmount ?? 0;
                return SubTotal - Discount + Tax + vehicleFare;
            }
            set
            {
                _total = value;
            }
        }
    }
}