using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);
        public void DeleteOrder(int orderID) => OrderDAO.Instance.Remove(orderID);

        public Order GetOrderByID(int orderID) => OrderDAO.Instance.GetOrderByID(orderID);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpDate(order);

    }
}
