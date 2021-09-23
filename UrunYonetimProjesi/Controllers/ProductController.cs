using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrunYonetimProjesi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrunYonetimProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        VeriParkGIDAContext db = new VeriParkGIDAContext();

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products.ToList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IEnumerable<Product> Get(int id)
        {
            return db.Products.Where(pro => pro.Id == id).ToList();
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            Product product = value;
            db.Products.Add(product);
            db.SaveChanges();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            Product product = db.Products.Where(pro => pro.Id == id).FirstOrDefault();
            product.ProductName = value.ProductName;
            product.CurrencyName = value.CurrencyName;
            product.ProductExpireDate = value.ProductExpireDate;
            product.ProductFee = value.ProductFee;
            db.SaveChanges();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product product = db.Products.Where(pro => pro.Id == id).FirstOrDefault();
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
