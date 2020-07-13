using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Entities;

namespace WebApi.Models
{
    public interface IRepository
    {
        Task<List<Category>> GetAllCategory();
        Task<Category> GetCategoryById(Guid id);

        Task<List<Product>> GetAllProductByCategoryId(Guid id);
        Task<List<Product>> GetAllProduct();

    }
}
