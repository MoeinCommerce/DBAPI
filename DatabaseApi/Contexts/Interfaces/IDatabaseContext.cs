using DatabaseApi.Repositories;
using System;
using System.Collections.Generic;

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
        ITableManager TableManager { get; }
        IMoeinCommerceTablesRepository MoeinCommerceTablesRepository { get; }

        void SaveChanges();
        IEnumerable<T> SqlQuery<T>(string query);
        void ExecuteRawSql(string query, params object[] args);
        void SwitchDatabase(string databaseName);
    }
}
