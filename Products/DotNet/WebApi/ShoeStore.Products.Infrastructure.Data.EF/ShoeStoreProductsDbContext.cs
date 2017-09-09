using ShoeStore.Products.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Products.Infrastructure.Data.EF
{
    public class CustomComplexTypeAttributeConvention : ComplexTypeAttributeConvention
    {
        public CustomComplexTypeAttributeConvention()
        {
            Properties().Configure(p => p.HasColumnName(p.ClrPropertyInfo.Name));
        }
    }

    public class ShoeStoreProductsDbContext : DbContext
    {

        public ShoeStoreProductsDbContext() : base("ShoeStoreProductsDbContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ComplexTypeAttributeConvention>();
            modelBuilder.Conventions.Add(new CustomComplexTypeAttributeConvention());

            modelBuilder.HasDefaultSchema("ssp");

            modelBuilder.Entity<ProductAsset>()
                .HasKey(pa => new { pa.ProductId, pa.AssetId });

            modelBuilder.Entity<ProductPrice>()
                .HasKey(pp => pp.ProductId);
        }

        public DbSet<Catalogue> Catalogues { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Asset> Assets{ get; set; }                       
    }
}
