using BusinessObject.Models;
using DailyNews.BusinessObject.DataContext;
using DailyNews.DataAccess.DTO;
using Microsoft.EntityFrameworkCore;

namespace DailyNews.DataAccess.DAO
{
    public class ArticleDAO
    {
        private readonly DailyNewsContext context = new();
        public ArticleDAO() { }
        public ArticleDAO(DailyNewsContext context)
        {
            this.context = context;
        }
        public List<Article> GetArticles()
        {
            try
            {
                var articles = context.Articles.ToList();
                return articles;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Article GetArticleById(int id)
        {
            try
            {
                var article = context.Articles.FirstOrDefault(x => x.ArticleId == id);
                return article;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Article> GetArticlesByCategoryId(int categoryId)
        {
            try
            {
                var articles = context.Articles.Where(x => x.CategoryId == categoryId).ToList();
                return articles;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Article> GetArticlesByCategoryName(string categoryName)
        {
            try
            {
                var articles = context.Articles.Where(x => x.Category.CategoryName.Trim().ToLower().Contains(categoryName.Trim().ToLower())).ToList();

                return articles;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Article> GetPublishedArticles()
        {
            try
            {
                var articles = context.Articles.Where(x => x.Published == true).ToList();
                return articles;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Article> GetUnpublishedArticles()
        {
            try
            {
                var articles = context.Articles.Where(x => x.Published == false).ToList();
                return articles;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddArticle(ArticleRequestDTO request)
        {
            try
            {
                var article = new Article
                {
                    Title = request.Title,
                    ShortDescription = request.ShortDescription,
                    Content = request.Content,
                    Published = request.Published,
                    CreatedDate = DateTime.Now,
                    CategoryId = request.CategoryId
                };

                context.Articles.Add(article);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateArticle(Article article)
        {
            try
            {
                context.Entry<Article>(article).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteArticle(Article article)
        {
            try
            {
                var comments = context.Articles.Where(x => x.ArticleId == article.ArticleId).SelectMany(x => x.Comments);

                context.Comments.RemoveRange(comments);
                context.Articles.Remove(article);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
