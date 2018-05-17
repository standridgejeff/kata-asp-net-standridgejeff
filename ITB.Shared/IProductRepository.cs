using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITB.Shared
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int Id);
        int DeleteProduct(int Id);
        int UpdateProduct(Product prod);
        int AddProduct(Product prod);
    }
}
