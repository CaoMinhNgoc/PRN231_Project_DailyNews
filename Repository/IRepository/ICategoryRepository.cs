using BusinessObject.Models;
using DailyNews.BusinessObject.DTO;
using DailyNews.DataAccess.DTO;

namespace DailyNews.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
        public List<CategoryDTO_withArticles> GetCategoriesWithArticle();
        public Category GetCategoryById(int id);
        public void AddCategory(CategoryRequestDTO request);
        public void UpdateCategory(Category category);
        public void DeleteCategory(Category category);
    }
}
