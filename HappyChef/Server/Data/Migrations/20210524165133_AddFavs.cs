using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyChef.Server.Data.Migrations
{
    public partial class AddFavs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavouritesList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouriteLabel = table.Column<string>(nullable: true),
                    FavouriteCalories = table.Column<float>(nullable: false),
                    FavouriteTotalTime = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouritesList", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouritesList");
        }
    }
}
