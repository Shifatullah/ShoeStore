using ShoeStore.Products.Domain;
using ShoeStore.Products.Infrastructure.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Products.Application.Services
{
    public class ProductService
    {
        public Product FindProduct(int productId)
        {
            using(var context = new ShoeStoreProductsDbContext())
            {
                return context.Products.Find(productId);
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            using (var context = new ShoeStoreProductsDbContext())
            {
                return context.Products.ToList();
            }
        }
    }
}
