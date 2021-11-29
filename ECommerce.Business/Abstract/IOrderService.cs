using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderByID(int oid);
        Order CreateOrder(Order order);
        Order UpdateOrder(Order order);
        void DeleteOrder(int oid);
    }
}
