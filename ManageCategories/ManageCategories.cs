using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Data;

namespace ManageCategories
{
    public class ManageCategories
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=MyStore;";
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>() ;
            connection = new SqlConnection(ConnectionString) ;
            string sql = "Select CategoryID , CategoryName from Categories";
            command = new SqlCommand(sql, connection) ;
            try { 
                connection.Open();
                SqlDataAdapter reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.Ha)
            }

        }


    }

    public record Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
