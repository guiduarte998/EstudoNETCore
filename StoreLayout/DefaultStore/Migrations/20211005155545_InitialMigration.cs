using Microsoft.EntityFrameworkCore.Migrations;

namespace DefaultStore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Barcode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Barcode);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Barcode", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 123343453, "Grãos", "Arroz", 0.98m },
                    { 123456710, "Grãos", "Feijão", 1.69m },
                    { 987654321, "Proteina", "Carne", 4.79m },
                    { 123456789, "Liquido", "Azeite", 2.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
