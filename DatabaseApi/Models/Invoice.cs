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

        // PreInvoice Items
        public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

        // PreInvoice Details
        public int? InvoiceNumber { get; set; }
        public Customer Customer { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }

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

        public virtual double Total
        {
            get => _total.Value;
            set => _total = value;
        }
    }
    public enum InvoiceType
    {
        SellInvoice,
        PreInvoice,
        PurchaseInvoice
    }
}