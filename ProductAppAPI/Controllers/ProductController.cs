using ProductAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAppAPI.Controllers
{
    public class ProductController : ApiController
    {
        // List of products for testing purposes (would query database in real scenario.
        private List<Product> products = new List<Product>() 
        {
            new Product() { ID = 1, Name = "Product 1", Category = "Car", Price = 23.23m},
            new Product() { ID = 2, Name = "Product 2", Category = "Bike", Price = 23.23m},
            new Product() { ID = 3, Name = "Product 3", Category = "Shed", Price = 23.23m}
        };

        // Returns all products as a list
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        // Returns single product based on id.
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
