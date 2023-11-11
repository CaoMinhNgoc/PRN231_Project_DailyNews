using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyNews.BusinessObject.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comments",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Articles",
                newName: "Published");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Articles",
                newName: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Published",
                table: "Articles",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Articles",
                newName: "Id");
        }
    }
}
