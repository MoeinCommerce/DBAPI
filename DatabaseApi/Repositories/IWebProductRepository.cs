using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IWebProductRepository : IRepository<WebProduct>
    {
        void DeleteProductByExcludingList(IEnumerable<int> Ids, int targetWeb);
        void DeleteProductByWooIds(IEnumerable<int> Ids, int targetWeb);
        void CreateProducts(IEnumerable<WebProduct> productsToBeCreated, int targetWeb);
        void UpdateProducts(IEnumerable<WebProduct> webProducts, int targetWeb);
    }
}
