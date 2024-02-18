using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext //ENTİTYFRAMEWORK paketini kullanmak için yazıyoruz.
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=postgres; Username=postgres;Password=180200");
            // PostgreSQL bağlantı dizesi
        }


      
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductInfo> Products { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Salad>Salads { get; set; }
        public DbSet<Menu> Menus{ get; set; }
        public DbSet<Drink>Drinks { get; set; }


    }
}
