﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Supermarket_mvp_v2.Models;

namespace Supermarket_mvp_v2._Repositories
{
    internal class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        } // Fin del constructor

        public void Add(ProductsModels productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products (Product_Name, Product_Price, Product_Stock, Category_Id) VALUES (@name, @price, @stock, @categoryId)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = productModel.CategoryId;
                command.ExecuteNonQuery();
            }
        } // Fin del método Add

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Products WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        } // Fin del método Delete

        public void Edit(ProductsModels productModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products
                                        SET Product_Name = @name,
                                            Product_Price = @price,
                                            Product_Stock = @stock,
                                            Category_Id = @categoryId
                                        WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = productModel.Name;
                command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = productModel.Price;
                command.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = productModel.Stock;
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = productModel.CategoryId;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = productModel.Id;
                command.ExecuteNonQuery();
            }
        } // Fin del método Edit

        public IEnumerable<ProductsModels> GetAll()
        {
            var productList = new List<ProductsModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductsModels
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Price = (decimal)reader["Product_Price"],
                            Stock = (int)reader["Product_Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        } // Fin del método GetAll

        public ProductsModels GetById(int id)
        {
            ProductsModels productModel = null;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products WHERE Product_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        productModel = new ProductsModels
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Price = (decimal)reader["Product_Price"],
                            Stock = (int)reader["Product_Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                    }
                }
            }
            return productModel;
        } // Fin del método GetById

        public IEnumerable<ProductsModels> GetByCategory(int categoryId)
        {
            var productList = new List<ProductsModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products WHERE Category_Id = @categoryId ORDER BY Product_Id DESC";
                command.Parameters.AddWithValue("@categoryId", SqlDbType.Int).Value = categoryId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductsModels
                        {
                            Id = (int)reader["Product_Id"],
                            Name = reader["Product_Name"].ToString(),
                            Price = (decimal)reader["Product_Price"],
                            Stock = (int)reader["Product_Stock"],
                            CategoryId = (int)reader["Category_Id"]
                        };
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        } // Fin del método GetByCategory
    } // Fin de la clase
}
