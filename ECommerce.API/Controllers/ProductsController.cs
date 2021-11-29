using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController()
        {
            _productService = new ProductService();
        }
        /// <summary>
        /// Get All Products as a list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }
        /// <summary>
        /// Get a Product with product ID
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [HttpGet("{pid}")]
        public Product GetProductByID(int pid)
        {
            return _productService.GetProductByID(pid);
        }
        /// <summary>
        /// Create a Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public Product CreateProduct([FromBody] Product product)
        {
            return _productService.CreateProduct(product);
        }
        /// <summary>
        /// Update a Product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut]
        public Product UpdateProduct([FromBody] Product product)
        {
            return _productService.UpdateProduct(product);
        }
        /// <summary>
        /// Delete a Product with a product ID
        /// </summary>
        /// <param name="pid"></param>
        [HttpDelete("{pid}")]
        public void DeleteProduct(int pid)
        {
            _productService.DeleteProduct(pid);
        }
    }
}