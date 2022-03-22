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
        public static List<User> users = new List<User>()
        {
            new User (1, "Franjo", "Jumic"),
            new User (2, "Pero", "Peric"),
            new User (3, "Marko", "Maric"),
        };


        // GET api/values
        [Route("api/users/getuserfirstname/{userId}")]
        [HttpGet]
        public string GetUserFirstName(int userId)
        {
            string output = users.Where(u => u.Id == userId).Select(u => u.FirstName).FirstOrDefault();
            return output;
        }
        // GET api/users
        [Route("api/users")]
        [HttpGet]
        public List<User> Get()
        {
            return users;
        }
      
        // POST api/values
        public void Post(User val)
        {
            users.Add(val);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        
    }
}

