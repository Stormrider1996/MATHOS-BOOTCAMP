using Example.Services;
using Example.UserModel;
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
            UserServices userServices = new UserServices();
            List<User> users = userServices.CatchDatabase();
            
            if (users.Count > 0)
            {
                List<UserRest> finalUsers = new List<UserRest>();
                
                foreach (User user in users)
                {
                    UserRest userRest = new UserRest();
                    userRest.FirstName = user.FirstName;
                    finalUsers.Add(userRest);

                }
                return Request.CreateResponse(HttpStatusCode.OK, finalUsers);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No users");
            }
        
        }
        
        
        /*
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
        */
    }
    public class UserRest
    {
        public string FirstName { get; set; }
    }
    
}