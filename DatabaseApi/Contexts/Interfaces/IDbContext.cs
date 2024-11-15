using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseApi.Exceptions;
using DatabaseApi.Models;

namespace DatabaseApi.Contexts.Interfaces
{
    public interface IDbContext : IDisposable
    {
        #region Product
        
        /// <summary>
        /// Creates a mapping between a product and a corresponding web representation.
        /// This mapping links the product to its representation on a specific website.
        /// </summary>
        /// <param name="product">
        /// The product to be mapped, including the ID, WebId, and TargetWeb values.
        /// </param>
        /// <exception cref="InvalidFieldException">
        /// Thrown if the product is invalid.
        /// - Set the Field property to the name of the invalid property.
        /// - Set the Content property to a message explaining the validation issue.
        /// </exception>
        void CreateProductMap(Product product);

        /// <summary>
        /// Update product map by id, webId and targetWeb.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webId"></param>
        /// <param name="targetWeb"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        Product UpdateProductMap(int id, int webId, int targetWeb, Product product);

        /// <summary>
        /// Creates a new product in the product table and generates a mapping to its web representation.
        /// </summary>
        /// <param name="product">
        /// The product to be created and added to the product table.
        /// </param>
        /// <returns>
        /// The newly created product in the product table.
        /// </returns>
        /// <exception cref="InvalidFieldException">
        /// Thrown if the product is invalid.
        /// </exception>
        Product CreateProduct(Product product);

        /// <summary>
        /// Deletes a mapping that links a product to its web representation.
        /// </summary>
        /// <param name="product">
        /// The product whose ID, WebId, and TargetWeb are used to identify and delete the mapping.
        /// </param>
        /// <exception cref="InvalidFieldException">
        /// Thrown if the product is invalid.
        /// </exception>
        void DeleteProductMap(Product product);
        
        /// <summary>
        /// Retrieves paginated and filtered products mapped to other products on a specified web platform
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering product-to-product mappings.
        /// </param>
        /// <param name="priceLevel">
        ///     The price level to filter price of products.
        ///     if price level is null, default price is returned.
        /// </param>
        /// <param name="warehouse">
        ///     The warehouse to filter stock quantity of products.
        ///     if warehouse is null, sum of quantities are returned.
        /// </param>
        /// <returns>
        /// A paginated list of products mapped to other products on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetMappedProducts(int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null);
        
        /// <summary>
        /// Retrieve products filtered by list of ids.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        IEnumerable<Product> GetProductsByIds(IEnumerable<int> ids);

        /// <summary>
        /// Retrieves paginated and filtered products to a specified web platform, using a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering products.
        /// If searchInput is null or empty, all products are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of products per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering products.
        /// </param>
        /// <param name="priceLevel">
        ///     The price level to filter price of products.
        ///     if price level is null, default price is returned.
        /// </param>
        /// <param name="warehouse">
        ///     The warehouse to filter stock quantity of products.
        ///     if warehouse is null, sum of quantities are returned.
        /// </param>
        /// <returns>
        /// A paginated list of products to the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null);

        /// <summary>
        /// Retrieves paginated and filtered products mapped to other products on a specified web platform, using a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering product-to-product mappings.
        /// If searchInput is null or empty, all products are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of products per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering product-to-product mappings.
        /// </param>
        /// <param name="priceLevel">
        ///     The price level to filter price of products.
        ///     if price level is null, default price is returned.
        /// </param>
        /// <param name="warehouse">
        ///     The warehouse to filter stock quantity of products.
        ///     if warehouse is null, sum of quantities are returned.
        /// </param>
        /// <returns>
        /// A paginated list of products mapped to other products on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetMappedProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null);

        /// <summary>
        /// Retrieves paginated and filtered products that are not mapped to other products on a specified web platform, using a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering unmapped products.
        /// If searchInput is null or empty, all products are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of products per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering unmapped products.
        /// </param>
        /// <param name="priceLevel">
        ///     The price level to filter price of products.
        ///     if price level is null, default price is returned.
        /// </param>
        /// <param name="warehouse">
        ///     The warehouse to filter stock quantity of products.
        ///     if warehouse is null, sum of quantities are returned.
        /// </param>
        /// <returns>
        /// A paginated list of products not mapped to other products on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetUnMappedProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null);

        /// <summary>
        /// Retrieves all products that require updates on a specified website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering products needing updates.
        /// </param>
        /// <param name="priceLevel">
        ///     The price level to filter price of products.
        ///     if price level is null, default price is returned.
        /// </param>
        /// <param name="warehouse">
        ///     The warehouse to filter stock quantity of products.
        ///     if warehouse is null, sum of quantities are returned.
        /// </param>
        /// <returns>
        /// A list of products that need to be updated on the specified web platform.
        /// </returns>
        IEnumerable<Product> GetProductsNeedToUpdate(int targetWeb, PriceLevel priceLevel = null, Warehouse warehouse = null);
        
        #endregion

        #region Category
        
        /// <summary>
        /// Creates a mapping between a category and a corresponding web representation.
        /// This mapping links the category to its representation on a specific website.
        /// </summary>
        /// <param name="category">
        /// The category to be mapped, including the ID, WebId, and TargetWeb values.
        /// </param>
        /// <exception cref="InvalidFieldException">
        /// Thrown if the category is invalid.
        /// - Set the Field property to the name of the invalid property.
        /// - Set the Content property to a message explaining the validation issue.
        /// </exception>
        void CreateCategoryMap(Category category);

        /// <summary>
        /// Creates a new category in the category table and generates a mapping to its web representation.
        /// </summary>
        /// <param name="category">
        /// The category to be created and added to the category table.
        /// </param>
        /// <returns>
        /// The newly created category in the category table.
        /// </returns>
        /// <exception cref="InvalidFieldException">
        /// Thrown if the category is invalid.
        /// </exception>
        Category CreateCategory(Category category);

        /// <summary>
        /// Deletes a mapping that links a category to its web representation.
        /// </summary>
        /// <param name="category">
        /// The category whose ID, WebId, and TargetWeb are used to identify and delete the mapping.
        /// </param>
        /// <exception cref="InvalidFieldException">
        /// Thrown if the category is invalid.
        /// </exception>
        void DeleteCategoryMap(Category category);
        
        /// <summary>
        /// Retrieves all categories mapped to other categories on a specified web platform.
        /// This mapping shows category-to-category associations on the target website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering category-to-category mappings.
        /// </param>
        /// <returns>
        /// A list of categories mapped to other categories on the specified web platform.
        /// </returns> 
        IEnumerable<Category> GetMappedCategories(int targetWeb);

        /// <summary>
        /// Retrieves paginated and filtered categories to a specified web platform, using a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering categories.
        /// If searchInput is null or empty, all categories are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of categories per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering categories.
        /// </param>
        /// <returns>
        /// A paginated list of categories to the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Category> GetCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

        /// <summary>
        /// Retrieves paginated and filtered categories mapped to other categories on a specified web platform, using a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering category-to-category mappings.
        /// If searchInput is null or empty, all categories are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of categories per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering category-to-category mappings.
        /// </param>
        /// <returns>
        /// A paginated list of categories mapped to other categories on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Category> GetMappedCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

        /// <summary>
        /// Retrieves paginated and filtered categories that are not mapped to other categories on a specified web platform, using a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering unmapped categories.
        /// If searchInput is null or empty, all categories are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of categories per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering unmapped categories.
        /// </param>
        /// <returns>
        /// A paginated list of categories not mapped to other categories on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Category> GetUnMappedCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

        /// <summary>
        /// Retrieves all categories that require updates on a specified website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering categories needing updates.
        /// </param>
        /// <returns>
        /// A list of categories that need to be updated on the specified web platform.
        /// </returns>
        IEnumerable<Category> GetCategoriesNeedToUpdate(int targetWeb);
        
        #endregion
        
        #region PriceLevel
        
        /// <summary>
        /// Gets all price levels from the database.
        /// </summary>
        /// <returns></returns>
        IEnumerable<PriceLevel> GetPriceLevels();
        
        #endregion
        
        #region Warehouse
        
        /// <summary>
        /// Gets all warehouses from the database.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Warehouse> GetWarehouses();
        
        #endregion

        #region Other Methods

        /// <summary>
        /// Switches the active database to the specified database name.
        /// </summary>
        /// <param name="databaseName">
        /// The name of the database to switch to.
        /// </param>
        void SwitchDatabase(string databaseName);

        IEnumerable<TModel> ExecuteRawSqlTemporary<TModel>(string query);

        #endregion
    }
}
