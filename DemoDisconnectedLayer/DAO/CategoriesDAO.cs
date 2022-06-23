using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDisconnectedLayer.Model;
using System.Data;

namespace DemoDisconnectedLayer.DAO
{
    class CategoriesDAO
    {
        public static List<Categories> GetAllCategories()
        {
            string sql = "select CategoryID,CategoryName from Categories";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Categories> listCategories = new List<Categories>();
            foreach (DataRow dr in dt.Rows)
            {
                listCategories.Add(new Categories(
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    ));
            }
            return listCategories;

        }
    }
}