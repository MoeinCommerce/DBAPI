using System.Collections.Generic;
using DatabaseApi.Models;
using DatabaseApi.Exceptions;

namespace DatabaseApi.Repositories
{
    public interface IRepository
    {
        #region Product
        
        /// <summary>
        /// Creates a mapping between a product and a corresponding web representation.
        /// This mapping links the product to its representation on a specific website.
        /// </summary>
        /// <param name="product">
        /// The product to be mapped, including the ID, WebId, and TargetWeb values.
        /// </param>
        /// <returns>
        /// A map representing the connection between the product and its web representation.
        /// </returns>
        /// <exception cref="ValidationError">
        /// Thrown if the product is invalid.
        /// - Set the Field property to the name of the invalid property.
        /// - Set the Content property to a message explaining the validation issue.
        /// </exception>
        Product CreateProductMap(Product product);

        /// <summary>
        /// Creates a new product in the product table and generates a mapping to its web representation.
        /// </summary>
        /// <param name="product">
        /// The product to be created and added to the product table.
        /// </param>
        /// <returns>
        /// The newly created product in the product table.
        /// </returns>
        /// <exception cref="ValidationError">
        /// Thrown if the product is invalid.
        /// </exception>
        Product CreateProduct(Product product);

        /// <summary>
        /// Updates an existing product in the product table.
        /// </summary>
        /// <param name="product">
        /// The product object with updated details.
        /// </param>
        /// <returns>
        /// The updated product object.
        /// </returns>
        /// <exception cref="ValidationError">
        /// Thrown if the product update is invalid.
        /// </exception>
        Product UpdateProduct(Product product);

        /// <summary>
        /// Deletes a mapping that links a product to its web representation.
        /// </summary>
        /// <param name="product">
        /// The product whose ID, WebId, and TargetWeb are used to identify and delete the mapping.
        /// </param>
        /// <exception cref="ValidationError">
        /// Thrown if the product is invalid.
        /// </exception>
        void DeleteProductMap(Product product);
        
        /// <summary>
        /// Deletes a mapping that links a product to its web representation by productId.
        /// </summary>
        /// <param name="productId">
        /// The ID of the product to be deleted.
        /// </param>
        /// <exception cref="DoesNotExistError">
        /// Thrown if the product does not exist.
        /// </exception>
        void DeleteProductMapById(int productId);

        /// <summary>
        /// Retrieves all products mapped to a specified web platform.
        /// This mapping lists all products associated with a particular website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering products.
        /// </param>
        /// <returns>
        /// A list of products mapped to the specified web platform.
        /// </returns>
        IEnumerable<Product> GetProducts(int targetWeb);

        /// <summary>
        /// Retrieves all products mapped to other products on a specified web platform.
        /// This mapping shows product-to-product associations on the target website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering product-to-product mappings.
        /// </param>
        /// <returns>
        /// A list of products mapped to other products on the specified web platform.
        /// </returns> 
        IEnumerable<Product> GetMappedProducts(int targetWeb);

        /// <summary>
        /// Retrieves all products on a specified web platform that are not mapped to other products.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform to filter unmapped products.
        /// </param>
        /// <returns>
        /// A list of products that are not mapped to other products on the specified web platform.
        /// </returns>
        IEnumerable<Product> GetUnMappedProducts(int targetWeb);

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
        /// <returns>
        /// A paginated list of products to the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

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
        /// <returns>
        /// A paginated list of products mapped to other products on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetMappedProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

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
        /// <returns>
        /// A paginated list of products not mapped to other products on the specified web platform that match the search term.
        /// </returns>
        IEnumerable<Product> GetUnMappedProductsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

        /// <summary>
        /// Retrieves all products that require updates on a specified website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering products needing updates.
        /// </param>
        /// <returns>
        /// A list of products that need to be updated on the specified web platform.
        /// </returns>
        IEnumerable<Product> GetProductsNeedToUpdate(int targetWeb);
        
        #endregion

        #region Category
        
        /// <summary>
        /// Creates a mapping between a category and a corresponding web representation.
        /// This mapping links the category to its representation on a specific website.
        /// </summary>
        /// <param name="category">
        /// The category to be mapped, including the ID, WebId, and TargetWeb values.
        /// </param>
        /// <returns>
        /// A map representing the connection between the category and its web representation.
        /// </returns>
        /// <exception cref="ValidationError">
        /// Thrown if the category is invalid.
        /// - Set the Field property to the name of the invalid property.
        /// - Set the Content property to a message explaining the validation issue.
        /// </exception>
        Product CreateCategoryMap(Category category);

        /// <summary>
        /// Creates a new category in the category table and generates a mapping to its web representation.
        /// </summary>
        /// <param name="category">
        /// The category to be created and added to the category table.
        /// </param>
        /// <returns>
        /// The newly created category in the category table.
        /// </returns>
        /// <exception cref="ValidationError">
        /// Thrown if the category is invalid.
        /// </exception>
        Category CreateCategory(Category category);

        /// <summary>
        /// Deletes a mapping that links a category to its web representation.
        /// </summary>
        /// <param name="category">
        /// The category whose ID, WebId, and TargetWeb are used to identify and delete the mapping.
        /// </param>
        /// <exception cref="ValidationError">
        /// Thrown if the category is invalid.
        /// </exception>
        void DeleteCategoryMap(Category category);
        
        /// <summary>
        /// Deletes a mapping that links a category to its web representation by categoryId.
        /// </summary>
        /// <param name="categoryId">
        /// The ID of the category to be deleted.
        /// </param>
        /// <exception cref="DoesNotExistError">
        /// Thrown if the categoryId does not exist.
        /// </exception>
        void DeleteCategoryMapById(int categoryId);

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
        IEnumerable<Category> GetAllCategories(int targetWeb);
        
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
        IEnumerable<Product> GetMappedCategories(int targetWeb);

        /// <summary>
        /// Retrieves all categories on a specified web platform that are not mapped to other categories.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform to filter unmapped categories.
        /// </param>
        /// <returns>
        /// A list of categories that are not mapped to other categories on the specified web platform.
        /// </returns>
        IEnumerable<Product> GetUnMappedCategories(int targetWeb);

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
        IEnumerable<Product> GetCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

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
        IEnumerable<Product> GetMappedCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

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
        IEnumerable<Product> GetUnMappedCategoriesBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

        /// <summary>
        /// Retrieves all categories that require updates on a specified website.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering categories needing updates.
        /// </param>
        /// <returns>
        /// A list of categories that need to be updated on the specified web platform.
        /// </returns>
        IEnumerable<Product> GetCategoriesNeedToUpdate(int targetWeb);
        
        #endregion

        #region Tables

        void CreateTable(string name, List<string> columnInfo);
        void DeleteTable(string name);
        void CreateTrigger(string triggerName, string triggerSql);

        #endregion
    }
}
