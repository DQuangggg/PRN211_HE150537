using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDisconnectedLayer.Model;
using System.Data;

namespace DemoDisconnectedLayer.DAO
{
    class ProductDAO
    {
        public static List<Product> GetAllProduct()
        {
            string sql = "select ProductID, ProductName,UnitPrice,UnitsInStock,CategoryID from Products";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Product> products = new List<Product>();
            foreach (DataRow dr in dt.Rows)
            {
                products.Add(new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToInt32(dr["UnitsInStock"]),
                    Convert.ToInt32(dr["CategoryID"])
                    ));
            }
            return products;

        }
    }
}