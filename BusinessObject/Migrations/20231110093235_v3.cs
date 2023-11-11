using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyNews.BusinessObject.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "Content", "CreatedDate", "Published", "ShortDescription", "Title", "UpdatedDate" },
                values: new object[] { 1, 4, "Regular exercise has numerous benefits for your overall health. It can help you maintain a healthy weight, reduce the risk of chronic diseases, and improve your mood. Exercise is not just about physical fitness; it also enhances mental well-being. It can reduce stress and anxiety, boost self-esteem, and increase cognitive function. Whether it's a brisk walk, a yoga session, or a full-blown workout, make exercise a part of your daily routine for a healthier, happier life.", new DateTime(2023, 11, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), true, "Stay active and healthy", "Benefits of Regular Exercise", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Politics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "World");
        }
    }
}
