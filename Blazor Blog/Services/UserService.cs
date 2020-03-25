using Blazor_Blog.Data;
using Blazor_Blog.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Blog.Services
{
    public class UserService : BaseService<User>
    {
        private readonly AppDBContext _context;

        public UserService(AppDBContext context) : base(context)
        {
            _context = context;
            
        }


    }
}
