using Microsoft.EntityFrameworkCore;
using ShoeStore.Products.Domain;
using System;
using System.Configuration;

namespace ShoeStore.Products.Infrastructure.Data
{
    public class ShoeStoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
