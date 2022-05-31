﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation properties
        public List<Product> Products { get; set; }
    }
}
