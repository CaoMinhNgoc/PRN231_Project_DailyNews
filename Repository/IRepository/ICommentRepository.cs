using BusinessObject.Models;
using DailyNews.DataAccess.DTO;

namespace DailyNews.Repository.IRepository
{
    public interface ICommentRepository
    {
        public List<Comment> GetComments();
        public Comment GetCommentByCommentId(int id);
        public List<Comment> GetCommentsByArticleId(int id);
        public void AddComment(CommentCreateRequestDTO request);
        public void UpdateComment(Comment comment);
        public void DeleteComment(Comment comment);
    }
}
