using E_Commerce_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Controllers
{
    public class CategoryController : Controller
    {
            public IActionResult Category_List()
            {
                List<Category> categories = new List<Category>();
                categories.Add(new Category { Id = 1, Name = "Phones"});
                categories.Add(new Category { Id = 2, Name = "Clothes"});
                
                return View(categories);
               
        }
    }
}
