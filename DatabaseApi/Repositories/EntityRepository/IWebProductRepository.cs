using DatabaseApi.Models;
using DatabaseApi.Repositories.EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IWebProductRepository : IEntityBaseRepository<WebProduct>
    {
        void DeleteProductByExcludingList(IEnumerable<int> Ids, int targetWeb);
        void DeleteProductByWebIds(IEnumerable<int> Ids, int targetWeb);
        void CreateProducts(IEnumerable<WebProduct> productsToBeCreated, int targetWeb);
        void UpdateProducts(IEnumerable<WebProduct> webProducts, int targetWeb);
    }
}
