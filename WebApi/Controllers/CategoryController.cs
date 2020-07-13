using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Models.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository _repository;

        public CategoryController(IRepository repository)
        {
            _repository = repository;
        }

     
        [HttpGet("{id}")]
        public IActionResult GetCategoryId(int id)
        {
            return Ok();
        } 
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            return Ok(await _repository.GetAllCategory());
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            await _repository.AddCategory(category);
            return RedirectToAction(nameof(GetAllCategory));
        }
     
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await _repository.DeleteCategory(id);
            return RedirectToAction(nameof(GetAllCategory));
        }

        [HttpPut]
        public IActionResult UpdateCategory()
        {
            return RedirectToAction(nameof(GetAllCategory));
        }

    }
}
