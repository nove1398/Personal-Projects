using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Blog.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User> UserList = new List<User>();
            for (int i = 1; i < 100; i++)
            {
                UserList.Add(new User() { UserId = i, Username = $"NameyNamey{1}", FirstName = $"john{i}", LastName = "doe", CreatedAt = DateTime.Now.AddDays(i * 2), Active = true });
            }
            modelBuilder.Entity<User>(
                entity => {
                    entity.HasData(UserList);
                    entity.Property(u => u.CreatedAt).HasDefaultValueSql("GETDATE()");
                });
        }

        public DbSet<User> Users { get; set; }
    }
}
