﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CookShare.Data.Migrations
{
    public partial class AddedDescriptionToRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipes");
        }
    }
}
