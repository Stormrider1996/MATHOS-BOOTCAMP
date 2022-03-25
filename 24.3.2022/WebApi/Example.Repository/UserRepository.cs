using Example.UserModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Repository
{
    public class UserRepository
    {
        public static string conString = "Data Source=ST-03;Initial Catalog=UsersDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        List<User> users = new List<User>();
        public List<User> CatchDatabase()
        {
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users;", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);

                        users.Add(user);
                    }
                   
                }
                 
            }
            return users;
        }
    }
}




