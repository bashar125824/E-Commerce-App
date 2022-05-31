using E_Commerce_App.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Models.Interfaces
{
    public interface ICategory
    {

        Task<CategoryDTO> Create(Category category);
        Task<List<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetCategory(int id);
        Task<CategoryDTO> Update(int id, Category category);
        Task Delete(int id);

    }
}
