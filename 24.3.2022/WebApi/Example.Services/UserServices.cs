using Example.Repository;
using Example.RestModel;
using Example.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Services
{
    public class UserServices : IUserServices
    {
        protected IUserRepository Services { get; set; }
        public UserServices(IUserRepository services)
        {
            Services = services;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await Services.GetUsersAsync();
        }
        public async Task<List<User>> GetUsersByIdAsync(int id)
        {
            return await Services.GetUsersByIdAsync(id);
        }
        public async Task CreateUserAsync(User user)
        {
            await Services.CreateUserAsync(user);
        }
        public async Task UpdateUserByIdAsync(User user)
        {
            await Services.UpdateUserByIdAsync(user);
        }
        public async Task<bool> DeleteUserByIdAsync(int id)
        {
            return await Services.DeleteUserByIdAsync(id);
        }
    }
}