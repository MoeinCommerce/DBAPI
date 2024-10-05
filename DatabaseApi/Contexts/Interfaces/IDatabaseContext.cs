using DatabaseApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Contexts.Interfaces
{
    public interface IDbContext : IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IEntityMapRepository EntityMapRepository { get; }
        IInventoryRepository InventoryRepository { get; }
        IInvoiceRepository InvoiceRepository { get; }
        IOrderRepository OrderRepository { get; }   
        IPersonCategoryRepository PersonCategoryRepository { get; }
        IPersonRepository PersonRepository { get; }
        IPriceLevelRepository PriceLevelRepository { get; }
        IProductPriceRepository ProductPriceRepository { get; }
        IStorageRepository StorageRepository { get; }
        IWebEntityRepository WebEntityRepository { get; }
        IWebProductRepository WebProductRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        ITableManager TableManager { get; }

        void SaveChanges();
        IEnumerable<T> ExecuteRawSql<T>(string query);
    }
}
