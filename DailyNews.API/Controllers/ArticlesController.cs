using BusinessObject.Models;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;
using DailyNews.Repository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DailyNews.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository repository = new ArticleRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Article>> GetAllArticles() => repository.GetArticles();

        [HttpGet("{id}")]
        public ActionResult<Article> GetArticleById(int id) => repository.GetArticleById(id);

        [HttpGet]
        public ActionResult<IEnumerable<Article>> GetPublishedArticles() => repository.GetPublishedArticles();

        [HttpGet]
        public ActionResult<IEnumerable<Article>> GetUnublishedArticles() => repository.GetUnpublishedArticles();

        [HttpPost]
        public IActionResult AddArticle([FromBody] ArticleRequestDTO request)
        {
            repository.AddArticle(request);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateArticle(int id, [FromBody] ArticleRequestDTO request)
        {
            var article = repository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }

            article.Title = request.Title;
            article.ShortDescription = request.ShortDescription;
            article.Published = request.Published;
            article.UpdatedDate = DateTime.Now;
            article.CategoryId = request.CategoryId;

            repository.UpdateArticle(article);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var article = repository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }

            repository.DeleteArticle(article);
            return NoContent();
        }
    }
}
