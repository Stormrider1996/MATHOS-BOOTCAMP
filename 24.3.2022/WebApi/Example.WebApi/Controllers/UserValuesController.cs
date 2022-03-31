using Example.Services;
using Example.UserModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Example.RestModel;

namespace Example.WebApi.Controllers
{
    public class UserValuesController : ApiController
    {
        protected IUserServices Services { get; set; }
        public UserValuesController(IUserServices services)
        {
            Services = services;
        }
        
        [HttpGet]
        [Route("api/GetUsers")]
        public async Task<HttpResponseMessage> ResponseGetUsersAsync()
        {
            var users = await Services.GetUsersAsync();

            if (users != null)
            {

                List<UserRestModel> finalUsers = new List<UserRestModel>();

                foreach (var user in users)
                {
                    UserRestModel userRest = new UserRestModel();
                    userRest.FirstName = user.FirstName;
                    userRest.LastName = user.LastName;
                    finalUsers.Add(userRest);

                }
                return Request.CreateResponse(HttpStatusCode.OK, finalUsers);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No users");
            }

        }

        [HttpGet]
        [Route("api/GetUsers/{id}")]
        public async Task<HttpResponseMessage> ResponseGetUsersByIdAsync(int id)
        {

            var users = await Services.GetUsersByIdAsync(id);
            if (users != null)
            {

                List<UserRestModel> finalUsers = new List<UserRestModel>();

                foreach (User user in users)
                {
                    UserRestModel userRest = new UserRestModel();
                    userRest.FirstName = user.FirstName;
                    userRest.LastName = user.LastName;
                    finalUsers.Add(userRest);
                }
                return Request.CreateResponse(HttpStatusCode.OK, finalUsers);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No users");
            }

        }
        [HttpPost]
        [Route("api/CreateUser")]
        public async Task<HttpResponseMessage> CreateUserAsync(User user)
        {

            await Services.CreateUserAsync(user);
            
            if (user != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }


        }

        [HttpPut]
        [Route("api/UpdateUser")]
        public async Task<HttpResponseMessage> UpdateUserByIdAsync(User user)
        {

            await Services.UpdateUserByIdAsync(user);

            if (user != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, user);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }
        }
        //Metoda radi, logika provjeravanja je losa (prvi if ce uvijek biti false)!
        [HttpDelete]
        [Route("api/DeleteUser/{id}")]
        public async Task<HttpResponseMessage> DeleteUserByIdAsync(int id)
        {
            if (await Services.DeleteUserByIdAsync(id) == false)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "User has been deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }
        }  
    }
}