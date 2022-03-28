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
        public async Task<List<User>> GetUsersAsync()
        {
            UserRepository userRepository = new UserRepository();
            return await userRepository.GetUsersAsync();
        }
        public async Task<List<User>> GetUsersByIdAsync(int id)
        {
            UserRepository userRepository = new UserRepository();
            return await userRepository.GetUsersByIdAsync(id); ;
        }
        public async Task CreateUserAsync(User user)
        {
            UserRepository userRepository = new UserRepository();
            await userRepository.CreateUserAsync(user);
        }
        public async Task UpdateUserByIdAsync(User user)
        {
            UserRepository userRepository = new UserRepository();
            await userRepository.UpdateUserByIdAsync(user);
        }
        public async Task DeleteUserByIdAsync(int id)
        {
            UserRepository userRepository = new UserRepository();
            await userRepository.DeleteUserByIdAsync(id);
        }
    }
}