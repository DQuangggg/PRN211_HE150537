using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailsList()
        {
            var orders = new List<OrderDetail>();
            try
            {
                using var context = new Ass2PRNContext();
                orders = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;

        }

        public OrderDetail GetOrderDetailsByID(int orderID)
        {
            OrderDetail orderDetail = null;
            try
            {
                using var context = new Ass2PRNContext();
                orderDetail = context.OrderDetails.SingleOrDefault(q => q.OrderId == orderID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        public void AddOrder(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail order1 = GetOrderDetailsByID(orderDetail.OrderId);
                if (order1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.OrderDetails.Add(orderDetail);
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

        public void UpDate(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail order1 = GetOrderDetailsByID(orderDetail.OrderId);
                if (order1 == null)
                {
                    using var context = new Ass2PRNContext();
                    context.OrderDetails.Update(orderDetail);
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
                OrderDetail orderDetail = GetOrderDetailsByID(orderID);
                if (orderDetail != null)
                {
                    using var context = new Ass2PRNContext();
                    context.OrderDetails.Remove(orderDetail);
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
