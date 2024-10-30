using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DatabaseApi.Models;
using DatabaseApi.Models.MapModels.Entities;
using DatabaseApi.Models.McModels;

namespace DatabaseApi.Repositories
{
    public interface IRepository
    {
        /// <summary>
        /// This method creates a product in product table also creates a mapping in product map table
        /// and then returns the created product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns>Created product</returns>
        Product CreateProduct(Product product);
        
        /// <summary>
        /// This method creates a product map in product map table
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product CreateProductMap(Product product);
        
        /// <summary>
        /// This method updates a product in product table.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Product UpdateProduct(Product product);
        
        /// <summary>
        /// This method delete a product map in product map table
        /// </summary>
        /// <param name="product"></param>
        void DeleteProductMap(Product product);
        
        /// <summary>
        /// This method returns all products that are mapped and unmapped to a web.
        /// </summary>
        /// <param name="targetWeb">
        ///This is the target web that we want to get all products that are mapped to it.
        /// </param>
        /// <returns>
        /// List of products that are mapped on the target web and not mapped on any other website.
        /// These products should be joined with ProductMap table and WebProduct table to get the full information.
        /// (Mapped and unmapped products)
        /// </returns>
        IEnumerable<Product> GetAllProductsToWeb(int targetWeb);

        /// <summary>
        /// This method returns all products that are mapped to a web.
        /// </summary>
        /// <param name="targetWeb">
        /// This is the target web that we want to get all products that are mapped to it.
        /// </param>
        /// <returns>
        /// List of products that are mapped on the target web.
        /// </returns>
        IEnumerable<Product> GetAllProductsMappedToWeb(int targetWeb);
        
        
        IEnumerable<McProduct> GetAllMappedProducts(Expression<Func<McProduct, bool>> filter = null);
        IEnumerable<McProduct> GetAllUnMappedProducts(Expression<Func<McProduct, bool>> filter = null);
        IEnumerable<McProduct> GetAllProductsWithMapping();
        IEnumerable<McProduct> GetPagedProductsBySearch(string searchInput, int pageNumber, int pageSize);
        IEnumerable<McProduct> GetPagedProductsBySearchAndIds(string searchInput, int pageNumber, int pageSize, IEnumerable<int> filteredIds);

    }
    /*
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        int GetCount();
        T GetById(int id);
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
        T Normalize(T entity);
        bool Validate(T entity);
    }
    */
}
