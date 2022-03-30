using Example.UserModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Services
{
    public interface IUserServices
    {
        Task CreateUserAsync(IUser OneUser);
        Task<bool> DeleteUserByIdAsync(int id);
        Task<List<IUser>> GetUsersAsync();
        Task<List<IUser>> GetUsersByIdAsync(int id);
        Task UpdateUserByIdAsync(IUser Id);
    }
}