using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class CafeContext : DbContext
    {
     
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Food> Foods { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MACIFER\\SQLEXPRESS;DataBase=cafedb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>().ToTable("Drinks");
            modelBuilder.Entity<Dessert>().ToTable("Desserts");
            modelBuilder.Entity<Food>().ToTable("Foods");
        }
    }
}
