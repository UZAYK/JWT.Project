using DataAccess.Concrate.EntityFrameworkCore.Mapping;
using DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFrameworkCore.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;" +
                    "database=JWTProject; integrated security= true;");
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppRoleMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppUserRoleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
        }

        public DbSet <AppUser> AppUsers { get; set; }
        public DbSet <AppRole> AppRoles { get; set; }
        public DbSet <AppUserRole> AppUserRoles { get; set; }
        public DbSet <Product> Products { get; set; }
    }
}
