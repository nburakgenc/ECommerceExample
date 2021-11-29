using ECommerce.DataAccess.Abstract;
using ECommerce.Entities;
using ECommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var productDbContext = new ECommerceDbContext())
            {
                productDbContext.Products.Add(product);
                productDbContext.SaveChanges();         //REVIEW THIS AREA !!!!!!!!!!
                return product;
            }

        }

        public void DeleteProduct(int pid)
        {

            using (var productDbContext = new ECommerceDbContext())
            {
                var deletedProduct = GetProductByID(pid);
                productDbContext.Products.Remove(deletedProduct);
                productDbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var productDbContext = new ECommerceDbContext())
            {
                return productDbContext.Products.ToList();
            }
        }

        public Product GetProductByID(int pid)
        {
            using (var productDbContext = new ECommerceDbContext())
            {
                return productDbContext.Products.Find(pid);
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var productDbContext = new ECommerceDbContext())
            {
                productDbContext.Products.Update(product);
                productDbContext.SaveChanges();
                return product;
            }
        }
    }
}
