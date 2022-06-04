using E_Commerce_App.Models;
using E_Commerce_App.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Controllers
{
    public class ProductController : Controller
    {
        private IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        public async Task<IActionResult> ProductDetail(int id)
        {
            var product = await _product.GetProduct(id);
            return View(product);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Product_List()
        {

            List<Product> Products = new List<Product>();

            Products.Add(new Product { Id = 1, Name = "Iphone 11", CategoryId = 1 , Price = 400 , Description = "Good performance , amazing camera" });
            Products.Add(new Product { Id = 2, Name = "T-Shirt", CategoryId = 2 ,  Price = 500, Description = "Very Comfortable T-shirt" });

            return View(Products);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            var products = await _product.Create(product);
            if (ModelState.IsValid)
            {
                return Content(" Product added successfully ! \nName: " + product.Name + " \nPrice: " + product.Price + " \nDescription: " + product.Description);
            }
            return View(products);
        }
        //public async Task<IActionResult> Update(int id)
        //{
        //    Product product1 = await _product.GetProduct(id);
        //    return View(product1);
        //}

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            if (ModelState.IsValid)
            {
                await _product.Update(product.Id, product);
                return Content("You have successfully edited data");
            }
            return View(product);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _product.Delete(id);
            return Content("Product deleted successfully");
        }
    }
}
