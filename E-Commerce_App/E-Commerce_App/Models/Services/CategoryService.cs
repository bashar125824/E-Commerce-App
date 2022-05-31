using E_Commerce_App.Data;
using E_Commerce_App.Models.DTO;
using E_Commerce_App.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Models.Services
{
    public class CategoryService : ICategory
    {
        private readonly ECommerceDBContext _context;

        public CategoryService(ECommerceDBContext context)
        {
            _context = context;
        }

        public async Task<CategoryDTO> Create(Category category)
        {
            _context.Entry(category).State = EntityState.Added;

            await _context.SaveChangesAsync();

            CategoryDTO categorydto = new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name
            };

            return categorydto;
        }

        public async Task<List<CategoryDTO>> GetCategories()
        {
            return await _context.Categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Products = category.Products.Select(p => new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    CategoryName = _context.Categories.FirstOrDefault(cat => cat.Id == p.CategoryId).Name
                }).ToList()
            }).ToListAsync();
        }

        public async Task<CategoryDTO> GetCategory(int id)
        {
            return await _context.Categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name,
                Products = category.Products.Select(p => new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    CategoryName = _context.Categories.FirstOrDefault(cat => cat.Id == p.CategoryId).Name
                }).ToList()
            }).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<CategoryDTO> Update(int id, Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            CategoryDTO categoryDto = new CategoryDTO
            {
                Id = category.Id,
                Name = category.Name
            };

            return categoryDto;
        }

        public async Task Delete(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            _context.Entry(category).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
