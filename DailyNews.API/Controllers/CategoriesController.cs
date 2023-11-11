using BusinessObject.Models;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;
using DailyNews.Repository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DailyNews.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository repository = new CategoryRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllCategories() => repository.GetCategories();

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategoryById(int id)
        {
            var category = repository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryRequestDTO request)
        {
            repository.AddCategory(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] CategoryRequestDTO request)
        {
            var category = repository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            category.CategoryName = request.CategoryName;
            category.Description = request.Description;

            repository.UpdateCategory(category);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = repository.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            repository.DeleteCategory(category);
            return NoContent();
        }
    }
}
