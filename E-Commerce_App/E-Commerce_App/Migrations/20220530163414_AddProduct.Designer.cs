﻿// <auto-generated />
using E_Commerce_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce_App.Migrations
{
    [DbContext(typeof(ECommerceDBContext))]
    [Migration("20220530163414_AddProduct")]
    partial class AddProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce_App.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beauty"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobiles"
                        });
                });

            modelBuilder.Entity("E_Commerce_App.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Maybelline New York Colossal Bold Liner & Colossal Kajal - EYE KIT COMBO (Pack Of 2), 0.35 gm + 3 ml",
                            Name = "Liner & Colossal Kajal",
                            Price = 15.5
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "URBANMAC Premium Synthetic Kabuki Foundation Face Powder Blush Eyeshadow Brush Makeup Brush Kit with Blender Sponge and Brush Cleaner - Makeup Brushes Set",
                            Name = "Blushes",
                            Price = 20.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Coloressence Full Coverage Waterproof Lightweight Matte Formula Opaque Lotion High Definition Foundation (HDF-2) with Set of 2 Blending Sponge",
                            Name = "Foundation ",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "HIKIPO Presents 100% Cotton Born Baby Summer Wear Baby Clothes Sets For Gift",
                            Name = "Cotton Born Baby",
                            Price = 15.0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Babyblossom Baby Kid's Cotton Combo Pack Of 3 Clothing Set ( 3 Top And 3 Bottom) (1112,Multicolor,0-3 Months)",
                            Name = "Kid's Cotton Combo Pack Of 3 Clothing Set",
                            Price = 243.0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Scott International Men's Regular Fit T-Shirt (Pack of 3)",
                            Name = "Men's Regular Fit T-Shirt",
                            Price = 120.0
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Oppo A54 (Starry Blue, 6GB RAM, 128GB Storage) with No Cost EMI & Additional Exchange Offers",
                            Name = "Oppo A54",
                            Price = 123.0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Tecno Spark 8 Pro (Turquoise Cyan, 7GB Expandable RAM 64GB Storage) 33W Fast Charger | Helio G85 Gaming Processor",
                            Name = "Tecno Spark 8 Pro",
                            Price = 432.0
                        });
                });

            modelBuilder.Entity("E_Commerce_App.Models.Product", b =>
                {
                    b.HasOne("E_Commerce_App.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("E_Commerce_App.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}