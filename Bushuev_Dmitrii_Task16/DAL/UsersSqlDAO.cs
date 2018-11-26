using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class UsersSqlDAO : IUsersDAO
    {
        private string connectionString;

        public UsersSqlDAO()
        {
            connectionString = ConfigurationManager.ConnectionStrings["UsersAndAwards"].ConnectionString;
        }

        public void Add(User newUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddUser";

                // параметры добавлять только так. не строкой!
                command.Parameters.Add(new SqlParameter("@lastname", SqlDbType.NVarChar, 150));
                command.Parameters.Add(new SqlParameter("@firstname", SqlDbType.NVarChar, 150));
                command.Parameters.Add(new SqlParameter("@bdate", SqlDbType.DateTime2));

                // обязательно вызывать при добавлении параметров
                command.Prepare();

                command.Parameters[0].Value = newUser.LastName;
                command.Parameters[1].Value = newUser.FirstName;
                command.Parameters[2].Value = newUser.BirthDate;

                connection.Open();
                // выполняем ОТКРЫТЬ CONNECTION ЗДЕСЬ
                var result = command.ExecuteNonQuery();
                // закрыть CONNECTION ЗДЕСЬ
            }
        }

        public IEnumerable<User> GetList()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetUsers";

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string lastName = (string)reader["LastName"];
                        string firstName = (string)reader["FirstName"];
                        DateTime birthDate = (DateTime)reader["Birthdate"];


                        var user = (new User()
                        {
                            LastName = lastName,
                            FirstName = firstName,
                            BirthDate = birthDate,
                            Id = id
                        });

                        user.UpdateAwards(GetUsersAwards(user.Id));
                        users.Add(user);

                    }
                }
            }

            return users;
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteUser";

                // параметры добавлять только так. не строкой!
                command.Parameters.Add(new SqlParameter("@userId", SqlDbType.Int));

                // обязательно вызывать при добавлении параметров
                command.Prepare();

                command.Parameters[0].Value = id;

                connection.Open();
                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }

        public void Edit(User userForEdit)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateUser";

                // параметры добавлять только так. не строкой!
                command.Parameters.Add(new SqlParameter("@userdId", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@newLastName", SqlDbType.NVarChar, 150));
                command.Parameters.Add(new SqlParameter("@newFirstName", SqlDbType.NVarChar, 150));
                command.Parameters.Add(new SqlParameter("@newBirthdate", SqlDbType.DateTime2));//ADDWITHVALUE

                // обязательно вызывать при добавлении параметров
                command.Prepare();

                command.Parameters[0].Value = userForEdit.Id;
                command.Parameters[1].Value = userForEdit.LastName;
                command.Parameters[2].Value = userForEdit.FirstName;
                command.Parameters[3].Value = userForEdit.BirthDate;

                connection.Open();
                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }

        private IEnumerable<string> GetUsersAwards(int id)
        {
            List<string> awards = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.CommandText = "GetUsersAwards";

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        awards.Add(reader.GetString(0));
                    }
                }
            }

            return awards;
        }

        public void AddAward(int userId, int awardId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddAwardToUser";

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@AwardId", awardId);

                connection.Open();
                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }

        public void RemoveAward(int userId, int awardId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteAwardFromUser";

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@AwardId", awardId);

                connection.Open();
                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }
    }
}
