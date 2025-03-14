﻿using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BusinessObject
{
    public record Member
    {
        public int MemberID { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }

    }

        public class MemberObject
        {
            SqlConnection connection;
            SqlCommand command;
            string ConnectionString = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=Ass2PRN;";

            public List<Member> GetMembers()
            {
                List<Member> members = new List<Member>();
                connection = new SqlConnection(ConnectionString);
            string SQL = "SELECT  MemberID, Email, CompanyName, City, Country, Password FROM Member";
            try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                    {
                        while (reader.Read())
                        {
                            members.Add(new Member
                            {
                                MemberID = reader.GetInt32("MemberID"),
                                Email = reader.GetString("Email"),
                                CompanyName = reader.GetString("CompanyName"),
                                Country = reader.GetString("Country"),
                                City = reader.GetString("City"),
                                Password = reader.GetString("Password")
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
                return members;
            }

            public void InsertMember(Member member)
            {
                connection = new SqlConnection(ConnectionString);
                command = new SqlCommand("Insert Member values(@Email, @CompanyName, @City, @Country, @Password)", connection);
                command.Parameters.AddWithValue("@Emai", member.Email);
                command.Parameters.AddWithValue("@CompanyName", member.CompanyName);
                command.Parameters.AddWithValue("@City", member.City);
                command.Parameters.AddWithValue("@Country", member.Country);
                command.Parameters.AddWithValue("@Password", member.Password);
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


            public void UpdateMember(Member member)
            {
                connection = new SqlConnection(ConnectionString);
                command = new SqlCommand("Update Member set Email =  @Email ,CompanyName =  @CompanyName ,City =  @City ,Country =  @Country ,Password =  @Password where MemberID = @MemberID", connection);
                command.Parameters.AddWithValue("@MemberID", member.MemberID);
                command.Parameters.AddWithValue("@Emai", member.Email);
                command.Parameters.AddWithValue("@CompanyName", member.CompanyName);
                command.Parameters.AddWithValue("@City", member.City);
                command.Parameters.AddWithValue("@Country", member.Country);
                command.Parameters.AddWithValue("@Password", member.Password);
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

            public void DeleteMember(Member member)
            {
                connection = new SqlConnection(ConnectionString);
                command = new SqlCommand("Delete Member where MemberID = @MemberID", connection);
                command.Parameters.AddWithValue("@MemberID", member.MemberID);

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


