using Blazor_Blog.Data;
using Blazor_Blog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Blazor_Blog.Interfaces
{
    interface IUserService<T>
    {
        Task<List<T>> GetAllUsers(Expression<Func<T, bool>> predicate, 
                                 Expression<Func<T, object>> includes, 
                                 Expression<Func<T, object>> orderBy);
        Task<T> GetUserById(int id);
        Task<T> AddUser(T newUser);
        Task<bool> RemoveUserAsync(T oldUser);
        Task<T> UpdateUser(T user);
    }
}
