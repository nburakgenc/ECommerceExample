using ECommerce.DataAccess.Abstract;
using ECommerce.Entities;
using ECommerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.DataAccess.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        public Order CreateOrder(Order order)
        {
            using (var orderDbContext = new ECommerceDbContext())
            {
                orderDbContext.Orders.Add(order);
                orderDbContext.SaveChanges();
                return order;
            }
        }

        public void DeleteOrder(int oid)
        {
            using (var orderDbContext = new ECommerceDbContext())
            {
                var deletedOrder = GetOrderByID(oid);
                orderDbContext.Orders.Remove(deletedOrder);
                orderDbContext.SaveChanges();
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var orderDbContext = new ECommerceDbContext())
            {
                return orderDbContext.Orders.ToList();
            }
        }

        public Order GetOrderByID(int oid)
        {
            using (var orderDbContext = new ECommerceDbContext())
            {
                return orderDbContext.Orders.Find(oid);
            }
        }

        public Order UpdateOrder(Order order)
        {
            using (var orderDbContext = new ECommerceDbContext())
            {
                orderDbContext.Orders.Update(order);
                orderDbContext.SaveChanges();
                return order;
            }
        }
    }
}

