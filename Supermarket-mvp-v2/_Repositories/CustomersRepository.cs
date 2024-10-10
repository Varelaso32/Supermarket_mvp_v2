using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Supermarket_mvp_v2.Models;

namespace Supermarket_mvp_v2._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomersModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customers (Document_Number, First_Name, Last_Name, Address, Birth_Date, Phone_Number, Email) 
                                        VALUES (@documentNumber, @firstName, @lastName, @address, @birthDate, @phoneNumber, @email)";
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = customerModel.DocumentNumber;
                command.Parameters.AddWithValue("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.AddWithValue("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.AddWithValue("@birthDate", SqlDbType.NVarChar).Value = customerModel.BirthDate;
                command.Parameters.AddWithValue("@phoneNumber", SqlDbType.NVarChar).Value = customerModel.PhoneNumber;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomersModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                        SET Document_Number = @documentNumber,
                                            First_Name = @firstName,
                                            Last_Name = @lastName,
                                            Address = @address,
                                            Birth_Date = @birthDate,
                                            Phone_Number = @phoneNumber,
                                            Email = @email
                                        WHERE Customer_Id = @id";
                command.Parameters.AddWithValue("@documentNumber", SqlDbType.NVarChar).Value = customerModel.DocumentNumber;
                command.Parameters.AddWithValue("@firstName", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.AddWithValue("@lastName", SqlDbType.NVarChar).Value = customerModel.LastName;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.AddWithValue("@birthDate", SqlDbType.NVarChar).Value = customerModel.BirthDate;
                command.Parameters.AddWithValue("@phoneNumber", SqlDbType.NVarChar).Value = customerModel.PhoneNumber;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = customerModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE Customer_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customerList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customer_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomersModel
                        {
                            Id = (int)reader["Customer_Id"],
                            DocumentNumber = reader["Document_Number"].ToString(),
                            FirstName = reader["First_Name"].ToString(),
                            LastName = reader["Last_Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            BirthDate = reader["Birth_Date"].ToString(),
                            PhoneNumber = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customerList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers 
                                        WHERE First_Name LIKE @value + '%' 
                                        OR Last_Name LIKE @value + '%'
                                        OR Document_Number LIKE @value + '%'
                                        ORDER BY Customer_Id DESC";
                command.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomersModel
                        {
                            Id = (int)reader["Customer_Id"],
                            DocumentNumber = reader["Document_Number"].ToString(),
                            FirstName = reader["First_Name"].ToString(),
                            LastName = reader["Last_Name"].ToString(),
                            Address = reader["Address"].ToString(),
                            BirthDate = reader["Birth_Date"].ToString(),
                            PhoneNumber = reader["Phone_Number"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }
    }
}
