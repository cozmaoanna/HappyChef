using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyChef.Server.Data.Migrations
{
    public partial class addingfavourites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipeUri",
                table: "FavouritesList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FavouritesList",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeUri",
                table: "FavouritesList");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FavouritesList");
        }
    }
}
