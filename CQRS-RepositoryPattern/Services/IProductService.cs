using BE_Practice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Services
{
   public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
        Task CreateAsync(Product product);
        Task<bool> UpdateAsync(string id, Product product);
        Task<bool> DeleteAsync(string id);
    }
}
