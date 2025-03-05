using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Telefon Açıklaması", "1.jpg", true, "Iphone 11", 70000m, 100 },
                    { 2, "Telefon Açıklaması", "1.jpg", true, "Iphone 12", 70000m, 100 },
                    { 3, "Telefon Açıklaması", "1.jpg", true, "Iphone 13", 70000m, 100 },
                    { 4, "Telefon Açıklaması", "1.jpg", true, "Iphone 14", 70000m, 100 },
                    { 5, "Telefon Açıklaması", "1.jpg", true, "Iphone 15", 70000m, 100 },
                    { 6, "Telefon Açıklaması", "1.jpg", true, "Iphone 16", 70000m, 100 },
                    { 7, "Telefon Açıklaması", "1.jpg", true, "Iphone 16", 70000m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
