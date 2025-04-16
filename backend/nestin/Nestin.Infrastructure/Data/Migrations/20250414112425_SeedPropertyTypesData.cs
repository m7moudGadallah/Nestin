using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nestin.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPropertyTypesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "house", "House/Apartment" },
                    { 2, "bed-single", "Room" },
                    { 3, "hotel", "Hotel" },
                    { 4, "sun-moon", "Unique & Themed Stays" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
