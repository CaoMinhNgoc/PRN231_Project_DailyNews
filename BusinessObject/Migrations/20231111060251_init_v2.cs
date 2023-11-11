using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyNews.BusinessObject.Migrations
{
    public partial class init_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e97852d-2d43-4877-8c3e-59a3485f33a5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76a6d947-6a85-4514-8655-ef3a7facbb3c", "2447c012-3010-4158-90b7-cc8fbc8df6cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8f23bd7-b4a0-4366-b1f6-e6e1dd591c2c", "62c17baa-fccf-4bfc-8e78-3af160893944" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6507381-b326-4799-be6a-f16fa32fbf2a", "737cba88-c434-4401-99d1-38db63ab83f7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76a6d947-6a85-4514-8655-ef3a7facbb3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6507381-b326-4799-be6a-f16fa32fbf2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8f23bd7-b4a0-4366-b1f6-e6e1dd591c2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2447c012-3010-4158-90b7-cc8fbc8df6cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62c17baa-fccf-4bfc-8e78-3af160893944");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "737cba88-c434-4401-99d1-38db63ab83f7");

            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a8dff705-c4e8-4a75-9090-22910978b7aa", "1208b015-b411-421c-94cd-29ab2971382c", "Writer", "WRITER" },
                    { "b12f815d-6da0-4fb7-a3e9-b05fa8331eaf", "a52339aa-ccfb-4351-89b1-3b3b99519e94", "Guest", "GUEST" },
                    { "cc84ea3c-3288-4f5f-bf25-09444f232dd9", "831e98d5-38e8-4c24-a739-477ecabcab97", "User", "USER" },
                    { "ea084acf-14ef-4138-96be-1b3db76e405b", "a787bf9e-62d6-465c-9030-38087dfb0412", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "594a123f-674c-4c8d-add8-0a4d517558a5", 0, "9a841e95-3429-4af0-8618-5b731df5fc45", "user@dailynews.com", false, "User", "Benjamin", false, null, "USER@DAILYNEWSNEWS.COM", "USER@DAILYNEWSNEWS.COM", "AQAAAAEAACcQAAAAELi/GMYaXWG+0Koa+FkQrBpDDF7NtwLPg+MkJAYjb2Y248D7EXKuAHUfSxR6qybDGQ==", null, false, "bd98d380-216d-4474-9dc0-cc0e48bb2e96", false, "user@dailynews.com" },
                    { "77cbb596-f510-4b51-a89e-b7a4535a6ee1", 0, "a2291019-9eac-4afe-8c75-f2b58a1ea1a5", "admin@dailynews.com", false, "Admin", null, false, null, "ADMIN@DAILYNEWSNEWS.COM", "ADMIN@DAILYNEWSNEWS.COM", "AQAAAAEAACcQAAAAEJgng3rxR9pn7cXdf/SIOIfMBVWTO2o3865UD3IMJuW+2aKvSxDfDE2ys5ZPxyE69g==", null, false, "ecdff81b-aae2-4fe9-820d-ae245d9bebf8", false, "admin@dailynews.com" },
                    { "d1029da4-59f0-4643-ab94-90642bf89062", 0, "13c5f42d-e233-4349-a3a2-ed2094aa048c", "writer@dailynews.com", false, "Writer", "Isaac", false, null, "WRITER@DAILYNEWSNEWS.COM", "WRITER@DAILYNEWSNEWS.COM", "AQAAAAEAACcQAAAAEA+y4W1GlpkUlc/xU8LfHbvMfdUEfId9X3PoQIzgzTnKk4IcJkw+wO7SjTkm2+wdMw==", null, false, "8f51bed5-5d4a-45d9-9d38-348cf96159a8", false, "writer@dailynews.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc84ea3c-3288-4f5f-bf25-09444f232dd9", "594a123f-674c-4c8d-add8-0a4d517558a5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ea084acf-14ef-4138-96be-1b3db76e405b", "77cbb596-f510-4b51-a89e-b7a4535a6ee1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a8dff705-c4e8-4a75-9090-22910978b7aa", "d1029da4-59f0-4643-ab94-90642bf89062" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MemberId",
                table: "Comments",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_MemberId",
                table: "Comments",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_MemberId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MemberId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b12f815d-6da0-4fb7-a3e9-b05fa8331eaf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc84ea3c-3288-4f5f-bf25-09444f232dd9", "594a123f-674c-4c8d-add8-0a4d517558a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea084acf-14ef-4138-96be-1b3db76e405b", "77cbb596-f510-4b51-a89e-b7a4535a6ee1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a8dff705-c4e8-4a75-9090-22910978b7aa", "d1029da4-59f0-4643-ab94-90642bf89062" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8dff705-c4e8-4a75-9090-22910978b7aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc84ea3c-3288-4f5f-bf25-09444f232dd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea084acf-14ef-4138-96be-1b3db76e405b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "594a123f-674c-4c8d-add8-0a4d517558a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77cbb596-f510-4b51-a89e-b7a4535a6ee1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1029da4-59f0-4643-ab94-90642bf89062");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Comments");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "76a6d947-6a85-4514-8655-ef3a7facbb3c", "2447c012-3010-4158-90b7-cc8fbc8df6cc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b8f23bd7-b4a0-4366-b1f6-e6e1dd591c2c", "62c17baa-fccf-4bfc-8e78-3af160893944" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6507381-b326-4799-be6a-f16fa32fbf2a", "737cba88-c434-4401-99d1-38db63ab83f7" });
        }
    }
}
