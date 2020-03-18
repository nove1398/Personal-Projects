using Microsoft.EntityFrameworkCore;
using Preggers_Jam.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Preggers_Jam.Data
{
    class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        DbSet<Blog> Blogs { get; set; }
    }
}
