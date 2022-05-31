using E_Commerce_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product_List()
        {
            List<Product> Products = new List<Product>();

            Products.Add(new Product { Id = 1, Name = "Iphone 11", CategoryId = 1 , Price = 400 , Description = "Good performance , amazing camera" });
            Products.Add(new Product { Id = 2, Name = "T-Shirt", CategoryId = 2 ,  Price = 500, Description = "Very Comfortable T-shirt" });

            return View(Products);
        }
    }
}
