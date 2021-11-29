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
        /// Getting a list of all orders.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        /// <summary>
        /// Getting an order with orderID.
        /// </summary>
        /// <param name="oid"></param>
        /// <returns></returns>
        [HttpGet("{oid}")]
        public Order GetOrderByID(int oid)
        {
            return _orderService.GetOrderByID(oid);
        }
        /// <summary>
        /// Creating an order. Remember that orderID cannot be in the body.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public Order CreateOrder([FromBody] Order order)
        {
            return _orderService.CreateOrder(order);
        }      
        /// <summary>
        /// Updating an order.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPut]
        public Order UpdateOrder([FromBody] Order order)
        {
            return _orderService.UpdateOrder(order);
        }    
        /// <summary>
        /// Deleting an order with an orderID.
        /// </summary>
        /// <param name="oid"></param>
        [HttpDelete("{oid}")]
        public void DeleteOrder(int oid)
        {
            _orderService.DeleteOrder(oid);
        }
    }
}