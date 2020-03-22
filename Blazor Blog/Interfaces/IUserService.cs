using Blazor_Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Blog.Interfaces
{
    interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        User AddUser(User newUser);
        Task<bool> RemoveUserAsync(User oldUser);
        Task<User> UpdateUser(User user);
    }
}
