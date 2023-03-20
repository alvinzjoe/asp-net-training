using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetcoreTraining.Models;
using NetcoreTraining.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetcoreTraining.Controllers
{

    public class ProductsController : Controller
    {
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        // GET: /<controller>/
        [Route("/products/foo")]
        public IEnumerable<Product> ProductList()
        {
            Products = ProductService.GetProducts();
            var json = JsonSerializer.Serialize<IEnumerable<Product>>(Products);
            return Products;
        }
    }
}

