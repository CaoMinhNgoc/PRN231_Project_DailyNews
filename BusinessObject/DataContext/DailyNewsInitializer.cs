using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyNews.BusinessObject.DataContext
{
    public static class DailyNewsInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Politics" },
                new Category { CategoryId = 2, CategoryName = "Economics" },
                new Category { CategoryId = 3, CategoryName = "Life" },
                new Category { CategoryId = 4, CategoryName = "Health" },
                new Category { CategoryId = 5, CategoryName = "For teens" },
                new Category { CategoryId = 6, CategoryName = "Education" },
                new Category { CategoryId = 7, CategoryName = "Tourism" },
                new Category { CategoryId = 8, CategoryName = "Entertainment" },
                new Category { CategoryId = 9, CategoryName = "Technology" },
                new Category { CategoryId = 10, CategoryName = "Fashion" }
            );

            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    ArticleId = 1,
                    Title = "Benefits of Regular Exercise",
                    ShortDescription = "Stay active and healthy",
                    Content = "Regular exercise has numerous benefits for your overall health. It can help you maintain a healthy weight, reduce the risk of chronic diseases, and improve your mood. Exercise is not just about physical fitness; it also enhances mental well-being. It can reduce stress and anxiety, boost self-esteem, and increase cognitive function. Whether it's a brisk walk, a yoga session, or a full-blown workout, make exercise a part of your daily routine for a healthier, happier life.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 9, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 4
                }
            );
        }
    }
}
