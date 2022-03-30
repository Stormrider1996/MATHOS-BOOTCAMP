using Example.UserModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.Repository
{
    public interface IUserRepository
    {
        Task CreateUserAsync(IUser OneUser);
        Task<bool> DeleteUserByIdAsync(int id);
        Task<List<IUser>> GetUsersAsync();
        Task<List<IUser>> GetUsersByIdAsync(int id);
        Task UpdateUserByIdAsync(IUser OneUser);
    }
}