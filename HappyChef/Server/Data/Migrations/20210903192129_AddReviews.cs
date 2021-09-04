using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyChef.Server.Data.Migrations
{
    public partial class AddReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReviewList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    RecipeUri = table.Column<string>(nullable: true),
                    ReviewText = table.Column<string>(nullable: true),
                    Stars = table.Column<int>(nullable: false),
                    DateStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewList");
        }
    }
}
