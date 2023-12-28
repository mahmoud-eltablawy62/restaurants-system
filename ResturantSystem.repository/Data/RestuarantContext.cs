using Microsoft.EntityFrameworkCore;
using ResturantSystem.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem.repository.Data
{
    public class RestuarantContext : DbContext
    {
        public RestuarantContext(DbContextOptions<RestuarantContext> options)
             : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Menu> Menus { get; set; }  
        public DbSet<MenuItem> Menu_item { get; set; }
        public DbSet<Resturant> Resturants { get; set; } 
        public DbSet<Staff> Staffs { get; set; }   
        public DbSet<Table> Tables { get; set; }    

    }
}
