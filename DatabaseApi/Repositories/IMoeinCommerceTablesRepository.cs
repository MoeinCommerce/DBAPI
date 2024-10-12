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
    }
}
