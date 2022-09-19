using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class NortwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            HomeWork(optionsBuilder);
            //JobWork(optionsBuilder);
        }

        private static void JobWork(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SELIM-BAYINDIR\ARC;Initial Catalog=Northwind;User ID=sa;Password=Perkon123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
               ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private static void HomeWork(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=BYNDR\PIPLE;Initial Catalog=Northwind;User ID=dw;Password=Perkon123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
               ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
