using E_Commerce_App.Models.DTO;
using E_Commerce_App.Models.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_App.Data;

namespace E_Commerce_App.Models.Services
{
    public class ProductService : IProduct
    {
        private readonly ECommerceDBContext _context;

        public ProductService(ECommerceDBContext context)
        {
            _context = context;
        }

        public async Task<ProductDTO> Create(Product product)
        {
            _context.Entry(product).State = EntityState.Added;
            await _context.SaveChangesAsync();

            ProductDTO productDto = new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = _context.Categories.FirstOrDefault(cat => cat.Id == product.CategoryId).Name
            };

            return productDto;
        }

        public async Task<ProductDTO> GetProduct(int Id)
        {
            return await _context.Product.Select(X => new ProductDTO
            {
                Id = X.Id,
                Name = X.Name,
                Price = X.Price,
                Description = X.Description,
                CategoryName = _context.Categories.FirstOrDefault(cat => cat.Id == X.CategoryId).Name
            }).FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<List<ProductDTO>> GetProducts()
        {
            return await _context.Product.Select(X => new ProductDTO
            {
                Id = X.Id,
                Name = X.Name,
                Price = X.Price,
                Description = X.Description,
                CategoryName = _context.Categories.FirstOrDefault(cat => cat.Id == X.CategoryId).Name
            }).ToListAsync();
        }

        public async Task<ProductDTO> Update(int Id, Product product)
        {
            ProductDTO productDto = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryName = _context.Categories.FirstOrDefault(cat => cat.Id == product.CategoryId).Name
            };
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return productDto;
        }

        public async Task Delete(int id)
        {
            Product product = await _context.Product.FindAsync(id);
            _context.Entry(product).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
