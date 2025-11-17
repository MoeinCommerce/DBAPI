// DatabaseApi
using DatabaseApi.Exceptions;
using DatabaseApi.Models;
// System
using System;
using System.Collections.Generic;
using System.Numerics;


namespace DatabaseApi.Contexts.Interfaces
{
    public interface IDbContext : IDisposable
    {
        #region Product
        
        /// <summary>
        /// Retrieves product by webId.
        /// </summary>
        /// <param name="webId"></param>
        /// <param name="targetWeb"></param>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        Product GetProductByWebId(string webId, int targetWeb, Warehouse warehouse = null);
        
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
        Product UpdateProductMap(string id, string webId, int targetWeb, Product product);

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
        /// <exception cref="DoesNotExistException">
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
        /// A list of products that are mapped to other products on the specified web platform.
        /// </returns>
        IEnumerable<Product> GetMappedProducts(int targetWeb, PriceLevel priceLevel, Warehouse warehouse = null);

        IEnumerable<string> GetProductWebIds(int targetWeb);

        /// <summary>
        /// Retrieves products that are not mapped to other products.
        /// </summary>
        /// <returns>
        /// A list of products that are not mapped to other products.
        /// </returns>
        IEnumerable<Product> GetUnMappedProducts(int targetWeb);

        /// <summary>
        /// Retrieve products filtered by list of ids.
        /// </summary>
        /// <param name="targetWeb"></param>
        /// <param name="ids"></param>
        /// <param name="priceLevel"></param>
        /// <param name="warehouse"></param>
        /// <returns></returns>
        IEnumerable<Product> GetProductsByIds(int targetWeb, IEnumerable<string> ids, PriceLevel priceLevel,Warehouse warehouse = null);
        Product GetProductById(string productid, int targetWeb, PriceLevel priceLevel,Warehouse warehouse = null);

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
        /// Retrieves the number of products that match a search term on a specified web platform.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering products.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering products.
        /// </param>
        /// <returns></returns>
        int GetTotalProductsCount(string searchInput, int targetWeb);

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
        /// Retrieves the number of products mapped to other products on a specified web platform that match a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering product-to-product mappings.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering product-to-product mappings.
        /// </param>
        /// <returns></returns>
        int GetTotalMappedProductsCount(string searchInput, int targetWeb);

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
        /// retrieves the number of products that are not mapped to other products on a specified web platform that match a search term.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering unmapped products.
        /// </param>
        /// <returns></returns>
        int GetTotalUnMappedProductsCount(string searchInput, int targetWeb);

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
        IEnumerable<Product> GetProductsNeedToUpdate(int targetWeb, PriceLevel priceLevel, Warehouse warehouse = null);

        /// <summary>
        /// Retrive stock of specific product on each warehouse.
        /// </summary>
        /// <param name="prodcutId">Id of product</param>
        /// <param name="warehouseIds">List of warehouse id</param>
        /// <returns>List of tuples include warehouse id and stock of that warehouse.</returns>
        List<(int WarehouseId, double Stock)> GetProductStocksByWarehouseIds(int productId, List<int> warehouseIds);

        void SetProductsUpdateStatus(int targetWeb, bool updateRequired);


        #region Variable Product

        List<int> GetCollectionAttributeValueIds(int attributeId, int attributeValueId, int targetWeb);
        List<int> GetCollectionProductAttributeValueIds(int attributeValueId, int targetWeb);
        bool AttributeExists(string name, List<string> ignoreNames = null);
        int CreateAttribute(AttributeModel attribute);
        int CreateAttributeValue(AttributeValueModel attributeValue);
        bool AttributeValueExists(int attributeId, string value, List<string> ignoreValues = null);
        List<AttributeValueModel> GetAttributeValuesByAttributeId(int attributeId);
        bool IsAttributeValueUsedInCollection(int attributeId, int attributeValueId, int targetWeb);
        bool IsAttributeValueUsedInCollectionProduct(int attributeValueId, int targetWeb);
        void UpdateAttributeById(int attributeId, AttributeModel attribute);
        void UpdateAttributeValueById(int attributeValueId, AttributeValueModel attributeValue);
        void DeleteAttributeValueById(int attributeValueId);
        List<AttributeModel> GetAttributes();
        List<AttributeValueModel> GetAttributeValues();
        bool IsAttributeUsedInCollectionProduct(int attributeId, int targetWeb);
        void DeleteAttributeValueByAttributeId(int attributeId);
        void DeleteAttributeById(int attributeId);
        List<CollectionModel> GetCollections(int targetWebId, string searchTerm = "");
        List<CollectionAttributeModel> GetCollectionAttributesByCollectionId(string collectionId, int targetWebId);
        List<int> GetAttributeValueIdsByAttributeAndCollectionId(int attributeId, string collectionId, int targetWebId);
        List<AttributeValueModel> GetAttributeValuesByAttributeAndCollectionId(int attributeId, string collectionId, int targetWebId);
        List<Product> GetProductsByCollectionId(string collectionId, int targetWebId);
        List<AttributeValueModel> GetAttributeValuesByProductId(string productId, int targetWebId);
        void DeleteProductForeignKeyFromCollectionProductTableByCollectionId(string collectionId, int targetWebId);
        void DeleteProductForeignKeyFromCollectionProductTableByWebId(string webId, int targetWebId);
        void DeleteProductMapById(string id);
        void DeleteProductMapByWebId(string webId, int targetWebId);
        void DeleteProductMapByCollectionId(string collectionId, int targetWebId);
        void DeleteCollectionProductAttributeValuesByCollectionId(string collectionId, int targetWebId);
        void DeleteCollectionProductAttributeValuesByCollectionAndProductId(string collectionId, string productId, int targetWebId);
        void DeleteCollectionProductAttributeValuesByCollectionAndAttributeId(string collectionId, string productId, int attributeId, int targetWebId);
        void DeleteCollectionProductAttributeValuesByCollectionProductIdAndAttributeId(int collectionProductId, int attributeId);
        void DeleteCollectionProductsByCollectionId(string collectionId, int targetWebId);
        void DeleteCollectionProductsByCollectionAndProductId(string collectionId, string productId, int targetWebId);
        void DeleteCollectionAttributeValueByCollectionId(string collectionId, int targetWebId);
        void DeleteCollectionAttributeByCollectionId(string collectionId, int targetWebId);
        void DeleteVariableByCollectionId(string collectionId, int targetWebId);
        void DeleteCollectionById(string collectionId, int targetWebId);
        List<AttributeModel> GetAttributesById(int attributeId);
        List<AttributeModel> GetAttributesByCollectionId(string collectionId, int targetWebId);
        bool IsUsedAttributeInAnotherWeb(int targetWeb, AttributeModel attribute);
        bool IsUsedAttributeValueInAnotherWeb(int targetWeb, AttributeValueModel attributeValue);
        List<CollectionAttributeValueModel> GetCollectionAttributeValuesByCollectionAttributeId(int collectionAttributeId, int targetWebId);
        bool CollectionAttributeValueExists(int collectionAttributeId, int valueId, int targetWebId);
        void UpdateCollection(string collectionId, CollectionModel collection, int targetWebId);
        void DeleteCollectionAttributeValuesByCollectionAndAttributeId(string collectionId, int attributeId, int targetWebId);
        void DeleteCollectionAttributeValuesByValueId(int collectionAttributeId, int valueId, int targetWebId);
        void DeleteCollectionAttributesByCollectionAndAttributeId(string collectionId, int attributeId, int targetWebId);
        List<CollectionAttributeModel> GetCollectionAttributesByCollectionAndAttributeId(string collectionId, int attributeId, int targetWebId);
        bool CollectionAttributeExists(string collectionId, int attributeId, int targetWebId);
        int CreateCollectionAttribute(CollectionAttributeModel collectionAttribute);
        void CreateCollectionAttributeValue(CollectionAttributeValueModel collectionAttributeValue);
        string CreateCollection(CollectionModel collection);
        bool CollectionProductAttributeValueExists(string collectionId, int attributeValueId, int targetWebId);
        bool CollectionProductExists(string collectionId, int attributeId, int targetWebId);
        bool CollectionNameExists(string name, string collectionId, int targetWeb);
        List<Product> GetProductsNotInCollectionBySearch(string SearchProductTerm);
        List<Product> GetCollectionProductsByCollectionId(string collectionId, int targetWebId);
        List<int> GetCollectionProductIdsByCollectionAndProductId(string collectionId, int productId, int targetWebId);
        List<string> GetProductIdsByCollectionId(string collectionId, int targetWebId);
        int GetCountOfCollectionProductsByCollectionId(string collectionId, int targetWebId);
        int GetCountOfUnMappedCollectionProductsByCollectionId(string collectionId, int targetWebId);
        List<string> GetVariableWebIds(int targetWebId);
        List<string> GetVariableWebIdsByCollectionId(string collectionId, int targetWebId);
        List<string> GetMappedCollectionProductWebIdsByCollectionId(string collectionId, int targetWebId);
        bool VariableExists(string collectionId, string variableWebId, int targetWebId);
        int CreateVariable(VariableModel variable);
        void UpdateCollectionProductByProductId(CollectionProductModel collectionProduct, string productId, int targetWebId);
        List<int> GetSelectedProductAttributeValueId(string collectionId, string productId, int attributeId, int attributeValueId, int targetWebId);
        List<int> GetCollectionProductsByCollectionAndProductId(string collectionId, string productId, int targetWebId);
        int CreateCollectionProduct(CollectionProductModel collectionProduct);
        void UpdateCollectionProductById(int collectionProductId, CollectionProductModel collectionProduct);
        void CreateCollectionProductAttributeValue(CollectionProductAttributeValueModel collectionProductAttributeValue);
        List<AttributeValueMap> GetAttributeValueMapsByCollectionAndProductId(string collectionId, string productId, int targetWebId);
        List<VariableModel> GetMappedVariables(int targetWebId);
        List<int> GetTargetWebIdsInProductMap();
        void DeleteProductMapByTargetWebId(int targetWebId);
        List<int> GetTargetWebIdsInCategoryMap();
        void DeleteCategoryMapByTargetWebId(int targetWebId);
        List<int> GetTargetWebIdsInInvoiceMap();
        void DeleteInvoiceMapByTargetWebId(int targetWebId);
        List<int> GetTargetWebIdsInCustomerMap();
        void DeleteCustomerMapByTargetWebId(int targetWebId);
        List<int> GetTargetWebIdsInPaymentMethodMap();
        void DeletePaymentMethodMapByTargetWebId(int targetWebId);
        List<int> GetTargetWebIdsInCollection();
        void DeleteRowsFromCollectionTablesByTargetWebId(int targetWebId);
        List<AttributeModel> GetAttributesBySearch(string searchTerm);
        bool CollectionExists(string name, List<string> ignoreNames = null);
        List<int> GetCollectionProductIds(int targetWebId);
        List<CollectionModel> GetCollectionsByIds(IEnumerable<string> ids, int targetWebId);
        List<CollectionModel> GetUnMappedCollectionsByIds(IEnumerable<string> ids, int targetWebId);
        List<CollectionModel> GetUnMappedCollections(int targetWebId);
        List<CollectionModel> GetMappedCollections(int targetWebId);
        List<CollectionModel> GetMappedCollectionsByIds(IEnumerable<string> ids, int targetWebId);
        List<CollectionModel> GetCollectionsBySearch(string searchTerm, int targetWebId, int pageNumber, int pageSize);
        List<PersonCategory> GetPersonCategoriesBySearch(string searchTerm, int targetWebId);
        #endregion


        #endregion

        #region Category

        /// <summary>
        /// Retrieves category by id.
        /// </summary>
        /// <param name="id">
        /// The ID of the category to retrieve.
        /// </param>
        /// <returns></returns>
        Category GetCategoryById(string id);
        
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
        /// Create category map by id, webId and targetWeb.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="webId"></param>
        /// <param name="targetWeb"></param>
        /// <param name="category"></param>
        void UpdateCategoryMap(string id, string webId, int targetWeb, Category category);

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
        /// Retrieve categories that are not mapped to other categories.
        /// </summary>
        /// <returns>
        /// A list of categories that are not mapped to other categories.
        /// </returns>
        IEnumerable<Category> GetUnMappedCategories(int targetWeb);

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
        
        int GetTotalCategoriesCount(string searchInput, int targetWeb, bool IsSuperGroup = false);

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

        int GetTotalMappedCategoriesCount(string searchInput, int targetWeb, bool IsSuperGroup = false);
        
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
        
        int GetTotalUnMappedCategoriesCount(string searchInput, int targetWeb, bool IsSuperGroup = false);

        /// <summary>
        /// Retrieves all categories that require updates on a specified website.
        /// </summary>
        /// <returns>
        /// A list of categories that need to be updated on the specified web platform.
        /// </returns>
        IEnumerable<Category> GetCategoriesNeedToUpdate(int targetWeb);

        /// <summary>
        /// Retrieve categories filtered by list of ids.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        IEnumerable<Category> GetCategoriesByIds(int targetWeb, IEnumerable<string> ids);
        
        /// <summary>
        /// Retrieves all categories from the database. filtered by  web id.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering categories.
        /// </param>
        /// <param name="webId">
        /// The web id to filter categories.
        /// </param>
        /// <returns></returns>
        IEnumerable<Category> GetCategoriesByWebId(int targetWeb, string webId);

        void SetProductCategoriesUpdateStatus(int targetWeb, bool updateRequired);

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
        
        #region Customers

        /// <summary>
        /// Retrieve customers filtered by search input.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering customers. If searchInput is null or empty, all customers are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of customers per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering customers.
        /// </param>
        /// <returns>
        /// Returns a paginated list of customers that match the search term.
        /// </returns>
        IEnumerable<Customer> GetCustomersBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);
        
        Customer GetCustomerByWebId(string webId, int targetWeb);
        
        /// <summary>
        /// Retrieves the number of customers that match a search term on a specified web platform.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering customers.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering customers.
        /// </param>
        /// <returns></returns>
        int GetTotalCustomersCount(string searchInput, int targetWeb);
        
        /// <summary>
        /// Retrieves mapped customers from the database.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering customers.
        /// </param>
        /// <returns></returns>
        IEnumerable<Customer> GetMappedCustomers(int targetWeb);
        
        /// <summary>
        /// Retrieves customers that are mapped to other customers.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering mapped customers. If searchInput is null or empty, all customers are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of customers per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering mapped customers.
        /// </param>
        /// <returns></returns>
        IEnumerable<Customer> GetMappedCustomersBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);
        
        /// <summary>
        /// Retrieves the number of customers that are mapped to other customers on a specified web platform.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering mapped customers.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering mapped customers.
        /// </param>
        /// <returns></returns>
        int GetTotalMappedCustomersCount(string searchInput, int targetWeb);
        
        /// <summary>
        /// Retrieves customers that are not mapped to other customers.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering unmapped customers. If searchInput is null or empty, all customers are returned.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of customers per page.
        /// </param>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering unmapped customers.
        /// </param>
        /// <returns></returns>
        IEnumerable<Customer> GetUnMappedCustomersBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);
        
        /// <summary>
        /// Retrieves the number of customers that are not mapped to other customers on a specified web platform.
        /// </summary>
        /// <param name="searchInput">
        /// The search term for filtering unmapped customers.
        /// </param>
        /// <returns></returns>
        int GetTotalUnMappedCustomersCount(string searchInput, int targetWeb);
        
        /// <summary>
        /// Creates a mapping between a customer and a corresponding web representation.
        /// </summary>
        /// <param name="customer">
        /// The customer to be mapped, including the ID, WebId, and TargetWeb values.
        /// </param>
        void CreateCustomerMap (Customer customer);
        
        
        /// <summary>
        /// Deletes a mapping that links a customer to its web representation.
        /// </summary>
        /// <param name="customer">
        /// The customer whose ID, WebId, and TargetWeb are used to identify and delete the mapping.
        /// </param>
        void DeleteCustomerMap(Customer customer);


        /// <summary>
        /// Retrieve products filtered by list of ids.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering products.
        /// </param>
        /// <param name="ids">
        /// The list of ids to filter products.
        /// </param>
        /// <returns></returns>
        IEnumerable<Customer> GetCustomersByIds(int targetWeb, IEnumerable<string> ids);
        
        /// <summary>
        /// Retrieves customers that are not mapped to other customers of webSite.
        /// </summary>
        /// <returns>
        /// A list of customer that are not mapped to other customers of webSite.
        /// </returns>
        /// <param name="targetWeb">
        /// Website id that should be used to filter customers. and then filter customers that are
        /// not mapped to other customers of webSite.
        /// </param>
        IEnumerable<Customer> GetUnMappedCustomers(int targetWeb);
        
        /// <summary>
        /// Creates a new customer in the customer table and generates a mapping to its web representation.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        Customer CreateCustomer(Customer customer);
        #endregion
        
        #region Invoices
        
        /// <summary>
        /// Retrieves all invoices from the database. filtered by target web.
        /// </summary>
        /// <param name="targetWeb">
        /// The ID of the target web platform for filtering invoices.
        /// </param>
        /// <returns></returns>
        IEnumerable<Invoice> GetMappedInvoices(int targetWeb, List<InvoiceType> invoiceType = null);

        /// <summary>
        /// Retrieves all invoices from the database.
        /// </summary>
        /// <param name="targetWeb"></param>
        /// <param name="searchInput">
        /// The search term for filtering invoices. If searchInput is null or empty, all invoices are returned.
        /// This parameter is used to filter invoices by invoice code.
        /// </param>
        /// <param name="pageNumber">
        /// The page number to retrieve.
        /// </param>
        /// <param name="pageSize">
        /// The number of invoices per page.
        /// </param>
        /// <param name="startDate">
        /// The start date to filter invoices. if startDate is null, all invoices that are created before endDate are returned.
        /// </param>
        /// <param name="endDate">
        /// The end date to filter invoices. if endDate is null, all invoices that are created after startDate are returned.
        /// </param>
        /// <returns>
        /// Returns a paginated list of invoices that match the search term, start date and end date.
        /// </returns>
        IEnumerable<Invoice> GetMappedInvoicesBySearch(
            int targetWeb,
            string searchInput,
            int pageNumber,
            int pageSize,
            DateTime startDate,
            DateTime endDate,
            List<InvoiceType> invoiceType = null
            );
        
        /// <summary>
        /// Create SellInvoice.
        /// </summary>
        /// <param name="sellInvoice">
        /// The preInvoice to be created.
        /// </param>
        /// <returns>
        /// The newly created preInvoice.
        /// </returns>
        SellInvoice CreateSellInvoice(SellInvoice sellInvoice);

        /// <summary>
        /// Create proforma preInvoice.
        /// </summary>
        /// <param name="proformaPreInvoice">
        /// The proforma preInvoice to be created.
        /// </param>
        /// <returns>
        /// The newly created proforma preInvoice.
        /// </returns>
        PreInvoice CreateProformaInvoice(PreInvoice proformaPreInvoice);
        
        /// <summary>
        /// Delete sellInvoice map.
        /// </summary>
        /// <param name="invoice">
        /// The preInvoice whose ID, WebId, and TargetWeb are used to identify and delete the mapping.
        /// </param>
        void DeleteInvoiceMap(Invoice invoice);

        List<string> GetOrderWebIds(int targetWeb);
        
        #endregion

        #region PaymentMethods

        PaymentMethod CreatePaymentMethodMap(PaymentMethod paymentMethod);
        
        IEnumerable<PaymentMethod> GetMappedPaymentMethods(int targetWeb);
        
        void DeletePaymentMethodMap(PaymentMethod paymentMethod);
        
        IEnumerable<PaymentMethod> GetPaymentMethodsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);
        int GetTotalPaymentMethodsCount(string searchInput, int targetWeb);
        
        IEnumerable<PaymentMethod> GetMappedPaymentMethodsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);
        int GetTotalMappedPaymentMethodsCount(string searchInput, int targetWeb);
        
        IEnumerable<PaymentMethod> GetUnMappedPaymentMethodsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);
        int GetTotalUnMappedPaymentMethodsCount(string searchInput, int targetWeb);
        IEnumerable<FundModel> GetFundsBySearch(string searchInput, int pageNumber, int pageSize, int targetWeb);

        #endregion

        #region Users

        IEnumerable<User> GetUsersBySearch(string searchInput);
        IEnumerable<Visitor> GetVisitorsBySearch(string searchInput);

        #endregion

        #region Other Methods

        IEnumerable<TModel> ExecuteRawSqlTemporary<TModel>(string query);
        void DatabasePrerequisites();

        #endregion
    }
}
