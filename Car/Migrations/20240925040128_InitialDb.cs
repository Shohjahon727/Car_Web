using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Manufacturer = table.Column<string>(type: "text", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carss", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carss",
                columns: new[] { "Id", "Color", "Manufacturer", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "White", "Chevrolet", "Cobalt", 10000m },
                    { 2, "Black", "Chevrolet", "Malibu", 15000m },
                    { 3, "Green", "Toyota", "Camry", 12000m },
                    { 4, "Red", "Honda", "Civic", 8000m },
                    { 5, "Yellow", "Ford", "Focus", 7000m },
                    { 6, "Black", "BMW", "X5", 20000m },
                    { 7, "Blue", "Audi", "A4", 9000m },
                    { 8, "Black", "Mercedes", "C-Class", 18000m },
                    { 9, "White", "Hyundai", "Elantra", 11000m },
                    { 10, "Green", "Kia", "Optima", 6000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carss");
        }
    }
}
