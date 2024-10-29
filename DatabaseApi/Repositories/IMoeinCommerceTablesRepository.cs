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
        List<ProductMap> GetProductMapFilterByUpdateRequired(int targetWeb, bool isRequiredUpdate);
        List<CategoryMap> GetCategoryMapFilterByUpdateRequired(int targetWeb, bool isRequiredUpdate);
        List<InvoiceMap> GetInvoiceMapFilterByUpdateRequired(int targetWeb, bool isRequiredUpdate);
        List<CustomerMap> GetCustomerMapFilterByUpdateRequired(int targetWeb, bool isRequiredUpdate);
        List<PaymentMethodMap> GetPaymentMethodMapFilterByUpdateRequired(int targetWeb, bool isRequiredUpdate);
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
        bool DeleteProductMap(IEntityMap entityMap);
        bool DeleteCategoryMap(IEntityMap entityMap);
        bool DeleteCustomerMap(IEntityMap entityMap);
        bool DeleteInvoiceMap(IEntityMap entityMap);
        bool DeletePaymentMethodMap(IEntityMap entityMap);
        void InstallTriggers();
    }
}
