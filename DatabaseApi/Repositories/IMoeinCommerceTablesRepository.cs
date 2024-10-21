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
        bool UpdateProductMap(int moeinId, int webId, int targetWeb, IEntityMap entityMap);
        bool UpdateCategoryMap(int moeinId, int webId, int targetWeb, IEntityMap entityMap);
        bool UpdateCustomerMap(int moeinId, int webId, int targetWeb, IEntityMap entityMap);
        bool UpdateInvoiceMap(int moeinId, int webId, int targetWeb, IEntityMap entityMap);
        bool UpdatePaymentMethodMap(int moeinId, int webId, int targetWeb, IEntityMap entityMap);
        bool InsertProductMap(IEntityMap entityMap);
        bool InsertCategoryMap(IEntityMap entityMap);
        bool InsertCustomerMap(IEntityMap entityMap);
        bool InsertInvoiceMap(IEntityMap entityMap);
        bool InsertPaymentMethodMap(IEntityMap entityMap);
        void InstallTriggers();
    }
}
