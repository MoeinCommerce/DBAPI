using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IMoeinCommerceTablesRepository
    {
        void CreateAllTables();
        void CreatePaymentMethodMapTable();
        void CreateCategoryMapTable();
        void CreateCustomerMapTable();
        void CreateWebCategoryTable();
        void CreateProductMapTable();
        void CreateInvoiceMapTable();
        void CreateWebProductTable();
        List<ProductMap> GetProductMapUpdateRequired(int targetWeb);
        List<CategoryMap> GetCategoryMapUpdateRequired(int targetWeb);
        List<InvoiceMap> GetInvoiceMapUpdateRequired(int targetWeb);
        List<CustomerMap> GetCustomerMapUpdateRequired(int targetWeb);
        List<PaymentMethodMap> GetPaymentMethodMapUpdateRequired(int targetWeb);
        void InstallTriggers();
    }
}
