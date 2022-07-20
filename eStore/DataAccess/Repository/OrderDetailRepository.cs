using DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.AddOrder(orderDetail);

        public void DeleteOrderDetail(int orderID) => OrderDetailDAO.Instance.Remove(orderID);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailsList();

        public OrderDetail GetOrderDetailsByID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailsByID(orderID);


        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpDate(orderDetail);
    }
}
