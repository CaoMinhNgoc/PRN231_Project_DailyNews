using BusinessObject.Models;
using DailyNews.DataAccess.DAO;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;

namespace DailyNews.Repository.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CommentDAO commentDAO = new();
        public List<Comment> GetComments() => commentDAO.GetComments();
        public Comment GetCommentByCommentId(int id) => commentDAO.GetCommentByCommentId(id);
        public List<Comment> GetCommentsByArticleId(int id) => commentDAO.GetCommentsByArticleId(id);
        public void AddComment(CommentCreateRequestDTO request) => commentDAO.AddComment(request);
        public void UpdateComment(Comment comment) => commentDAO.UpdateComment(comment);
        public void DeleteComment(Comment comment) => commentDAO.DeleteComment(comment);
    }
}
