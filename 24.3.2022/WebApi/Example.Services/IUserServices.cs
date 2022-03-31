using Example.RestModel;
using Example.UserModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Services
{
    public interface IUserServices
    {
        Task CreateUserAsync(User user);
        Task<bool> DeleteUserByIdAsync(int id);
        Task<List<User>> GetUsersAsync();
        Task<List<User>> GetUsersByIdAsync(int id);
        Task UpdateUserByIdAsync(User user);
    }
}