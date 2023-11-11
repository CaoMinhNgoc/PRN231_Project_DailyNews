using BusinessObject.Models;
using Microsoft.AspNetCore.Identity;
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
                },
                new Article
                {
                    ArticleId = 2,
                    Title = "Healthy Eating Habits",
                    ShortDescription = "Nourish your body with the right food",
                    Content = "Maintaining healthy eating habits is essential for your well-being. A balanced diet rich in fruits, vegetables, and whole grains provides essential nutrients for your body. It can help prevent various health issues, including heart disease and diabetes. In addition, a proper diet can boost your energy levels and promote weight management. Start making mindful food choices today for a healthier lifestyle.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 10, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 4
                },
                new Article
                {
                    ArticleId = 3,
                    Title = "Effective Time Management",
                    ShortDescription = "Maximize productivity and reduce stress",
                    Content = "Time management is crucial in our fast-paced world. Properly managing your time can increase productivity and reduce stress. Prioritizing tasks, setting goals, and avoiding distractions are key components of effective time management. By optimizing your daily routine, you can achieve more in less time, leaving room for relaxation and personal growth.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 6, 11, 5, 0),
                    UpdatedDate = null,
                    CategoryId = 3
                },
                new Article
                {
                    ArticleId = 4,
                    Title = "The Importance of Sleep",
                    ShortDescription = "Rest for a healthier life",
                    Content = "Getting enough quality sleep is essential for physical and mental health. Sleep allows your body to rest, repair, and recharge. It plays a vital role in memory consolidation and emotional well-being. Lack of sleep can lead to a range of health issues, including impaired cognitive function and mood disturbances. Prioritize your sleep schedule to lead a healthier and more productive life.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 12, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 4
                },
                new Article
                {
                    ArticleId = 5,
                    Title = "Understanding Political Ideologies",
                    ShortDescription = "Exploring diverse political beliefs",
                    Content = "Politics is a complex field with a variety of ideologies. From conservatism to liberalism, socialism to libertarianism, it's essential to understand the different political beliefs that shape our world. Each ideology has its unique approach to governance, economics, and societal issues. By gaining insight into these ideologies, you can make informed political decisions and engage in meaningful discussions about the future of your nation.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 13, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 1
                },
                new Article
                {
                    ArticleId = 6,
                    Title = "The Role of Media in Politics",
                    ShortDescription = "Media's impact on political landscape",
                    Content = "Media plays a significant role in shaping public opinion and influencing political decisions. In the age of 24/7 news coverage and social media, understanding how media operates within the political landscape is crucial. It can influence elections, policy debates, and public discourse. Explore the relationship between media and politics to become a more informed citizen.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 14, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 1
                },
                new Article
                {
                    ArticleId = 7,
                    Title = "Global Political Challenges",
                    ShortDescription = "Addressing pressing global issues",
                    Content = "The world faces numerous political challenges, from climate change to international conflicts. Understanding and addressing these global issues is critical for a more stable and prosperous future. Explore the complexities of international politics and the interconnected nature of global challenges. Discover the efforts and initiatives aimed at finding solutions to these pressing problems.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 15, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 1
                },
                new Article
                {
                    ArticleId = 8,
                    Title = "Introduction to Economic Principles",
                    ShortDescription = "Exploring fundamental economic concepts",
                    Content = "Economics is the study of how societies allocate their limited resources to meet their needs and wants. In this introductory article, we delve into the fundamental economic principles, including supply and demand, opportunity cost, and the role of markets in resource allocation. Understanding these concepts is crucial for making informed economic decisions in your personal and professional life.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 16, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 2
                },
                new Article
                {
                    ArticleId = 9,
                    Title = "Impact of Inflation on the Economy",
                    ShortDescription = "Unpacking the effects of rising prices",
                    Content = "Inflation is a common economic phenomenon where the general price level of goods and services increases over time. This article explores the impact of inflation on individuals, businesses, and the overall economy. Learn how inflation can erode purchasing power, affect investment decisions, and influence monetary policy. Understanding inflation is essential for financial planning and economic analysis.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 17, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 2
                },
                new Article
                {
                    ArticleId = 10,
                    Title = "International Trade and Global Economics",
                    ShortDescription = "Exploring the dynamics of global trade",
                    Content = "International trade is a key driver of the global economy. This article delves into the intricacies of international trade, including the benefits of trade, trade agreements, and the impact of tariffs and trade barriers. Understand how global economic interdependence shapes the prosperity of nations and how international trade can impact various industries and markets.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 18, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 2
                },
                new Article
                {
                    ArticleId = 11,
                    Title = "Balancing Work and Personal Life",
                    ShortDescription = "Achieving harmony in your daily life",
                    Content = "Finding the right balance between work and personal life is crucial for overall well-being. This article explores strategies for managing your professional responsibilities while making time for personal life, hobbies, and relaxation. Achieving this balance can lead to reduced stress and a more fulfilling life outside of work.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 19, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 3
                },
                new Article
                {
                    ArticleId = 12,
                    Title = "Building Healthy Relationships",
                    ShortDescription = "Nurturing meaningful connections in life",
                    Content = "Healthy relationships are a cornerstone of a fulfilling life. This article delves into the key principles of building and maintaining healthy connections with friends, family, and partners. Learn effective communication, conflict resolution, and emotional intelligence to foster positive and meaningful relationships in your life.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 20, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 3
                },
                new Article
                {
                    ArticleId = 14,
                    Title = "Healthy Habits for Teens",
                    ShortDescription = "Promoting well-being in teenage years",
                    Content = "Teenage years are a crucial time for personal development. This article focuses on promoting healthy habits for teenagers, including proper nutrition, exercise, and mental well-being. Discover how to make positive lifestyle choices that can set the foundation for a healthy and fulfilling adulthood.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 22, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 5
                },
                new Article
                {
                    ArticleId = 15,
                    Title = "Navigating Peer Pressure",
                    ShortDescription = "Making informed choices in social situations",
                    Content = "Peer pressure is a common experience for teenagers. This article provides guidance on how to navigate peer pressure and make informed choices in social situations. Learn to assert your values, set boundaries, and build strong, supportive friendships during your teenage years.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 23, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 5
                },
                new Article
                {
                    ArticleId = 16,
                    Title = "Career Exploration for Teens",
                    ShortDescription = "Discovering your future path",
                    Content = "As a teenager, it's never too early to start exploring potential career paths. This article offers insights and tips on how to begin your career exploration journey. Learn about different career options, educational paths, and how to set goals for your future. By starting early, you can make informed decisions about your career."
,
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 10, 4, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 5
                },
                new Article
                {
                    ArticleId = 17,
                    Title = "The Importance of Early Childhood Education",
                    ShortDescription = "Laying the foundation for lifelong learning",
                    Content = "Early childhood education plays a crucial role in a child's development. This article explores the significance of quality preschool and kindergarten programs in preparing children for academic success and social growth. Discover the long-term benefits of early education and how it can set the stage for a lifetime of learning.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 9, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 6
                },
                new Article
                {
                    ArticleId = 18,
                    Title = "Online Learning and the Future of Education",
                    ShortDescription = "Adapting to the digital age of learning",
                    Content = "Online learning has become increasingly prevalent in the education landscape. This article discusses the evolution of online education and its impact on traditional learning methods. Explore the advantages and challenges of virtual classrooms and how they are shaping the future of education.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 10, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 6
                },
                new Article
                {
                    ArticleId = 19,
                    Title = "The Role of Teachers in Fostering Learning",
                    ShortDescription = "Nurturing young minds for a brighter future",
                    Content = "Teachers are the cornerstone of education. This article highlights the vital role that teachers play in fostering a love for learning, critical thinking, and personal growth in students. Learn about the challenges educators face and the rewards of inspiring young minds to achieve their full potential.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 11, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 6
                },
                new Article
                {
                    ArticleId = 20,
                    Title = "Exploring Exotic Destinations",
                    ShortDescription = "Adventures in far-off lands",
                    Content = "Travel enthusiasts, get ready to embark on an exploration of exotic destinations around the world. This article takes you on a journey to breathtaking locations, from tropical paradises to historical wonders. Discover travel tips, local cultures, and the wonders that await those who seek new horizons.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 12, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 7
                },
                new Article
                {
                    ArticleId = 21,
                    Title = "Sustainable Tourism Practices",
                    ShortDescription = "Preserving the beauty of our planet",
                    Content = "As travelers, it's crucial to embrace sustainable tourism practices. This article emphasizes the importance of responsible and eco-friendly travel. Learn how to minimize your impact on the environment, support local communities, and contribute to the preservation of natural beauty while enjoying your adventures.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 13, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 7
                },
                new Article
                {
                    ArticleId = 22,
                    Title = "Culinary Tourism: Savoring Global Flavors",
                    ShortDescription = "Tasting the world's delicious cuisine",
                    Content = "One of the joys of travel is indulging in diverse and delectable culinary experiences. This article celebrates culinary tourism, where you can savor the flavors of various cuisines worldwide. From street food to fine dining, embark on a gastronomic journey that will tantalize your taste buds and create unforgettable memories.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 14, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 7
                },
                new Article
                {
                    ArticleId = 23,
                    Title = "The Evolution of Cinema",
                    ShortDescription = "From silent films to modern blockbusters",
                    Content = "The world of cinema has witnessed a remarkable evolution over the decades. This article takes you on a journey through the history of filmmaking, from the early days of silent movies to the era of modern blockbusters. Explore the impact of technology, storytelling, and cultural influences on the film industry.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 15, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 8
                },
                new Article
                {
                    ArticleId = 24,
                    Title = "Music Through the Ages",
                    ShortDescription = "A journey of melodies and rhythms",
                    Content = "Music is a universal language that has been an integral part of human culture for centuries. This article traces the evolution of music through various genres, styles, and eras. From classical compositions to contemporary hits, immerse yourself in the world of melodies and rhythms that have shaped our lives.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 16, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 8
                },
                new Article
                {
                    ArticleId = 25,
                    Title = "Gaming: Beyond Entertainment",
                    ShortDescription = "The impact of video games on society",
                    Content = "Video games have evolved from simple amusements to a major form of entertainment and a cultural phenomenon. This article explores the multifaceted world of gaming, its influence on society, and its role in education, art, and technology. Dive into the world of gaming and its broader impact on our lives.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 17, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 8
                },
                new Article
                {
                    ArticleId = 26,
                    Title = "The Rise of Artificial Intelligence",
                    ShortDescription = "Exploring AI's impact on our world",
                    Content = "Artificial Intelligence (AI) is revolutionizing industries and reshaping the way we live and work. This article delves into the rapid advancements in AI technology, its applications in various sectors, and the ethical considerations surrounding its use. Discover how AI is changing the landscape of technology and society as a whole.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 18, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 9
                },
                new Article
                {
                    ArticleId = 27,
                    Title = "Cybersecurity in the Digital Age",
                    ShortDescription = "Protecting data in an interconnected world",
                    Content = "In an era of increasing digitalization, cybersecurity is paramount. This article explores the evolving landscape of cybersecurity, from data breaches to protective measures. Learn about the challenges in safeguarding digital information and the strategies to defend against cyber threats and attacks.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 19, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 9
                },
                new Article
                {
                    ArticleId = 28,
                    Title = "Emerging Tech Trends in 2023",
                    ShortDescription = "A glimpse into the future of technology",
                    Content = "The tech industry is constantly evolving. This article provides insights into the emerging technology trends of 2023, including 5G, blockchain, and the Internet of Things (IoT). Stay informed about the latest innovations that are shaping the way we live and the future of technology.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 20, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 9
                },
                new Article
                {
                    ArticleId = 29,
                    Title = "Trends in Sustainable Fashion",
                    ShortDescription = "Eco-friendly style for a greener world",
                    Content = "Sustainable fashion is a growing trend that prioritizes eco-friendly materials and ethical production practices. This article explores the latest trends in sustainable fashion, from upcycled clothing to environmentally conscious brands. Discover how you can make stylish choices that are also good for the planet.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 21, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 10
                },
                new Article
                {
                    ArticleId = 30,
                    Title = "The Influence of Street Style",
                    ShortDescription = "Urban fashion's impact on mainstream culture",
                    Content = "Street style has evolved from underground subcultures to influencing mainstream fashion. This article explores the influence of street fashion on the broader culture, from hip-hop to skater aesthetics. Discover how street style has become a major force in the fashion industry and how it reflects cultural movements.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 22, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 10
                },
                new Article
                {
                    ArticleId = 31,
                    Title = "The Art of Accessorizing",
                    ShortDescription = "Elevate your style with the right accessories",
                    Content = "Accessories are an essential part of any fashion ensemble. This article delves into the art of accessorizing, from statement jewelry to handbags and scarves. Learn how the right accessories can transform your look and add a personal touch to your fashion choices.",
                    Published = true,
                    CreatedDate = new DateTime(2023, 11, 11, 23, 0, 0),
                    UpdatedDate = null,
                    CategoryId = 10
                }
            );

            var roles = new IdentityRole[]
            {
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Writer",
                    NormalizedName = "WRITER"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Guest",
                    NormalizedName = "GUEST"
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            var hasher = new PasswordHasher<Member>();
            var memmbers = new Member[]
            {
                new Member
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "admin@dailynews.com",
                    UserName = "admin@dailynews.com",
                    NormalizedEmail = "ADMIN@DAILYNEWSNEWS.COM",
                    NormalizedUserName = "ADMIN@DAILYNEWSNEWS.COM",
                    EmailConfirmed = false,
                    FirstName = "Admin",
                    Actice = true,
                    AccessFailedCount = 0,
                    PasswordHash = hasher.HashPassword(null, "DailyNews@123")
                },
                new Member
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "writer@dailynews.com",
                    UserName = "writer@dailynews.com",
                    NormalizedEmail = "WRITER@DAILYNEWSNEWS.COM",
                    NormalizedUserName = "WRITER@DAILYNEWSNEWS.COM",
                    EmailConfirmed = false,
                    FirstName = "Writer",
                    LastName = "Isaac",
                    Actice = true,
                    AccessFailedCount = 0,
                    PasswordHash = hasher.HashPassword(null, "DailyNews@123")
                },
                new Member
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "user@dailynews.com",
                    UserName = "user@dailynews.com",
                    NormalizedEmail = "USER@DAILYNEWSNEWS.COM",
                    NormalizedUserName = "USER@DAILYNEWSNEWS.COM",
                    EmailConfirmed = false,
                    FirstName = "User",
                    LastName = "Benjamin",
                    Actice = true,
                    AccessFailedCount = 0,
                    PasswordHash = hasher.HashPassword(null, "DailyNews@123"),
                }
            };

            modelBuilder.Entity<Member>().HasData(memmbers);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roles[0].Id,
                    UserId = memmbers[0].Id,
                },
                new IdentityUserRole<string>
                {
                    RoleId = roles[1].Id,
                    UserId = memmbers[1].Id,
                },
                new IdentityUserRole<string>
                {
                    RoleId = roles[2].Id,
                    UserId = memmbers[2].Id,
                }
            );
        }
    }
}
