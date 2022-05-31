using E_Commerce_App.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App.Models.Interfaces
{
    public interface IProduct
    {
        Task<ProductDTO> Create(Product product);
        Task<List<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProduct(int Id);
        Task<ProductDTO> Update(int Id, Product product);
        Task Delete(int id);
    }
}
