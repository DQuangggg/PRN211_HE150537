using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ManageCategories
{
    public record Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
    public class ManageCategories
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=MyStore;";
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(ConnectionString);
            string sql = "Select CategoryID , CategoryName from Catgories";
            command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryID = reader.GetInt32("CategoryID"),
                            CategoryName = reader.GetString("CategoryName"),
                        });

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return categories;
        }

        public void InsertCetegory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Insert Categories values(@CategoryName)", connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            string SQL = "Update Categories set CategoryName=@CategoryName where CategoryID = @CategoryID ";
            command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }


        }
        public void DeleteCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            string SQL = "Delete Categories where CategoryID = @CategoryID";
            command = new SqlCommand(SQL, connection);
            command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
