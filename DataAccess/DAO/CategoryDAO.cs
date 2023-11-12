using BusinessObject.Models;
using DailyNews.BusinessObject.DataContext;
using DailyNews.BusinessObject.DTO;
using DailyNews.DataAccess.DTO;
using Microsoft.EntityFrameworkCore;

namespace DailyNews.DataAccess.DAO
{
    public class CategoryDAO
    {
        private readonly DailyNewsContext context = new DailyNewsContext();

        public CategoryDAO() { }
        public CategoryDAO(DailyNewsContext context) { this.context = context; }

        public List<Category> GetCategories()
        {
            try
            {
                var result = context.Categories.ToList();
                return result;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<CategoryDTO_withArticles> GetCategoriesWithArticles()
        {
            try
            {
                var categories = context.Categories.Include(c=>c.Articles).ToList();
                List<CategoryDTO_withArticles> result = new List<CategoryDTO_withArticles>();
                foreach (var category in categories)
                {
                    CategoryDTO_withArticles c = new CategoryDTO_withArticles();
                    c.CategoryId = category.CategoryId;
                    c.CategoryName = category.CategoryName;
                    c.Description = category.Description;
                    c.Articles = new List<ArticleDTO>();
                    foreach(var article in category.Articles)
                    {
                        ArticleDTO a = new ArticleDTO();
                        a.ArticleId = article.ArticleId;
                        a.Title = article.Title;
                        a.ShortDescription = article.ShortDescription;
                        a.Content = article.Content;
                        a.Published = article.Published;
                        a.CategoryId = article.CategoryId;
                        a.Published = article.Published;
                        a.CreatedDate = article.CreatedDate;
                        a.UpdatedDate = article.UpdatedDate;
                        c.Articles.Add(a);
                    }

                    result.Add(c);
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Category GetCategoryById(int id)
        {
            try
            {
                var category = context.Categories.FirstOrDefault(x => x.CategoryId == id);
                return category;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void AddCategory(CategoryRequestDTO request)
        {
            try
            {
                var category = new Category
                {
                    CategoryName = request.CategoryName,
                    Description = request.Description
                };

                context.Categories.Add(category);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateCategory(Category category)
        {
            try
            {
                context.Entry<Category>(category).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteCategory(Category category)
        {
            try
            {
                var comments = context.Articles.Where(x => x.CategoryId == category.CategoryId).SelectMany(x => x.Comments);
                var articles = context.Articles.Where(x => x.CategoryId == category.CategoryId);

                context.Comments.RemoveRange(comments);
                context.Articles.RemoveRange(articles);
                context.Categories.Remove(category);

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
