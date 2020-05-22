using BlazorApp.Client.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Server.Data
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppRoles> Roles { get; set; }
        public DbSet<AppGroups> Groups { get; set; }
        public DbSet<AppUserRoles> AppUserRoles { get; set; }
        public DbSet<AppUserGroups> AppUserGroups { get; set; }

    }
}
