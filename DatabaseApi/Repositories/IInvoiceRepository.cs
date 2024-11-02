using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IInvoiceRepository
    {
        bool InsertPreInvoice(Invoice invoice, IEnumerable<InvoiceItem> invoiceItems);
        bool InsertSellInvoice(Invoice invoice, IEnumerable<InvoiceItem> invoiceItems);
        bool InvoiceExists(int webId);
        bool DeleteCaseCadeInvoice(int moeinInvoiceId);
        IEnumerable<Invoice> GetMCInvoices();
        IEnumerable<InvoiceItem> GetInvoiceDetails(int invoiceId);
    }
}
