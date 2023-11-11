using BusinessObject.Models;
using DailyNews.DataAccess.DAO;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;

namespace DailyNews.Repository.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArticleDAO articleDAO = new ArticleDAO();
        public void AddArticle(ArticleRequestDTO request) => articleDAO.AddArticle(request);
        public void UpdateArticle(Article article) => articleDAO.UpdateArticle(article);
        public void DeleteArticle(Article article) => articleDAO.DeleteArticle(article);
        public List<Article> GetArticles() => articleDAO.GetArticles();
        public Article GetArticleById(int id) => articleDAO.GetArticleById(id);
        public List<Article> GetPublishedArticles() => articleDAO.GetPublishedArticles();
        public List<Article> GetUnpublishedArticles() => articleDAO.GetUnpublishedArticles();

        public List<Article> GetArticlesByCategoryId(int categoryId) => articleDAO.GetArticlesByCategoryId(categoryId);

        public List<Article> GetArticlesByCategoryName(string categoryName) => articleDAO.GetArticlesByCategoryName(categoryName);
    }
}
