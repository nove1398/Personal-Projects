using Blazor_Blog.Data;
using Blazor_Blog.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blazor_Blog.Services
{
    public class BaseService<T> : IUserService<T> where T : class
    {
        private readonly AppDBContext _context;
        private DbSet<T> _table;

        public BaseService(AppDBContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public async Task<T> AddUser(T entity)
        {
            if (entity == null)
            {
                return null;
            }
            _table.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllUsers(Expression<Func<T, bool>> filter = null, 
                                                Expression<Func<T, object>> includes = null,
                                                Expression<Func<T, object>> orderBy = null)
        {
            var query = _table.AsQueryable();
            if(filter != null)
            {
                query = query.Where(filter);
            }

            if(includes != null)
            {
                query = query.Include(includes);
            }

            if(orderBy != null)
            { 
              query = query.OrderByDescending(orderBy);
            }

            return await query.AsNoTracking().ToListAsync();
        }


        public async Task<T> GetUserById(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<bool> RemoveUserAsync(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _table.Attach(entity);
            }

            _table.Remove(entity);
            await _context.SaveChangesAsync();

            return (await _table.FindAsync(entity) == null);
        }

        public async Task<T> UpdateUser(T entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

    }
}
