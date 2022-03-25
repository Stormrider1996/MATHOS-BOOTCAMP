using Example.Repository;
using Example.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Services
{
    public class UserServices
    {
        public List<User> CatchDatabase()
        {
            UserRepository userRepository = new UserRepository();
            List<User> users = userRepository.CatchDatabase();
            return users;
        }

    }
}