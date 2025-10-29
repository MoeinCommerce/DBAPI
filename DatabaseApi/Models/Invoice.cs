// System
using System;
using System.Collections.Generic;


namespace DatabaseApi.Models
{
    public class Invoice : MappableModel
    {
        // Private Variables
        private double? _tax;
        private double? _discount;
        private double? _itemsDiscount;
        private double? _subTotal;
        private double? _total;

        // Items
        public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

        // Details
        public int? InvoiceNumber { get; set; }
        public int? UserID { get; set; }
        public int? VisitorID { get; set; }
        public decimal? VisitorPercentage { get; set; }
        public decimal? VisitorPrice { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
        public InvoiceType? Type { get; set; }
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }
        public DateTime InvoiceDate { get; set; }
        public VehicleFare VehicleFare { get; set; }

        // Base Properties
        public double InvoiceDiscount { get; set; }

        // Computational Properties
        public double SubTotal 
        { 
            get
            {
                if (_subTotal != null)
                {
                    return _subTotal.Value;
                }

                double subTotal = 0;
                foreach (var invoiceItem in InvoiceItems)
                {
                    subTotal += invoiceItem.SubTotal;
                }

                return subTotal;
            }
            set
            {
                _subTotal = value;
            }
        }

        public double ItemsDiscount
        { 
            get
            {
                if (_itemsDiscount != null)
                {
                    return _itemsDiscount.Value;
                }

                double itemsDiscount = 0;
                foreach (var invoiceItem in InvoiceItems)
                {
                    itemsDiscount += invoiceItem.Discount;
                }

                return itemsDiscount;
            }
            set
            {
                _itemsDiscount = value;
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

                return ItemsDiscount + InvoiceDiscount;
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

                double tax = 0;
                foreach (var invoiceItem in InvoiceItems)
                {
                    tax += invoiceItem.Tax;
                }

                return tax;
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

                double vehicleFare = VehicleFare?.FareAmount ?? 0;
                return SubTotal - Discount + Tax + vehicleFare;
            }
            set
            {
                _total = value;
            }
        }
    }

    public enum InvoiceType
    {
        SellInvoice,
        PreInvoice,
        PurchaseInvoice
    }
}