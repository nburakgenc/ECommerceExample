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
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;
        public OrdersController()
        {
            _orderService = new OrderService();
        }
        /// <summary>
        /// Get All Orders as a list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        /// <summary>
        /// Get an Order with order ID
        /// </summary>
        /// <param name="oid"></param>
        /// <returns></returns>
        [HttpGet("{oid}")]
        public Order GetOrderByID(int oid)
        {
            return _orderService.GetOrderByID(oid);
        }
        /// <summary>
        /// Create an Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public Order CreateOrder([FromBody] Order order)
        {
            return _orderService.CreateOrder(order);
        }
        /// <summary>
        /// Update an Order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut]
        public Order UpdateOrder([FromBody] Order order)
        {
            return _orderService.UpdateOrder(order);
        }
        /// <summary>
        /// Delete an Order with order ID
        /// </summary>
        /// <param name="oid"></param>
        [HttpDelete("{oid}")]
        public void DeleteOrder(int oid)
        {
            _orderService.DeleteOrder(oid);
        }
    }
}