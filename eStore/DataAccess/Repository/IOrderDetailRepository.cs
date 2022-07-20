using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataAccess;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailsByID(int orderID);
        void AddOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderID);
        void UpdateOrderDetail(OrderDetail orderDetail);

    }
}
