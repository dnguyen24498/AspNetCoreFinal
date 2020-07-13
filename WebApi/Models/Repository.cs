using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Entities;

namespace WebApi.Models
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
public async Task<List<Category>> GetAllCategory()
        {
            return await _context.Categories.ToListAsync();
        }

        
        public Task<List<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProductByCategoryId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
