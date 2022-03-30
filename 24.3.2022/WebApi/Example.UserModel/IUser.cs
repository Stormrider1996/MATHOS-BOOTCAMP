using System.Collections;
using System.Collections.Generic;

namespace Example.UserModel
{
    public interface IUser
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
}