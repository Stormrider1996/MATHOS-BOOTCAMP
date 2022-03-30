using Example.UserModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Repository
{
    public class UserRepository : IUserRepository
    {
        public static string connectionString = "Data Source=ST-03;Initial Catalog=UsersDB;Integrated Security=True";
        public async Task<List<IUser>> GetUsersAsync()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users;", connection);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                User user = new User();
                List<IUser> users = new List<IUser>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);

                        users.Add(user);
                    }

                }
                connection.Close();
                return users;
            }
        }

        public async Task<List<IUser>> GetUsersByIdAsync(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            using (connection)
            {
                SqlCommand command = new SqlCommand($"Select * FROM Users WHERE Users.Id = {id};", connection);
                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                User user = new User();
                List<IUser> users = new List<IUser>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);

                        users.Add(user);
                    }

                }
                connection.Close();
                return users;
            }
        }
    
        public async Task CreateUserAsync(IUser OneUser)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"INSERT INTO Users (Id,FirstName,LastName) values('{OneUser.Id}','{OneUser.FirstName}','{OneUser.LastName}');", connection);

                await connection.OpenAsync();
                adapter.InsertCommand = command;
                await adapter.InsertCommand.ExecuteNonQueryAsync();

                connection.Close();
            }
        }
        public async Task UpdateUserByIdAsync(IUser OneUser)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"UPDATE Users SET FirstName='{OneUser.FirstName}', LastName='{OneUser.LastName}' WHERE Id = {OneUser.Id};", connection);

                await connection.OpenAsync();
                adapter.UpdateCommand = connection.CreateCommand();
                adapter.UpdateCommand = command;
                await adapter.UpdateCommand.ExecuteNonQueryAsync();

                connection.Close();
            }
        }

        public async Task<Boolean> DeleteUserByIdAsync(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"DELETE Users WHERE Id = {id};", connection);

                await connection.OpenAsync();
                adapter.DeleteCommand = connection.CreateCommand();
                adapter.DeleteCommand = command;
                await adapter.DeleteCommand.ExecuteNonQueryAsync();

                connection.Close();
                return false;
            }
        }
    }
}





