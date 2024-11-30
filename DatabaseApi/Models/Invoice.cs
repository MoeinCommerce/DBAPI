using System;
using System.Collections.Generic;

namespace DatabaseApi.Models
{
    public class Invoice : MappableModel
    {
        // Foreign Key
        public int PersonId { get; set; }

        // PreInvoice Items
        public List<InvoiceItem> InvoiceItems { get; set; }

        // PreInvoice Details
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Billing Billing { get; set; }
        public Shipping Shipping { get; set; }

        // Base Properties
        public double InvoiceDiscount { get; set; }
        public double InvoiceTax { get; set; }
        public double CarryPrice { get; set; }

        // Computational Properties
        public double SubTotal 
        { 
            get
            {
                double subTotal = 0;
                foreach (var invoiceItem in InvoiceItems)
                {
                    subTotal += invoiceItem.SubTotal;
                }

                return subTotal;
            } 
        }

        public double ItemsDiscount
        { 
            get
            {
                double itemsDiscount = 0;
                foreach (var invoiceItem in InvoiceItems)
                {
                    itemsDiscount += invoiceItem.Discount;
                }

                return itemsDiscount;
            }
        }

        public double Discount => ItemsDiscount + InvoiceDiscount;

        public double Tax
        {
            get
            {
                double tax = InvoiceTax;
                foreach (var invoiceItem in InvoiceItems)
                {
                    tax += invoiceItem.Tax;
                }

                return tax;
            }
        }

        public double Total => SubTotal - Discount + Tax + CarryPrice;
    }
}