using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseApi.Models.WebModels.Entities;

namespace DatabaseApi.Repositories
{
    public interface IWebProductRepository : IRepository<WebProduct>    
    {
        void DeleteProductByExcludingList(IEnumerable<int> ids, int targetWeb);
        void DeleteProductByWooIds(IEnumerable<int> ids, int targetWeb);
        void CreateProducts(IEnumerable<WebProduct> productsToBeCreated, int targetWeb);
        void UpdateProducts(IEnumerable<WebProduct> webProducts, int targetWeb);
        List<WebProduct> PaginatedSearchWebProducts(string searchInput, int pageNumber, int pageSize, int targetWeb);
        List<WebProduct> PaginatedSearchWebProductsFilteredByIds(string searchInput, int pageNumber, int pageSize, int targetWeb, List<int> filteredIds);
        int GetTotalItemsCount(string searchInput, int targetWeb);
    }
}
