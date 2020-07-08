using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

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
            return Ok(_repository.GetCategoryById(id));
        } 
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            return Ok(_repository.GetCategories());
        }

        [HttpPost]
        public IActionResult CreateCategory(Category createRequest)
        {
            _repository.AddCategory(createRequest);
            return RedirectToAction(nameof(GetAllCategory));
        }
     
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _repository.DeleteCategory(id);
            return RedirectToAction(nameof(GetAllCategory));
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category update)
        {
            _repository.UpdateCategory(update);
            return RedirectToAction(nameof(GetAllCategory));
        }

    }
}
