using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class UserSQLDao : IUserDao
    {
        private string _connectionString;

        public UserSQLDao()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(User user)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterName = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(parameterName);

                SqlParameter parameterurl = new SqlParameter("@url", user.url);
                command.Parameters.Add(parameterurl);

                SqlParameter parameterDateOfBirth = new SqlParameter("@DateOfBirth", user.DateOfBirth);
                command.Parameters.Add(parameterDateOfBirth);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
        }

        public bool Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
                return true;
            }
        }

        public IEnumerable<User> GetAll()
        {
            var result = new List<User>();
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM [dbo].[User]";
                command.CommandType = CommandType.Text;
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(
                        new User
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            url = (string)reader["url"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                        });
                }
            }

            return result;
        }

        public User GetById(int id)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetUserById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                User result = new User();
                while (reader.Read())
                {
                    result =
                        new User
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            url = (string)reader["url"],
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                        };
                }

                return result;
            }
        }

        public void SaveUserStorage()
        {
            throw new NotImplementedException();
        }
    }
}
