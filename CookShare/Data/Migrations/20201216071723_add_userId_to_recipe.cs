using Microsoft.EntityFrameworkCore.Migrations;

namespace CookShare.Data.Migrations
{
    public partial class add_userId_to_recipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "Recipes");
        }
    }
}
