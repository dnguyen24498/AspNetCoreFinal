using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Repository : IRepository
    {
        private List<Category> categories;
        private List<Product> products;

        public Repository()
        {
            categories = new List<Category>
            {
                new Category{Id=1,Name="Danh mục 1"},
                new Category{Id=2,Name="Danh mục 2"},
                new Category{Id=3,Name="Danh mục 3"},
                new Category{Id=4,Name="Danh mục 4"},
            };

            products = new List<Product>
            {
                 new Product{CategoryId=1,Name="Sản phẩm 1",Id=1,Price=100},
                 new Product{CategoryId=2,Name="Sản phẩm 2",Id=2,Price=100},
                 new Product{CategoryId=3,Name="Sản phẩm 3",Id=3,Price=100},
                 new Product{CategoryId=4,Name="Sản phẩm 4",Id=4,Price=100},
            };
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void DeleteCategory(int id)
        {
            categories.Remove(categories.Where(x=>x.Id==id).SingleOrDefault());
        }

        public List<Category> GetCategories()
        {
            return categories;
        }


        public Category GetCategoryById(int id)
        {
            return categories.Where(x => x.Id == id).SingleOrDefault();
        }

        public void UpdateCategory(Category update)
        {
            var category = categories.Where(x => x.Id == update.Id).SingleOrDefault();
            category.Name = update.Name;
            category.Description = update.Description;
        }
    }
}
