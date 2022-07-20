using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new Ass2PRNContext();
                orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;

        }

        public Order GetOrderByID(int orderID)
        {
            Order order = null;
            try
            {
                using var context = new Ass2PRNContext();
                order = context.Orders.SingleOrDefault(o => o.OrderId == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public void AddOrder(Order order)
        {
            try
            {
                Order order1 = GetOrderByID(order.OrderId);
                if (order1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Order is already exist");
            }
        }

        public void UpDate(Order order)
        {
            try
            {
                Order order1 = GetOrderByID(order.OrderId);
                if (order1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int orderID)
        {
            try
            {
                Order order = GetOrderByID(orderID);
                if (order != null)
                {
                    using var context = new Ass2PRNContext();
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
