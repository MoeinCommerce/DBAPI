using DatabaseApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IProductRepository
    {
        void Add(Product entity, List<ProductBarcode> productBarcodes = null);
        void AddRange(IEnumerable<Product> entities);
        void Delete(Product entity);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void SetInitialStock(int productId, int wareHouseId, float stock);
        void Update(Product entity);
        IEnumerable<ProductBarcode> GetProductBarcodes(int productId);
        int GetProductStock(int productId, int warehouseId = 0);
        List<ProductStock> GetAllProductStock(int warehouseId = 0);
    }
}
