using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_App.Models.Interfaces;
using E_Commerce_App.Models;

namespace E_Commerce_App.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
    }
}
