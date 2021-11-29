using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductByID(int pid);
        Product CreateProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(int pid);
    }
}
