using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyNews.BusinessObject.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e97852d-2d43-4877-8c3e-59a3485f33a5", "54a6821f-d0c5-4c3e-a2c6-9d95c329b422", "Guest", "GUEST" },
                    { "76a6d947-6a85-4514-8655-ef3a7facbb3c", "c211937f-6501-4dde-a3e2-50e59d3a1a45", "User", "USER" },
                    { "a6507381-b326-4799-be6a-f16fa32fbf2a", "dd4c65c9-1392-4cf8-a5ad-a07c9b8c67cb", "Writer", "WRITER" },
                    { "b8f23bd7-b4a0-4366-b1f6-e6e1dd591c2c", "72f812a1-5ebf-4248-a68c-64a86276588d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2447c012-3010-4158-90b7-cc8fbc8df6cc", 0, "8f1516de-9d90-40a8-8f62-4c94cb2720e2", "user@dailynews.com", false, "User", "Benjamin", false, null, "USER@DAILYNEWSNEWS.COM", "USER@DAILYNEWSNEWS.COM", "AQAAAAEAACcQAAAAELTA/t1E1JoX1DERLr+DfX/AWLb4Zp1Xv20WEfk0uTu4Ff8pP3BE7pCifd9WSqV2Hw==", null, false, "7d3f76c8-68e5-4ef7-86fc-8c7554eb2c8c", false, "user@dailynews.com" },
                    { "62c17baa-fccf-4bfc-8e78-3af160893944", 0, "62de893a-33aa-415d-8d72-8097a40d0636", "admin@dailynews.com", false, "Admin", null, false, null, "ADMIN@DAILYNEWSNEWS.COM", "ADMIN@DAILYNEWSNEWS.COM", "AQAAAAEAACcQAAAAEHHl0WFShoqG8514sCKfSJMhYKNjGTbu9JOmjZ2Yx5aT61kAMlXErbYB7H36Ekod4w==", null, false, "d5bf1ed9-834b-4ba4-abbf-4d64d19738ad", false, "admin@dailynews.com" },
                    { "737cba88-c434-4401-99d1-38db63ab83f7", 0, "cb32e9f2-6de6-4340-af30-8138f1be8be8", "writer@dailynews.com", false, "Writer", "Isaac", false, null, "WRITER@DAILYNEWSNEWS.COM", "WRITER@DAILYNEWSNEWS.COM", "AQAAAAEAACcQAAAAELSo6eNmBbEUzqLEkwcrjXHTh1yj62O/dkGr76HEhhlrkhE3AF8fM7XElkcf5g4DaQ==", null, false, "5bc223fa-e050-4624-b588-645aac51570f", false, "writer@dailynews.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Politics", null },
                    { 2, "Economics", null },
                    { 3, "Life", null },
                    { 4, "Health", null },
                    { 5, "For teens", null },
                    { 6, "Education", null },
                    { 7, "Tourism", null },
                    { 8, "Entertainment", null },
                    { 9, "Technology", null },
                    { 10, "Fashion", null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "Content", "CreatedDate", "Published", "ShortDescription", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 4, "Regular exercise has numerous benefits for your overall health. It can help you maintain a healthy weight, reduce the risk of chronic diseases, and improve your mood. Exercise is not just about physical fitness; it also enhances mental well-being. It can reduce stress and anxiety, boost self-esteem, and increase cognitive function. Whether it's a brisk walk, a yoga session, or a full-blown workout, make exercise a part of your daily routine for a healthier, happier life.", new DateTime(2023, 11, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Stay active and healthy", "Benefits of Regular Exercise", null },
                    { 2, 4, "Maintaining healthy eating habits is essential for your well-being. A balanced diet rich in fruits, vegetables, and whole grains provides essential nutrients for your body. It can help prevent various health issues, including heart disease and diabetes. In addition, a proper diet can boost your energy levels and promote weight management. Start making mindful food choices today for a healthier lifestyle.", new DateTime(2023, 11, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "Nourish your body with the right food", "Healthy Eating Habits", null },
                    { 3, 3, "Time management is crucial in our fast-paced world. Properly managing your time can increase productivity and reduce stress. Prioritizing tasks, setting goals, and avoiding distractions are key components of effective time management. By optimizing your daily routine, you can achieve more in less time, leaving room for relaxation and personal growth.", new DateTime(2023, 11, 6, 11, 5, 0, 0, DateTimeKind.Unspecified), true, "Maximize productivity and reduce stress", "Effective Time Management", null },
                    { 4, 4, "Getting enough quality sleep is essential for physical and mental health. Sleep allows your body to rest, repair, and recharge. It plays a vital role in memory consolidation and emotional well-being. Lack of sleep can lead to a range of health issues, including impaired cognitive function and mood disturbances. Prioritize your sleep schedule to lead a healthier and more productive life.", new DateTime(2023, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), true, "Rest for a healthier life", "The Importance of Sleep", null },
                    { 5, 1, "Politics is a complex field with a variety of ideologies. From conservatism to liberalism, socialism to libertarianism, it's essential to understand the different political beliefs that shape our world. Each ideology has its unique approach to governance, economics, and societal issues. By gaining insight into these ideologies, you can make informed political decisions and engage in meaningful discussions about the future of your nation.", new DateTime(2023, 11, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "Exploring diverse political beliefs", "Understanding Political Ideologies", null },
                    { 6, 1, "Media plays a significant role in shaping public opinion and influencing political decisions. In the age of 24/7 news coverage and social media, understanding how media operates within the political landscape is crucial. It can influence elections, policy debates, and public discourse. Explore the relationship between media and politics to become a more informed citizen.", new DateTime(2023, 11, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), true, "Media's impact on political landscape", "The Role of Media in Politics", null },
                    { 7, 1, "The world faces numerous political challenges, from climate change to international conflicts. Understanding and addressing these global issues is critical for a more stable and prosperous future. Explore the complexities of international politics and the interconnected nature of global challenges. Discover the efforts and initiatives aimed at finding solutions to these pressing problems.", new DateTime(2023, 11, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), true, "Addressing pressing global issues", "Global Political Challenges", null },
                    { 8, 2, "Economics is the study of how societies allocate their limited resources to meet their needs and wants. In this introductory article, we delve into the fundamental economic principles, including supply and demand, opportunity cost, and the role of markets in resource allocation. Understanding these concepts is crucial for making informed economic decisions in your personal and professional life.", new DateTime(2023, 11, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), true, "Exploring fundamental economic concepts", "Introduction to Economic Principles", null },
                    { 9, 2, "Inflation is a common economic phenomenon where the general price level of goods and services increases over time. This article explores the impact of inflation on individuals, businesses, and the overall economy. Learn how inflation can erode purchasing power, affect investment decisions, and influence monetary policy. Understanding inflation is essential for financial planning and economic analysis.", new DateTime(2023, 11, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "Unpacking the effects of rising prices", "Impact of Inflation on the Economy", null },
                    { 10, 2, "International trade is a key driver of the global economy. This article delves into the intricacies of international trade, including the benefits of trade, trade agreements, and the impact of tariffs and trade barriers. Understand how global economic interdependence shapes the prosperity of nations and how international trade can impact various industries and markets.", new DateTime(2023, 11, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "Exploring the dynamics of global trade", "International Trade and Global Economics", null },
                    { 11, 3, "Finding the right balance between work and personal life is crucial for overall well-being. This article explores strategies for managing your professional responsibilities while making time for personal life, hobbies, and relaxation. Achieving this balance can lead to reduced stress and a more fulfilling life outside of work.", new DateTime(2023, 11, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "Achieving harmony in your daily life", "Balancing Work and Personal Life", null },
                    { 12, 3, "Healthy relationships are a cornerstone of a fulfilling life. This article delves into the key principles of building and maintaining healthy connections with friends, family, and partners. Learn effective communication, conflict resolution, and emotional intelligence to foster positive and meaningful relationships in your life.", new DateTime(2023, 11, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), true, "Nurturing meaningful connections in life", "Building Healthy Relationships", null },
                    { 14, 5, "Teenage years are a crucial time for personal development. This article focuses on promoting healthy habits for teenagers, including proper nutrition, exercise, and mental well-being. Discover how to make positive lifestyle choices that can set the foundation for a healthy and fulfilling adulthood.", new DateTime(2023, 11, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), true, "Promoting well-being in teenage years", "Healthy Habits for Teens", null },
                    { 15, 5, "Peer pressure is a common experience for teenagers. This article provides guidance on how to navigate peer pressure and make informed choices in social situations. Learn to assert your values, set boundaries, and build strong, supportive friendships during your teenage years.", new DateTime(2023, 11, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), true, "Making informed choices in social situations", "Navigating Peer Pressure", null },
                    { 16, 5, "As a teenager, it's never too early to start exploring potential career paths. This article offers insights and tips on how to begin your career exploration journey. Learn about different career options, educational paths, and how to set goals for your future. By starting early, you can make informed decisions about your career.", new DateTime(2023, 11, 10, 4, 0, 0, 0, DateTimeKind.Unspecified), true, "Discovering your future path", "Career Exploration for Teens", null },
                    { 17, 6, "Early childhood education plays a crucial role in a child's development. This article explores the significance of quality preschool and kindergarten programs in preparing children for academic success and social growth. Discover the long-term benefits of early education and how it can set the stage for a lifetime of learning.", new DateTime(2023, 11, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Laying the foundation for lifelong learning", "The Importance of Early Childhood Education", null },
                    { 18, 6, "Online learning has become increasingly prevalent in the education landscape. This article discusses the evolution of online education and its impact on traditional learning methods. Explore the advantages and challenges of virtual classrooms and how they are shaping the future of education.", new DateTime(2023, 11, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), true, "Adapting to the digital age of learning", "Online Learning and the Future of Education", null },
                    { 19, 6, "Teachers are the cornerstone of education. This article highlights the vital role that teachers play in fostering a love for learning, critical thinking, and personal growth in students. Learn about the challenges educators face and the rewards of inspiring young minds to achieve their full potential.", new DateTime(2023, 11, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), true, "Nurturing young minds for a brighter future", "The Role of Teachers in Fostering Learning", null },
                    { 20, 7, "Travel enthusiasts, get ready to embark on an exploration of exotic destinations around the world. This article takes you on a journey to breathtaking locations, from tropical paradises to historical wonders. Discover travel tips, local cultures, and the wonders that await those who seek new horizons.", new DateTime(2023, 11, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), true, "Adventures in far-off lands", "Exploring Exotic Destinations", null },
                    { 21, 7, "As travelers, it's crucial to embrace sustainable tourism practices. This article emphasizes the importance of responsible and eco-friendly travel. Learn how to minimize your impact on the environment, support local communities, and contribute to the preservation of natural beauty while enjoying your adventures.", new DateTime(2023, 11, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), true, "Preserving the beauty of our planet", "Sustainable Tourism Practices", null },
                    { 22, 7, "One of the joys of travel is indulging in diverse and delectable culinary experiences. This article celebrates culinary tourism, where you can savor the flavors of various cuisines worldwide. From street food to fine dining, embark on a gastronomic journey that will tantalize your taste buds and create unforgettable memories.", new DateTime(2023, 11, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), true, "Tasting the world's delicious cuisine", "Culinary Tourism: Savoring Global Flavors", null },
                    { 23, 8, "The world of cinema has witnessed a remarkable evolution over the decades. This article takes you on a journey through the history of filmmaking, from the early days of silent movies to the era of modern blockbusters. Explore the impact of technology, storytelling, and cultural influences on the film industry.", new DateTime(2023, 11, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), true, "From silent films to modern blockbusters", "The Evolution of Cinema", null },
                    { 24, 8, "Music is a universal language that has been an integral part of human culture for centuries. This article traces the evolution of music through various genres, styles, and eras. From classical compositions to contemporary hits, immerse yourself in the world of melodies and rhythms that have shaped our lives.", new DateTime(2023, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), true, "A journey of melodies and rhythms", "Music Through the Ages", null },
                    { 25, 8, "Video games have evolved from simple amusements to a major form of entertainment and a cultural phenomenon. This article explores the multifaceted world of gaming, its influence on society, and its role in education, art, and technology. Dive into the world of gaming and its broader impact on our lives.", new DateTime(2023, 11, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), true, "The impact of video games on society", "Gaming: Beyond Entertainment", null },
                    { 26, 9, "Artificial Intelligence (AI) is revolutionizing industries and reshaping the way we live and work. This article delves into the rapid advancements in AI technology, its applications in various sectors, and the ethical considerations surrounding its use. Discover how AI is changing the landscape of technology and society as a whole.", new DateTime(2023, 11, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), true, "Exploring AI's impact on our world", "The Rise of Artificial Intelligence", null },
                    { 27, 9, "In an era of increasing digitalization, cybersecurity is paramount. This article explores the evolving landscape of cybersecurity, from data breaches to protective measures. Learn about the challenges in safeguarding digital information and the strategies to defend against cyber threats and attacks.", new DateTime(2023, 11, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), true, "Protecting data in an interconnected world", "Cybersecurity in the Digital Age", null },
                    { 28, 9, "The tech industry is constantly evolving. This article provides insights into the emerging technology trends of 2023, including 5G, blockchain, and the Internet of Things (IoT). Stay informed about the latest innovations that are shaping the way we live and the future of technology.", new DateTime(2023, 11, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), true, "A glimpse into the future of technology", "Emerging Tech Trends in 2023", null },
                    { 29, 10, "Sustainable fashion is a growing trend that prioritizes eco-friendly materials and ethical production practices. This article explores the latest trends in sustainable fashion, from upcycled clothing to environmentally conscious brands. Discover how you can make stylish choices that are also good for the planet.", new DateTime(2023, 11, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), true, "Eco-friendly style for a greener world", "Trends in Sustainable Fashion", null },
                    { 30, 10, "Street style has evolved from underground subcultures to influencing mainstream fashion. This article explores the influence of street fashion on the broader culture, from hip-hop to skater aesthetics. Discover how street style has become a major force in the fashion industry and how it reflects cultural movements.", new DateTime(2023, 11, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), true, "Urban fashion's impact on mainstream culture", "The Influence of Street Style", null },
                    { 31, 10, "Accessories are an essential part of any fashion ensemble. This article delves into the art of accessorizing, from statement jewelry to handbags and scarves. Learn how the right accessories can transform your look and add a personal touch to your fashion choices.", new DateTime(2023, 11, 11, 23, 0, 0, 0, DateTimeKind.Unspecified), true, "Elevate your style with the right accessories", "The Art of Accessorizing", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "76a6d947-6a85-4514-8655-ef3a7facbb3c", "2447c012-3010-4158-90b7-cc8fbc8df6cc" },
                    { "b8f23bd7-b4a0-4366-b1f6-e6e1dd591c2c", "62c17baa-fccf-4bfc-8e78-3af160893944" },
                    { "a6507381-b326-4799-be6a-f16fa32fbf2a", "737cba88-c434-4401-99d1-38db63ab83f7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
