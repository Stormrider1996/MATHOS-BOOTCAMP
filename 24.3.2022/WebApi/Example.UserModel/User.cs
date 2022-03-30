using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.UserModel
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}