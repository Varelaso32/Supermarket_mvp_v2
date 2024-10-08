using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp_v2.Models;
using Supermarketmvp.Models;
using System.Data;

namespace Supermarket_mvp_v2._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {
        public PayModeRepository(string connectionString) 
        {
            this.connectionString = connectionString;
            
        }//Fin de clase

        public void Add(PayModeModel payModeModel)
        {
            throw new NotImplementedException();

        }//Fin de clase

        public void Delete(int id)
        {
            throw new NotImplementedException();

        }//Fin de clase

        public void Edit(PayModeModel payModeModel)
        {
            throw new NotImplementedException();

        }//Fin de clase

        public IEnumerable<PayModeModel> GetAll()
        {
            var payModeList = new List<PayModeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();


                        payModeList.Add(payModeModel);
                    }
                }
            }
            return payModeList;

        }//Fin de clase

        public IEnumerable<PayModeModel> GetByValue(string value)
        {
            var payModeList = new List<PayModeModel>();
            int payModeId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string payModeName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PayMode
                                WHERE Pay_Mode_Id=@id OR Pay_Mode_Name LIKE @name+'%'
                                ORDER BY Pay_Mode_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = payModeId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = payModeName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PayModeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }

            return payModeList;
        }//Fin de clase

    }//Fin de clase
}
