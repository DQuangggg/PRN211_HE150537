using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DemoDisconnectedLayer.DAO
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionStr = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=MyStore;";
            return new SqlConnection(ConnectionStr);
        }
        public static DataTable GetDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
