using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrichelliGlasses.Domain;

namespace TorrichelliGlasses.Abstractions
{
    public interface IProductService
    {
        bool Create(string name, int brandId,
            int categoryId, string picture, int quantity, decimal price, decimal discount);
        bool Update(int productId, string name, int brandId, int categoryId, string picture, int quantity, decimal price, decimal discount);

        List<Product> GetProduct();
        Product GetProductById(int productId);
        bool RemoveById(int productId);
        List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandName);
    }
}
