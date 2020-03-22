using Blazor_Blog.Data;
using Blazor_Blog.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Blog.Services
{
    public class UserService : IUserService
    {
        private readonly AppDBContext _context;

        public UserService(AppDBContext context)
        {
            _context = context;
            
        }


        //Add User to DB
        public User AddUser(User newUser)
        {
            if(newUser == null)
            {
                return null;
            }
            _context.Users.Add(newUser);
            _context.SaveChanges();
 
            return newUser;
        }

        //Get all current Users
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        //Get specific user by ID
        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.Where(x => x.UserId == id).FirstOrDefaultAsync();
        }

        //Remove User from DB
        public async Task<bool> RemoveUserAsync(User oldUser)
        {
             _context.Users.Remove(oldUser);
            await _context.SaveChangesAsync();
            return await _context.Users.CountAsync(x => x.UserId == oldUser.UserId) > 0? false : true;
        }

        //Update User
        public async Task<User> UpdateUser(User user)
        {

            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
