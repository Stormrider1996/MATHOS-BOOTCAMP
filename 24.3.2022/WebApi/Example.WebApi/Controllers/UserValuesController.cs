using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example.WebApi.Controllers
{
    public class UserValuesController : ApiController
    {

        [HttpGet]
        [Route("api/GetUsers")]
        public HttpResponseMessage GetUsers()
        {
            string conString = "Data Source=ST-03;Initial Catalog=UsersDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users;", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<User> users = new List<User>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);

                        users.Add(user);
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, users);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "list is empty");
                }
            }
        }
        [HttpGet]
        [Route("api/GetUsers/{userId}")]
        public HttpResponseMessage GetUserById(int userId)
        {
            string conString = "Data Source=ST-03;Initial Catalog=UsersDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Users;", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<User> users = new List<User>();
                User GetSpecificUser()
                { 

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32(0);
                            user.FirstName = reader.GetString(1);
                            user.LastName = reader.GetString(2);

                            users.Add(user);
                        }
                        User specificUser = users.Where(x => x.Id == userId).Select(x => x).FirstOrDefault();
                        return specificUser;
                    }   
                    else
                    {
                        return null;
                    }
                }
                User userWithId = GetSpecificUser();
                if (userWithId != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, userWithId);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "No such user");
                }
            }
        }
    }
}