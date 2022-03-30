using Example.Repository;
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
        public async Task<List<IUser>> GetUsersAsync()
        {
            return await Services.GetUsersAsync();
        }
        public async Task<List<IUser>> GetUsersByIdAsync(int id)
        {
            return await Services.GetUsersByIdAsync(id);
        }
        public async Task CreateUserAsync(IUser OneUser)
        {
            await Services.CreateUserAsync(OneUser);
        }
        public async Task UpdateUserByIdAsync(IUser Id)
        {
            await Services.UpdateUserByIdAsync(Id);
        }
        public async Task<bool> DeleteUserByIdAsync(int id)
        {
            return await DeleteUserByIdAsync(id);
        }
    }
}