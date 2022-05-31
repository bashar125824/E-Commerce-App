﻿using E_Commerce_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Data
{
    public class ECommerceDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ECommerceDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
             new Category { Id = 1, Name = "Beauty" },
             new Category { Id = 2, Name = "Clothes" },
             new Category { Id = 3, Name = "Mobiles" }
             );

            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Liner & Colossal Kajal", Price = 15.5, Description = "Maybelline New York Colossal Bold Liner & Colossal Kajal - EYE KIT COMBO (Pack Of 2), 0.35 gm + 3 ml", CategoryId = 1 },
            new Product { Id = 2, Name = "Blushes", Price = 20.00, Description = "URBANMAC Premium Synthetic Kabuki Foundation Face Powder Blush Eyeshadow Brush Makeup Brush Kit with Blender Sponge and Brush Cleaner - Makeup Brushes Set", CategoryId = 1 },
            new Product { Id = 3, Name = "Foundation ", Price = 50.00, Description = "Coloressence Full Coverage Waterproof Lightweight Matte Formula Opaque Lotion High Definition Foundation (HDF-2) with Set of 2 Blending Sponge", CategoryId = 1 },
            new Product { Id = 4, Name = "Cotton Born Baby", Price = 15.00, Description = "HIKIPO Presents 100% Cotton Born Baby Summer Wear Baby Clothes Sets For Gift", CategoryId = 2 },
            new Product { Id = 5, Name = "Kid's Cotton Combo Pack Of 3 Clothing Set", Price = 243.00, Description = "Babyblossom Baby Kid's Cotton Combo Pack Of 3 Clothing Set ( 3 Top And 3 Bottom) (1112,Multicolor,0-3 Months)", CategoryId = 2 },
            new Product { Id = 6, Name = "Men's Regular Fit T-Shirt", Price = 120.00, Description = "Scott International Men's Regular Fit T-Shirt (Pack of 3)", CategoryId = 2 },
            new Product { Id = 7, Name = "Oppo A54", Price = 123.00, Description = "Oppo A54 (Starry Blue, 6GB RAM, 128GB Storage) with No Cost EMI & Additional Exchange Offers", CategoryId = 3 },
            new Product { Id = 8, Name = "Tecno Spark 8 Pro", Price = 432.00, Description = "Tecno Spark 8 Pro (Turquoise Cyan, 7GB Expandable RAM 64GB Storage) 33W Fast Charger | Helio G85 Gaming Processor", CategoryId = 3 }
            );
        }
        }
}
