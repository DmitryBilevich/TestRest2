using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebStoreData.Models;
using WebStoreData.Repository;
using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Threading;
using System.Globalization;



namespace TestRest2.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {            
            WebStoreData.Repository.ProductRepository productRepository = new ProductRepository();
            List<WebStoreData.Models.Product> products = productRepository.GetProducts().ToList();            
            
            
            string result = JsonConvert.SerializeObject(products, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore});
 
            return result;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            WebStoreData.Repository.ProductRepository productRepository = new ProductRepository();
            WebStoreData.Models.Product product = productRepository.GetProductById(id);
            
            string result= JsonConvert.SerializeObject(product, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        
            return result;
        }

        // POST api/<controller>
        public bool Post([FromBody]WebStoreData.Models.Product value)
        {
            WebStoreData.Repository.ProductRepository productRepository = new ProductRepository();
            productRepository.Create(value);
            return true;
        }

        // PUT api/<controller>/5
        public void Put([FromBody]WebStoreData.Models.Product value)
        {
            WebStoreData.Repository.ProductRepository productRepository = new ProductRepository();
            productRepository.Edit(value);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            WebStoreData.Repository.ProductRepository productRepository = new ProductRepository();
            productRepository.Delete(id);
            return true;
        }
    }
}