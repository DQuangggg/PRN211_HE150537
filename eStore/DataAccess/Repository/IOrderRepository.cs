using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderByID(int orderID);
        void AddOrder(Order order);
        void DeleteOrder(int orderID);
        void UpdateOrder(Order order);

    }
}

