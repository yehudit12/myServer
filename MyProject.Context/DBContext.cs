using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace MyProject.Context
{
    public class DBContext:DbContext,IProjectContext
    {        
        public DbSet<User> UserTable { get ; set ; }
        public DbSet<Children> ChildrenTable { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ProjectDB2;Trusted_Connection=True;");
        }
    }
}
