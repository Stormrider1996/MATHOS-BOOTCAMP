using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.WebApi.Controllers
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public static List<User> Users { get; set; }

    }
}