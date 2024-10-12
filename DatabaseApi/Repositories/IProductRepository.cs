using DatabaseApi.Models;
using DatabaseApi.Models.McModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Repositories
{
    public interface IProductRepository
    {
        int Add(Product entity, List<ProductBarcode> productBarcodes = null);
        void AddRange(IEnumerable<Product> entities);
        void Delete(int productId);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        IEnumerable<Product> GetProductsByIds(IEnumerable<int> productIds);
        void SetInitialStock(int productId, int wareHouseId, float stock);
        void Update(Product entity);
        IEnumerable<ProductBarcode> GetProductBarcodes(int productId);
        int GetProductStock(int productId, int warehouseId = 0);
        List<ProductStock> GetAllProductStock(int warehouseId = 0);
        List<McProduct> GetMcProducts();
    }
}
