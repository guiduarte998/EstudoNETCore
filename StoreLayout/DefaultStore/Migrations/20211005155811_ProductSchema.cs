using Microsoft.EntityFrameworkCore.Migrations;

namespace DefaultStore.Migrations
{
    public partial class ProductSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "Store");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Store",
                newName: "Products");
        }
    }
}
