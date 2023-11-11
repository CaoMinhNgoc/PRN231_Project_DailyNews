using BusinessObject.Models;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;
using DailyNews.Repository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DailyNews.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository commentRepository = new CommentRepository();
        private readonly IArticleRepository articleRepository = new ArticleRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Comment>> GetAllComments() => commentRepository.GetComments();

        [HttpGet("{commentId}")]
        public ActionResult<Comment> GetCommentByCommentId(int commentId)
        {
            var comment = commentRepository.GetCommentByCommentId(commentId);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }

        [HttpGet("{articleId}")]
        public ActionResult<IEnumerable<Comment>> GetCommentsByArticleId(int articleId)
        {
            var comments = commentRepository.GetCommentsByArticleId(articleId);
            return Ok(comments);
        }

        [HttpPost]
        public IActionResult AddComment(CommentCreateRequestDTO request)
        {
            var article = articleRepository.GetArticleById(request.ArticleId);
            if (article == null)
            {
                return NotFound($"There is no article with Id = {request.ArticleId}");
            }

            commentRepository.AddComment(request);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, [FromBody] CommentUpdateRequestDTO request)
        {
            var comment = commentRepository.GetCommentByCommentId(id);
            if (comment == null)
            {
                return NotFound();
            }

            comment.CommentContent = request.CommentContent;
            comment.Rating = request.Rating;

            commentRepository.UpdateComment(comment);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            var comment = commentRepository.GetCommentByCommentId(id);
            if (comment == null)
            {
                return NotFound();
            }

            commentRepository.DeleteComment(comment);
            return NoContent();
        }
    }
}
