using BusinessObject.Models;
using DailyNews.BusinessObject.DataContext;
using DailyNews.DataAccess.DAO;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DailyNews.Repository.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ArticleDAO articleDAO = new ArticleDAO();
        public void AddArticle(ArticleRequestDTO request) => articleDAO.AddArticle(request);
        public void UpdateArticle(Article article) => articleDAO.UpdateArticle(article);
        public void DeleteArticle(Article article) => articleDAO.DeleteArticle(article);
        public List<Article> GetArticles() => articleDAO.GetArticles();
        public List<Article> GetArticlesSortByCmt()
        {
            DailyNewsContext context = new DailyNewsContext();
            return articleDAO.SortArticleByCommentCount(context.Articles.Include(a=>a.Comments).ToList());
        }
        public Article GetArticleById(int id) => articleDAO.GetArticleById(id);
        public List<Article> GetPublishedArticles() => articleDAO.GetPublishedArticles();
        public List<Article> GetUnpublishedArticles() => articleDAO.GetUnpublishedArticles();

        public List<Article> GetArticlesByCategoryId(int categoryId) => articleDAO.GetArticlesByCategoryId(categoryId);

        public List<Article> GetArticlesByCategoryName(string categoryName) => articleDAO.GetArticlesByCategoryName(categoryName);
    }
}
