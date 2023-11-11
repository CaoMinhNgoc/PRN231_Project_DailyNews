using BusinessObject.Models;
using DailyNews.BusinessObject.DataContext;
using DailyNews.DataAccess.DTO;
using Microsoft.EntityFrameworkCore;

namespace DailyNews.DataAccess.DAO
{
    public class CommentDAO
    {
        private readonly DailyNewsContext context = new();
        public CommentDAO() { }
        public CommentDAO(DailyNewsContext context)
        {
            this.context = context;
        }
        public List<Comment> GetComments()
        {
            try
            {
                var comments = context.Comments.ToList();
                return comments;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Comment GetCommentByCommentId(int id)
        {
            try
            {
                var comment = context.Comments.FirstOrDefault(c => c.CommentId == id);
                return comment;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Comment> GetCommentsByArticleId(int id)
        {
            try
            {
                var comments = context.Comments.Where(x => x.ArticleId == id).ToList();
                return comments;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddComment(CommentCreateRequestDTO request)
        {
            try
            {
                var comment = new Comment
                {
                    CommentContent = request.CommentContent,
                    CommentTime = request.CommentTime,
                    Rating = request.Rating,
                    ArticleId = request.ArticleId,
                };

                context.Comments.Add(comment);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateComment(Comment comment)
        {
            try
            {
                context.Entry<Comment>(comment).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteComment(Comment comment)
        {
            try
            {
                context.Comments.Remove(comment);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
