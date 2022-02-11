using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVC.Migrations
{
    public partial class DBNamesSnakeCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "category",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "category",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "category",
                newName: "display_order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category",
                table: "category",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_category",
                table: "category");

            migrationBuilder.RenameTable(
                name: "category",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Category",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "display_order",
                table: "Category",
                newName: "DisplayOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");
        }
    }
}
