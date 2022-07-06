using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace ManageCategories1
{
    public record Category
    {
        public int MemberID { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
    }
    public class ManageCategories
    {
        SqlConnection connection;
        SqlCommand command;
        string ConnectionString = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=Ass2PRN;";
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            connection = new SqlConnection(ConnectionString);
            string SQL = "SELECT  MemberID, Email, CompanyName, City, Country, Password FROM Member";
            command = new SqlCommand(SQL, connection);
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
                            MemberID = reader.GetInt32("MemberID"),
                            Email = reader.GetString("Email"),
                            CompanyName = reader.GetString("CompanyName"),
                            Country = reader.GetString("Country"),
                            City = reader.GetString("City"),
                            Password = reader.GetString("Password"),
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

        public void InsertCategory(Category category)
        {
            connection = new SqlConnection(ConnectionString);
            command = new SqlCommand("Insert Member values(@Email, @CompanyName, @City, @Country, @Password)", connection);
            command.Parameters.AddWithValue("@Email", category.Email);
            command.Parameters.AddWithValue("@CompanyName", category.CompanyName);
            command.Parameters.AddWithValue("@City", category.City);
            command.Parameters.AddWithValue("@Country", category.Country);
            command.Parameters.AddWithValue("@Password", category.Password);
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
            command = new SqlCommand("Update Member set Email =  @Email ,CompanyName =  @CompanyName ,City =  @City ,Country =  @Country ,Password =  @Password where MemberID = @MemberID", connection);
            command.Parameters.AddWithValue("@MemberID", category.MemberID);
            command.Parameters.AddWithValue("@Email", category.Email);
            command.Parameters.AddWithValue("@CompanyName", category.CompanyName);
            command.Parameters.AddWithValue("@City", category.City);
            command.Parameters.AddWithValue("@Country", category.Country);
            command.Parameters.AddWithValue("@Password", category.Password);
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
            command = new SqlCommand("Delete Member where MemberID = @MemberID", connection);
            command.Parameters.AddWithValue("@MemberID", category.MemberID);
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
