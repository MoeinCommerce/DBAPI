// System
using System;


namespace DatabaseApi.Models
{
    public class VehicleFare
    {
        public int? DriverCode { get; set; }
        public string DriverName { get; set; }
        public double FareAmount { get; set; }
        public FareType FareType { get; set; }
        public DestinationAccount DestinationAccount { get; set; }
        public DateTime PaymentFrom { get; set; }
        public string Description { get; set; }
        public VehicleInfo Vehicle { get; set; }
    }

    public class VehicleInfo
    {
        public string VehicleType { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public string PhoneNumber { get; set; }
    }

    public enum FareType
    {
        WithBuyer,
        WithSeller
    }

    public enum DestinationAccount
    {
        Bank,
        Fund,
        Person
    }

}
