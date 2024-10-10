using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Supermarket_mvp_v2.Models;

namespace Supermarket_mvp_v2._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoriesModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Category (Name, Description) 
                                        VALUES (@name, @description)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categoryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Category
                                        SET Name = @name,
                                            Description = @description
                                        WHERE Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = categoryModel.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = categoryModel.Description;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = categoryModel.Id;
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
                command.CommandText = "DELETE FROM Category WHERE Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoryList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Category ORDER BY Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoriesModel
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoryList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category 
                                        WHERE Name LIKE @value + '%' 
                                        OR Description LIKE @value + '%'
                                        ORDER BY Id DESC";
                command.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryModel = new CategoriesModel
                        {
                            Id = (int)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        categoryList.Add(categoryModel);
                    }
                }
            }
            return categoryList;
        }
    }
}
