using BusinessObject.Models;
using DailyNews.BusinessObject.DTO;
using DailyNews.DataAccess.DAO;
using DailyNews.DataAccess.DTO;
using DailyNews.Repository.IRepository;

namespace DailyNews.Repository.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDAO categoryDAO = new();
        public List<Category> GetCategories() => categoryDAO.GetCategories();
        public List<CategoryDTO_withArticles> GetCategoriesWithArticle() => categoryDAO.GetCategoriesWithArticles();
        public Category GetCategoryById(int id) => categoryDAO.GetCategoryById(id);
        public void AddCategory(CategoryRequestDTO request) => categoryDAO.AddCategory(request);
        public void UpdateCategory(Category category) => categoryDAO.UpdateCategory(category);
        public void DeleteCategory(Category category) => categoryDAO.DeleteCategory(category);
    }
}
