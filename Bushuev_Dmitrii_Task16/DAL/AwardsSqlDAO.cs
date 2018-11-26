using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AwardsSqlDAO : IAwardsDAO
    {
        private string connectionString;

        public AwardsSqlDAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["UsersAndAwards"].ConnectionString;
        }

        public void Edit(Award awardForEdit)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateAward";

                // параметры добавлять только так. не строкой!
                command.Parameters.Add(new SqlParameter("@awardId", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@newTitle", SqlDbType.NVarChar, 150));
                command.Parameters.Add(new SqlParameter("@newDescription", SqlDbType.NVarChar, 150));//ADDWITHVALUE

                // обязательно вызывать при добавлении параметров
                command.Prepare();

                command.Parameters[0].Value = awardForEdit.Id;
                command.Parameters[1].Value = awardForEdit.Title;
                command.Parameters[2].Value = awardForEdit.Description;

                connection.Open();
                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteAward";

                // параметры добавлять только так. не строкой!
                command.Parameters.Add(new SqlParameter("@awardId", SqlDbType.Int));

                // обязательно вызывать при добавлении параметров
                command.Prepare();

                command.Parameters[0].Value = id;

                connection.Open();
                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }

        public void Add(Award newAward)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddAward";

                // параметры добавлять только так. не строкой!
                command.Parameters.AddWithValue("@name", newAward.Title);
                command.Parameters.AddWithValue("@description", newAward.Description);//ADDWITHVALUE

                connection.Open();
                // выполняем ОТКРЫТЬ CONNECTION ЗДЕСЬ
                var result = command.ExecuteNonQuery();
                // закрыть CONNECTION ЗДЕСЬ
            }
        }

        public IEnumerable<Award> GetList()
        {
            List<Award> awards = new List<Award>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetRewards";

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string title = (string)reader["Title"];
                        string description = (string)reader["Description"];


                        awards.Add(new Award()
                        {
                            Title = title,
                            Description = description,
                            Id = id
                        });
                    }
                }
            }
            return awards;
        }
    }
}
