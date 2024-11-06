using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseApi.Contexts.Interfaces;
using DatabaseApi.Models;

namespace DatabaseApi.Contexts
{
    public abstract class BaseDatabaseContext : IDbContext
    {
        #region Fields

        protected Dictionary<string, string> Configs;

        #endregion

        #region Constructors

        protected BaseDatabaseContext(Dictionary<string, string> configs)
        {
            Configs = configs;
        }

        #endregion

        #region Product

        public Product CreateProductMap(Product product)
        {
            throw new System.NotImplementedException();
        }
        public Product UpdateProductMap(int id, int webId, int targetWeb, Product product)
        {
            throw new System.NotImplementedException();
        }
        public Product CreateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProductMap(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProductMapById(int productId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts(int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByIds(IEnumerable<int> ids)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetMappedProducts(int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetUnMappedProducts(int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetMappedProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetUnMappedProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProductsNeedToUpdate(int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Category

        public Product CreateCategoryMap(Category category)
        {
            throw new System.NotImplementedException();
        }

        public Category CreateCategory(Category category)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCategoryMap(Category category)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCategoryMapById(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories(int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetMappedCategories(int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetUnMappedCategories(int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetMappedCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetUnMappedCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetCategoriesNeedToUpdate(int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetCategoriesByWebId(int webId, int targetWeb)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region PriceLevel

        public IEnumerable<PriceLevel> GetPriceLevels()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Warehouse

        public IEnumerable<Warehouse> GetWarehouses()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region General

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<T> SqlQuery<T>(string query, params object[] args)
        {
            return null;
        }
        public void ExecuteRawSql(string query, params object[] args)
        {
            throw new System.NotImplementedException();
        }
        public Task ExecuteRawSqlAsync(string query, params object[] args)
        {
            throw new System.NotImplementedException();
        }
        public void SwitchDatabase(string databaseName)
        {
            throw new System.NotImplementedException();
        }
        public void InstallPrerequisites()
        {
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}