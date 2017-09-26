using ShoeStore.Products.Application.Services;
using ShoeStore.Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoeStore.ProductsApi.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        [Authorize]
        public IEnumerable<Product> Get()
        {
            return new ProductService().GetAllProducts();
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return new ProductService().FindProduct(id);
        }

        //// POST: api/Products
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Products/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Products/5
        //public void Delete(int id)
        //{
        //}
    }
}
