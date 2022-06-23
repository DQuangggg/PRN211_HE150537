using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDisconnectedLayer.Model
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int CategoryID { get; set; }

        public Product(int productId, string productName, double unitPrice, int unitInStock, int categoryID)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitInStock = unitInStock;
            CategoryID = categoryID;
        }
    }
}
