using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
            return Ok();
        } 
        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            return Ok(await _repository.GetAllCategory());
        }

        [HttpPost]
        [Authorize(Policy="admin")]
        public IActionResult CreateCategory()
        {
            return RedirectToAction(nameof(GetAllCategory));
        }
     
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {

            return RedirectToAction(nameof(GetAllCategory));
        }

        [HttpPut]
        public IActionResult UpdateCategory()
        {
            return RedirectToAction(nameof(GetAllCategory));
        }

    }
}
