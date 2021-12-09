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
            if (_orderRepository.GetOrderByID(oid)!=null)
            {
                _orderRepository.DeleteOrder(oid);
            }
            throw new Exception("Order is already deleted or never existed.");
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderByID(int oid)
        {
            var tempOrder = _orderRepository.GetOrderByID(oid);
            if (tempOrder==null)
            {
                throw new Exception("There is no order found.");
            }
            else
            {
                return tempOrder;
            }
             
        }

        public Order UpdateOrder(Order order)
        {
            if (_orderRepository.GetOrderByID(order.orderID)!=null)
            {
                return _orderRepository.UpdateOrder(order);
            }
            throw new Exception("There is no order with this orderID");
        }
        
    }
}