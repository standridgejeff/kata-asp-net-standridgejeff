using System;
using System.Collections.Generic;

namespace ITB.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        int GetProduct(int Id);
        int DeleteProduct(int Id);
        int UpdateProduct(Product prod);
        int AddProduct(Product prod);
    }
}
