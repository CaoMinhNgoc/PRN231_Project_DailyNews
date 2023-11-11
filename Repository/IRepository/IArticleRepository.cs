using BusinessObject.Models;
using DailyNews.DataAccess.DTO;

namespace DailyNews.Repository.IRepository
{
    public interface IArticleRepository
    {
        public List<Article> GetArticles();
        public Article GetArticleById(int id);
        public List<Article> GetPublishedArticles();
        public List<Article> GetUnpublishedArticles();
        public void AddArticle(ArticleRequestDTO request);
        public void UpdateArticle(Article article);
        public void DeleteArticle(Article article);
    }
}
