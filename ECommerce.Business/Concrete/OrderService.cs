using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }
        public Order CreateOrder(Order order)
        {
            
            return _orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(int oid)
        {
            _orderRepository.DeleteOrder(oid);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderByID(int oid)
        {
            return _orderRepository.GetOrderByID(oid);
        }

        public Order UpdateOrder(Order order)
        {
            return _orderRepository.UpdateOrder(order);
        }
    }
}