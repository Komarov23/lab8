﻿using lr8.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "Product 1", Price = 10.00m, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Product 2", Price = 20.00m, CreatedDate = DateTime.Now.AddDays(-1) },
                new Product { ID = 3, Name = "Product 3", Price = 30.00m, CreatedDate = DateTime.Now.AddDays(-2) },
            };

            return View(products);
        }
    }
}
