using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example.WebApi.Controllers
{
    public class UserValuesController : ApiController
    {
        static List<User> users = new List<User>();
        
        //CREATE 
        [HttpPost]
        [Route("api/AddUser")]
        public HttpResponseMessage CreateUser(User user)
        {
            users.Add(user);
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }
        
        //READ
        [HttpGet]
        [Route("api/GetUsers")]
        public HttpResponseMessage GetUsers()
        {
            if (users.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No users registered!");
            }
        }
        
        //DELETE
        [HttpDelete]
        [Route("api/DeleteUser")]
        public HttpResponseMessage DeleteUserById(User user)
        {
            User output = users.Find(x => x.Id == user.Id);

            if (output != null)
            {
                users.Remove(output);
                return Request.CreateResponse(HttpStatusCode.OK, output);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Developer not found");
            }
        }

    }
}

